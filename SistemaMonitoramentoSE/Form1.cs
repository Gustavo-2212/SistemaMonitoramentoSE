using Google.Protobuf.WellKnownTypes;
using ScottPlot;
using ScottPlot.Plottables;
using ScottPlot.WinForms;
using SistemaMonitoramentoSE.Controllers;
using SistemaMonitoramentoSE.Handler;
using SistemaMonitoramentoSE.Models;
using System.Text.RegularExpressions;

namespace SistemaMonitoramentoSE
{
    public record CardM2(int module_id, int module1_id, string mac_address, bool short_circuit, DateTime data_init, DateTime data_end);
    public record CardM4();
    public record CardM5();

    public partial class Form1 : Form
    {
        int instancia_inicial;
        bool[] autoScrolls = [true, true, true, true];
        private SwitchConnection connection_switch { get; set; }
        Dictionary<string, string> parametros = new Dictionary<string, string>() {
            {"tensão", "[V]" },
            {"corrente", "[A]" },
            {"angTensão", "[V]" },
            {"potApaVA", "[W]" },
            {"potRealVAr", "[W]" },
            {"potRealW", "[W]" },
            {"fatorP", "-" }
        };

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            connection_switch = new SwitchConnection(12345, this);
            connection_switch.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combx_instancias.SelectedIndex = 0;
            combx_sel_instancia.SelectedIndex = 0;
            combx_variavel.SelectedIndex = 0;

            txt_data_i.Text = DateTime.UtcNow.ToString();
            txt_data_f.Text = (DateTime.UtcNow.AddDays(10)).ToString();

            int quantidade_instancias = Modulo1Controller.GetAll().Count;
            if (quantidade_instancias > 0)
            {
                for (int i = 1; i <= quantidade_instancias; i += 4)
                    combx_instancias.Items.Add($"M1: #{i} - #{i + 3}");

                for (int i = 1; i <= quantidade_instancias; i++)
                    combx_sel_instancia.Items.Add($"M1: #{i}");
            }

            timer_graficos.Interval = 100;
            timer_graficos.Start();
        }



















        // ================ TIMERS =====================
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (combx_instancias.Text.Length > 1)
            {
                instancia_inicial = int.Parse(Regex.Match(combx_instancias.Text, @"#(\d+)").Groups[1].Value);

                Task.Run(() => update_chart(grafico_1));
                Task.Run(() => update_chart(grafico_2));
                Task.Run(() => update_chart(grafico_3));
                Task.Run(() => update_chart(grafico_4));
            }
        }

        private void auto_scroll_timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < autoScrolls.Length; i++) autoScrolls[i] = true;
            auto_scroll_timer.Stop();
        }

        private void timer_eventos_Tick(object sender, EventArgs e)
        {
            Task.Run(() => eventos_m2());
            Task.Run(() => eventos_m4());
            Task.Run(() => eventos_m5());
        }






















        // ============== LÓGICA CARDS ================
        private void eventos_m2()
        {
            var buffer_m2_tmp = M2DataHandler.get_buffer_m2;
            var buffer_medidas_m2_tmp = M2DataHandler.get_buffer_medidas_m2;

            Stack<Modulo2Model> buffer_m2 = (buffer_m2_tmp != null && buffer_m2_tmp.Count > 0) ? new Stack<Modulo2Model>(buffer_m2_tmp) : new Stack<Modulo2Model>();
            Stack<MedidasM2Model> buffer_medidas_m2 = (buffer_medidas_m2_tmp != null && buffer_medidas_m2_tmp.Count > 0) ? new Stack<MedidasM2Model>(buffer_medidas_m2_tmp) : new Stack<MedidasM2Model>();

            List<Card> cards = new List<Card>();
            var c = 0;
            while (buffer_m2.Count != 0)
            {
                if (c >= 3) break;

                var b = buffer_m2.Pop();
                var b_m = buffer_medidas_m2.Pop();

                cards.Add(new Card(
                    b.module_id,
                    b.module1_id,
                    b.mac_address,
                    b_m.short_circuit,
                    b_m.data_init,
                    b_m.data_end
                ));

                c++;
            }

            draw_cards_m2(cards);
        }
        private void draw_cards_m2(List<CardM2> cards)
        {
            if (cards.Count <= 0) return;
            lbl_modulo2_id_1.Text = cards[0].module_id.ToString();
            lbl_modulo1_id_1.Text = cards[0].module1_id.ToString();
            lbl_mac_1.Text = cards[0].mac_address.ToString();
            lbl_data_i_1.Text = cards[0].data_init.ToString("dd/MM/yyyy HH:mm:ss");
            lbl_data_f_1.Text = cards[0].data_end.ToString("dd/MM/yyyy HH:mm:ss");
            lbl_curto_circuito_1.Text = cards[0].short_circuit ? "CURTO" : "NaN";

            if (cards.Count < 2) return;
            lbl_modulo2_id_2.Text = cards[1].module_id.ToString();
            lbl_modulo1_id_2.Text = cards[1].module1_id.ToString();
            lbl_mac_2.Text = cards[1].mac_address.ToString();
            lbl_data_i_2.Text = cards[1].data_init.ToString("dd/MM/yyyy HH:mm:ss");
            lbl_data_f_2.Text = cards[1].data_end.ToString("dd/MM/yyyy HH:mm:ss");
            lbl_curto_circuito_2.Text = cards[1].short_circuit ? "CURTO" : "NaN";

            if (cards.Count < 3) return;
            lbl_modulo2_id_3.Text = cards[2].module_id.ToString();
            lbl_modulo1_id_3.Text = cards[2].module1_id.ToString();
            lbl_mac_3.Text = cards[2].mac_address.ToString();
            lbl_data_i_3.Text = cards[2].data_init.ToString("dd/MM/yyyy HH:mm:ss");
            lbl_data_f_3.Text = cards[2].data_end.ToString("dd/MM/yyyy HH:mm:ss");
            lbl_curto_circuito_3.Text = cards[2].short_circuit ? "CURTO" : "NaN";
        }

        private void eventos_m4()
        {
        }
        private void draw_cards_m4(List<CardM4> cards)
        {
        }

        private void eventos_m5()
        {
        }
        private void draw_cards_m5(List<CardM5> cards)
        {
        }























        // ============= LÓGICA GRÁFICOS =============
        private (double, ScottPlot.Color) get_param_value(string parametro, MedidasM1Model m = null)
        {
            if (m == null) m = new MedidasM1Model(0, 0, string.Empty, 0, 0, 0, 0, 0, 0, 0, 0, DateTime.Now, null, null);
            switch (parametro)
            {
                case "corrente":
                    return ((double)m.corrente, Colors.Red);

                case "tensão":
                    return ((double)m.tensao, Colors.Blue);

                case "angTensão":
                    return ((double)m.angTensao, Colors.Green);

                case "potApaVA":
                    return ((double)m.potApaVA, Colors.Gray);

                case "potRealVAr":
                    return ((double)m.potRealVAr, Colors.HotPink);

                case "potRealW":
                    return ((double)m.potRealW, Colors.IndianRed);

                case "fatorP":
                    return ((double)m.fatorP, Colors.Brown);

                case "freq":
                    return ((double)m.freq, Colors.Maroon);

                default:
                    return (0d, Colors.Black);
            }
        }
        
        private void update_chart(FormsPlot plot, double[] xData, double[] yData, ScottPlot.Color cor, string parametro, int id, int grafico_inst, List<Modulo1Model> m1_filtrados)
        {
            plot.MouseDown += (s, e) => { autoScrolls[grafico_inst] = false; auto_scroll_timer.Stop(); auto_scroll_timer.Start(); };
            plot.MouseWheel += (s, e) => { autoScrolls[grafico_inst] = false; auto_scroll_timer.Stop(); auto_scroll_timer.Start(); };
            plot.MouseMove += (s, e) =>
                {
                    if (((MouseEventArgs)e).Button != MouseButtons.None) // Usuário apertou e arrastou no gráfico
                    {
                        autoScrolls[grafico_inst] = false;
                        auto_scroll_timer.Stop();
                        auto_scroll_timer.Start();
                    }
                };

            plot.Plot.Clear();
            plot.Plot.Add.Scatter(xData, yData, color: cor);
            plot.Plot.XLabel("tempo [s]");
            plot.Plot.YLabel($"{parametro} {parametros[parametro]}");
            if (autoScrolls[grafico_inst]) plot.Plot.Axes.AutoScale();
            plot.Refresh();

            switch (grafico_inst)
            {
                case 0:
                    lbl_instancia_1.Text = (id != grafico_inst) ? $"{id}" : $"-";
                    lbl_param_1.Text = $"{parametro} {parametros[parametro]}";
                    lbl_freq_1.Text = (m1_filtrados.Count > 0) ? $"{m1_filtrados[0].send_freq_ms} ms" : "-";
                    lbl_curto_1.Text = "-";
                    break;

                case 1:
                    lbl_instancia_2.Text = (id != grafico_inst) ? $"{id}" : $"-";
                    lbl_param_2.Text = $"{parametro} {parametros[parametro]}";
                    lbl_freq_2.Text = (m1_filtrados.Count > 0) ? $"{m1_filtrados[0].send_freq_ms} ms" : "-";
                    lbl_curto_2.Text = "-";
                    break;

                case 2:
                    lbl_instancia_3.Text = (id != grafico_inst) ? $"{id}" : $"-";
                    lbl_param_3.Text = $"{parametro} {parametros[parametro]}";
                    lbl_freq_3.Text = (m1_filtrados.Count > 0) ? $"{m1_filtrados[0].send_freq_ms} ms" : "-";
                    lbl_curto_3.Text = "-";
                    break;

                case 3:
                    lbl_instancia_4.Text = (id != grafico_inst) ? $"{id}" : $"-";
                    lbl_param_4.Text = $"{parametro} {parametros[parametro]}";
                    lbl_freq_4.Text = (m1_filtrados.Count > 0) ? $"{m1_filtrados[0].send_freq_ms} ms" : "-";
                    lbl_curto_4.Text = "-";
                    break;

                default:
                    break;
            }
        }

        private void update_chart(FormsPlot plot)
        {
            int grafico_inst = Convert.ToInt32(plot.Name[^1..]) - 1; // [0,3]
            int id = instancia_inicial + grafico_inst;

            List<MedidasM1Model> medidas_db = MedidasM1Controller.GetAllByModuleId(id) ?? new List<MedidasM1Model>();
            int quantidade_registros = medidas_db.Count;

            var buffer_m1_tmp = M1Data1Handler.get_buffer_m1;
            var buffer_medidas_tmp = M1Data1Handler.get_buffer_medidas;

            List<Modulo1Model> buffer_m1 = (buffer_m1_tmp != null && buffer_m1_tmp.Count > 0) ? [.. buffer_m1_tmp] : new List<Modulo1Model>();
            List<MedidasM1Model> buffer_medidas = (buffer_medidas_tmp != null && buffer_medidas_tmp.Count > 0) ? [.. buffer_medidas_tmp] : new List<MedidasM1Model>();

            var m1_filtrados = buffer_m1.Where(m => m.module_id == id).ToList();
            var medidas_filtradas = medidas_db.Concat(buffer_medidas.Where(m => m.module_id == id).ToList());

            int window = 1000;
            var parametro = combx_variavel.Text;

            (_, ScottPlot.Color cor) = get_param_value(parametro);

            double[] xData = Enumerable.Range(quantidade_registros, window).Select(i => (double)i).ToArray();
            double[] yData = medidas_filtradas.Select(m =>
            {
                (var x, _) = get_param_value(parametro, m);
                return x;
            })
                                        .ToArray();

            if (plot.InvokeRequired)
                plot.Invoke(() => update_chart(plot, xData, yData, cor, parametro, id, grafico_inst, m1_filtrados));
            else
                update_chart(plot, xData, yData, cor, parametro, id, grafico_inst, m1_filtrados);

        }





















        // ============= DESENHA LINHA DE SEPARAÇÃO ===================
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen line = new Pen(color: System.Drawing.Color.Black, 2);
            e.Graphics.DrawLine(line, 790, 0, 790, 997);
            line.Dispose();
        }






















        // ============ CLICK BOTÕES ================
        private void btn_sel_instancia_Click(object sender, EventArgs e)
        {
            if (combx_sel_instancia.Text == "-")
            {
                MessageBox.Show("Selecione uma instância válida!");
                return;
            }

            this.btn_grafico_Click(combx_sel_instancia.Text[5..]);
        }

        private void btn_grafico_1_Click(object sender, EventArgs e)
        {
            string instancia = (instancia_inicial <= 9) ? $"0{instancia_inicial}" : $"{instancia_inicial}";

            this.btn_grafico_Click(instancia);
        }

        private void btn_grafico_2_Click(object sender, EventArgs e)
        {
            string instancia = ((instancia_inicial + 1) <= 9) ? $"0{instancia_inicial + 1}" : $"{instancia_inicial + 1}";

            this.btn_grafico_Click(instancia);
        }

        private void btn_grafico_3_Click(object sender, EventArgs e)
        {
            string instancia = ((instancia_inicial + 2) <= 9) ? $"0{instancia_inicial + 2}" : $"{instancia_inicial + 2}";

            this.btn_grafico_Click(instancia);
        }

        private void btn_grafico_4_Click(object sender, EventArgs e)
        {
            string instancia = ((instancia_inicial + 3) <= 9) ? $"0{instancia_inicial + 3}" : $"{instancia_inicial + 3}";

            this.btn_grafico_Click(instancia);
        }

        private void btn_grafico_Click(string instancia)
        {
            if (combx_instancias.Text == "-")
            {
                MessageBox.Show("Selecione instâncias válidas!");
                return;
            }

            Form2 form2 = new Form2(instancia);
            form2.ShowDialog();
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            var data_i_match = Regex.Match(txt_data_i.Text, @"\d{2}/\d{2}/\d{4}( \d{2}:\d{2}:\d{2})?").Success;
            var data_f_match = Regex.Match(txt_data_f.Text, @"\d{2}/\d{2}/\d{4}( \d{2}:\d{2}:\d{2})?").Success;

            if (combx_sel_instancia.Text == "-")
            {
                MessageBox.Show("Selecione um instância válida!");
                return;
            }

            if (!data_i_match || !data_f_match)
            {
                MessageBox.Show($"Datas inválidas: [{txt_data_i.Text}] ou [{txt_data_f.Text}]");
                return;
            }

            Form3 form3 = new Form3(combx_sel_instancia.Text[5..], txt_data_i.Text, txt_data_f.Text);

            form3.ShowDialog();
        }

        private void btn_em2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4("2", new ColumnHeader[]{
                new ColumnHeader { Text = "INSTÂNCIA" },
                new ColumnHeader { Text = "M1 MONITORADA" },
                new ColumnHeader { Text = "CURTO" },
                new ColumnHeader { Text = "INÍCIO" },
                new ColumnHeader { Text = "FIM" }
            });
            form4.ShowDialog();
        }

        private void btn_em4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4("4", new ColumnHeader[]{
                new ColumnHeader { Text = "INSTÂNCIA" },
                new ColumnHeader { Text = "M1 FILTRO" },
                new ColumnHeader { Text = "PARÂMETRO" },
                new ColumnHeader { Text = "FILTRO" },
                new ColumnHeader { Text = "VALOR" },
                new ColumnHeader { Text = "INÍCIO" },
                new ColumnHeader { Text = "FIM" }
            });
            form4.ShowDialog();
        }

        private void btn_em5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4("5", new ColumnHeader[]{
                new ColumnHeader { Text = "INSTÂNCIA" },
                new ColumnHeader { Text = "PACOTES" },
                new ColumnHeader { Text = "LATITUDE" },
                new ColumnHeader { Text = "LONGITUDE" },
                new ColumnHeader { Text = "INÍCIO" },
                new ColumnHeader { Text = "FIM" }
            });
            form4.ShowDialog();
        }
    }
}
