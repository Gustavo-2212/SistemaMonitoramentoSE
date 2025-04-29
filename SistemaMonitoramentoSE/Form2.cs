using ScottPlot;
using ScottPlot.WinForms;
using SistemaMonitoramentoSE.Controllers;
using SistemaMonitoramentoSE.Handler;
using SistemaMonitoramentoSE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMonitoramentoSE
{
    public partial class Form2 : Form
    {
        Dictionary<string, string> parametros = new Dictionary<string, string>() {
            {"tensão", "[V]" },
            {"corrente", "[A]" },
            {"angTensão", "[V]" },
            {"potApaVA", "[W]" },
            {"potRealVAr", "[W]" },
            {"potRealW", "[W]" },
            {"fatorP", "-" }
        };

        private string instancia;
        bool auto_scroll = true;
        public Form2(string instancia)
        {
            InitializeComponent();
            this.instancia = instancia;
        }

        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        

        private void Form2_Load(object sender, EventArgs e)
        {
            combx_variavel.SelectedIndex = 0;
            combx_variavel.SelectedIndex = 0;

            lbl_instancia.Text = $"INSTÂNCIA {instancia} - MÓDULO 1";

            timer1.Interval = 100;
            timer1.Start();
        }


        // ======================== TIMERS ========================
        private void auto_scroll_timer_Tick(object sender, EventArgs e)
        {
            auto_scroll = true;
            auto_scroll_timer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            update_chart();
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

        private void update_chart()
        {
            var plot = instancia_m1;
            int id = int.Parse(instancia);

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
            double[] yData = medidas_filtradas.Select(m => {
                (var x, _) = get_param_value(parametro, m);
                return x;
            }).ToArray();

            if (plot.InvokeRequired)
                plot.Invoke(() => update_chart(plot, xData, yData, cor, parametro, id));
            else
                update_chart(plot, xData, yData, cor, parametro, id);
        }

        private void update_chart(FormsPlot plot, double[] xData, double[] yData, ScottPlot.Color cor, string parametro, int id)
        {
            plot.MouseDown += (s, e) => { auto_scroll = false; auto_scroll_timer.Stop(); auto_scroll_timer.Start(); };
            plot.MouseWheel += (s, e) => { auto_scroll = false; auto_scroll_timer.Stop(); auto_scroll_timer.Start(); };
            plot.MouseMove += (s, e) =>
            {
                if (((MouseEventArgs)e).Button != MouseButtons.None) // Usuário apertou e arrastou no gráfico
                {
                    auto_scroll = false;
                    auto_scroll_timer.Stop();
                    auto_scroll_timer.Start();
                }
            };

            plot.Plot.Clear();
            plot.Plot.Add.Scatter(xData, yData, color: cor);
            plot.Plot.XLabel("tempo [s]");
            plot.Plot.YLabel($"{parametro} {parametros[parametro]}");
            if (auto_scroll) plot.Plot.Axes.AutoScale();
            plot.Refresh();
        }
    }
}
