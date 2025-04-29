using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json.Linq;
using SistemaMonitoramentoSE.Controllers;
using SistemaMonitoramentoSE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace SistemaMonitoramentoSE.Handler
{
    public class SwitchConnection
    {
        private readonly UdpClient udp_client;
        private readonly CancellationTokenSource cts = new();
        private Task? read_task;
        private Form form;

        private readonly Dictionary<string, IMessageHandler> handlers = new Dictionary<string, IMessageHandler> {
            { "M1/DATA",   new M1Data1Handler() },
            { "M2/DATA",   new M2DataHandler() },
            { "M4/DATA",   new M4DataHandler() },
            { "M4/CREATE", new M4CreateHandler() },
            { "M4/DELETE", new M4DeleteHandler() },
            { "M4/UPDATE", new M4UpdateHandler() },
            { "M5/DATA",   new M5DataHandler() }
        };
        
        public SwitchConnection(int port, Form form)
        {
            udp_client = new UdpClient(new IPEndPoint(IPAddress.Any, port));
            this.form = form;
        }

        public void Start()
        {
            read_task = Task.Run(() => ListenAsync(cts.Token));
        }

        public void Stop()
        {
            cts.Cancel();
            read_task?.Wait();
            udp_client.Close();
        }

        private async Task ListenAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var result = await udp_client.ReceiveAsync();
                    string raw = Encoding.UTF8.GetString(result.Buffer);

                    JObject json = JObject.Parse(raw);
                    string? uri = json["URI"]?.ToString();

                    if (uri != null && handlers.TryGetValue(uri, out var handler))
                        handler.Handle(json, form);
                    else
                        Console.WriteLine($"Mensagem com URI desconhecida: {uri}\n{json.ToString()}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao receber o pacote: {ex.Message}");
                }
            }
        }

    }

    class M1Data1Handler : IMessageHandler
    {
        private static readonly List<Modulo1Model> buffer_m1 = new();
        public static IReadOnlyList<Modulo1Model> get_buffer_m1 => buffer_m1;
        private static readonly Dictionary<int, bool> existe_m1 = new();
        private static readonly List<MedidasM1Model> buffer_medidas = new();
        public static IReadOnlyList<MedidasM1Model> get_buffer_medidas => buffer_medidas;
        private readonly object locker_m1 = new object();
        private readonly object locker_medidas = new object();

        public void Handle(JObject message, Form form)
        {
            Modulo1Model modulo;
            MedidasM1Model medida;

            modulo = Modulo1Controller.GetById(Convert.ToInt32(message["module_id"]));

            if (modulo == null)
            {
                modulo = new Modulo1Model(
                    module_id:      Convert.ToInt32(message["module_id"]?.ToString()),
                    mac_address:    message["mac_address"]?.ToString() ?? throw new ArgumentException("MAC Address nulo!"),
                    num_packages:   Convert.ToInt32(message["num_packages"]?.ToString()),
                    timestamp:      DateTime.TryParse(message["timestamp"]?.ToString(), out var ts_modulo) ? ts_modulo : throw new ArgumentException("Timestamp nulo!"),
                    send_freq_ms:   Convert.ToInt32(message["send_freq_ms"]?.ToString())
                );
                existe_m1[modulo.module_id] = false;
            }
            else existe_m1[modulo.module_id] = true;

            medida = new MedidasM1Model(
                medida_id:      modulo.num_packages,
                module_id:      modulo.module_id,
                fase:           message["medidas"]?["fase"]?.ToString() ?? throw new ArgumentException("Fase nulo!"),
                tensao:         (float)Convert.ToDouble(message["medidas"]?["tensao"]?.ToString()),
                corrente:       (float)Convert.ToDouble(message["medidas"]?["corrente"]?.ToString()),
                angTensao:      (float)Convert.ToDouble(message["medidas"]?["angTensao"]?.ToString()),
                potApaVa:       (float)Convert.ToDouble(message["medidas"]?["potApaVA"]?.ToString()),
                potRealVAr:     (float)Convert.ToDouble(message["medidas"]?["potRealVAr"]?.ToString()),
                potRealW:       (float)Convert.ToDouble(message["medidas"]?["potRealW"]?.ToString()),
                fatorP:         (float)Convert.ToDouble(message["medidas"]?["fatorP"]?.ToString()),
                freq:           (float)Convert.ToDouble(message["medidas"]?["freq"]?.ToString()),
                timestamp:      modulo.timestamp,
                target_vat:     message["target_vat"]?.ToString(),
                target_phase:   message["target_phase"]?.ToString()
            );

            var tasks = new List<Task>();
            if (buffer_m1.Count >= 1000)
            {
                int quantidade_instancias = Modulo1Controller.GetAll().Count;
                tasks.Add(Task.Run(() =>
                {
                    lock (locker_m1)
                    {
                        for (int i = 0; i < buffer_m1.Count; i++)
                        {
                            if (!existe_m1[buffer_m1[i].module_id])
                            {
                                Modulo1Controller.Create(buffer_m1[i]);
                                existe_m1[buffer_m1[i].module_id] = true;

                                var combx_instancias = form.Controls.Find("combx_instancias", true).FirstOrDefault() as ComboBox;
                                var combx_sel_instancia = form.Controls.Find("combx_sel_instancia", true).FirstOrDefault() as ComboBox;

                                combx_sel_instancia.Items.Add($"M1: #{buffer_m1[i].module_id}");
                                if ((quantidade_instancias + 1) % 4 == 1)
                                    combx_instancias.Items.Add($"M1: #{quantidade_instancias+1} - #{quantidade_instancias+4}");
                            }
                        }
                        buffer_m1.Clear();
                    }
                }));
            }

            if (buffer_medidas.Count >= 1000)
            {
                tasks.Add(Task.Run(() =>
                {
                    lock (locker_medidas)
                    {
                        for (int i = 0; i < buffer_medidas.Count; i++)
                        {
                            MedidasM1Controller.Create(buffer_medidas[i]);
                        }

                        buffer_medidas.Clear();
                    }
                }));
            }

            Task.WaitAll(tasks.ToArray());
            buffer_m1.Add(modulo);
            buffer_medidas.Add(medida);
        }
    }

    class M2DataHandler : IMessageHandler
    {
        private static readonly List<Modulo2Model> buffer_m2 = new();
        public static IReadOnlyList<Modulo2Model> get_buffer_m2 => buffer_m2;
        private static readonly Dictionary<int, bool> existe_m2 = new();
        private static readonly List<MedidasM2Model> buffer_medidas_m2 = new();
        public static IReadOnlyList<MedidasM2Model> get_buffer_medidas_m2 => buffer_medidas_m2;
        private readonly object locker_m2 = new object();
        private readonly object locker_medidas = new object();

        public void Handle(JObject message, Form _)
        {
            Modulo2Model modulo;
            MedidasM2Model medida;

            modulo = Modulo2Controller.GetById(Convert.ToInt32(message["module_id"]?.ToString()));

            if (modulo == null)
            {
                modulo = new Modulo2Model(
                    module_id:  Convert.ToInt32(message["module_id"]?.ToString()),
                   module1_id:  Convert.ToInt32(message["module1_id"]?.ToString()),
                   mac_address: message["mac_address"]?.ToString() ?? throw new ArgumentException("MAC Address nulo!"),
                   timestamp:   DateTime.TryParse(message["timestamp"]?.ToString(), out var ts) ? ts : throw new ArgumentException("Timestamp nulo!")
                );
                existe_m2[modulo.module_id] = false;
            }
            else existe_m2[modulo.module_id] = true;

            medida = new MedidasM2Model(
                module2_id:     Convert.ToInt32(message["module_id"]?.ToString()),
                short_circuit:  Convert.ToBoolean(message["short_circuit"]?.ToString()),
                data_init:      DateTime.TryParse(message["data_init"]?.ToString(), out var ti) ? ti : throw new ArgumentException("Data inicial do evento nula!"),
                data_end:       DateTime.TryParse(message["data_end"]?.ToString(), out var te) ? te : throw new ArgumentException("Data fim de evento nulo!")
            );

            var tasks = new List<Task>();
            if (buffer_m2.Count > 500)
            {
                lock (locker_m2)
                {
                    for (int i = 0; i < buffer_m2.Count; i++)
                    {
                        if (!existe_m2[buffer_m2[i].module_id])
                        {
                            Modulo2Controller.Create(buffer_m2[i]);
                            existe_m2[buffer_m2[i].module_id] = true;
                        }
                    }
                    buffer_m2.Clear();
                }
            }

            if (buffer_medidas_m2.Count > 500)
            {
                lock (locker_medidas)
                {
                    for (int i = 0; i < buffer_medidas_m2.Count; i++)
                        MedidasM2Controller.Create(buffer_medidas_m2[i]);

                    buffer_medidas_m2.Clear();
                }
            }

            Task.WaitAll(tasks.ToArray());
            buffer_m2.Add(modulo);
            buffer_medidas_m2.Add(medida);
        }
    }

    class M4DataHandler : IMessageHandler
    {
        public void Handle(JObject message, Form _)
        {
        }
    }

    class M4CreateHandler : IMessageHandler
    {
        public void Handle(JObject message, Form _)
        {
        }
    }

    class M4DeleteHandler : IMessageHandler
    {
        public void Handle(JObject message, Form _)
        {
        }
    }

    class M4UpdateHandler : IMessageHandler
    {
        public void Handle(JObject message, Form _)
        {
        }
    }

    class M5DataHandler : IMessageHandler
    {
        public void Handle(JObject message, Form _)
        {
        }
    }
}

