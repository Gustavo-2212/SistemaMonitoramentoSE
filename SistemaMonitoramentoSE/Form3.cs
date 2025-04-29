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
    public partial class Form3 : Form
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
        public string data_inicial;
        public string data_final;
        public bool auto_scroll = true;

        public Form3(string instancia, string data_inicial, string data_final)
        {
            InitializeComponent();
            this.instancia = instancia;
            this.data_inicial = data_inicial;
            this.data_final = data_final;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            combx_variavel.SelectedIndex = 0;

            lbl_instancia.Text = $"INSTÂNCIA #{instancia} - MÓDULO 1";
            lbl_data_i.Text = data_inicial;
            lbl_data_f.Text = data_final;

            timer1.Interval = 300;
            timer1.Start();

            load_chart();
        }

        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();






        // ============= LÓGICA GRÁFICO ===============
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
        private void load_chart()
        {
            var plot = historico;
            int id = int.Parse(instancia);

            var data_inicial = DateTime.Parse(this.data_inicial);
            var data_final = DateTime.Parse(this.data_final);

            if (data_final <= data_inicial) { MessageBox.Show($"Intervalo de datas inválido: {this.data_inicial} até {this.data_final}"); this.Close(); }

            List<MedidasM1Model> medidas_filtradas = MedidasM1Controller.GetAllByModuleIdAndIntervalData(id, data_inicial, data_final) ?? new List<MedidasM1Model>();
            int quantidade_registros = medidas_filtradas.Count;

            if (quantidade_registros == 0)
            {
                MessageBox.Show("Nenhum registro encontrado!");
                this.Close();
            }

            var parametro = combx_variavel.Text;

            (_, ScottPlot.Color cor) = get_param_value(parametro);

            double[] xData = Enumerable.Range(0, quantidade_registros).Select(i => (double)i).ToArray();
            double[] yData = medidas_filtradas.Select(m =>
            {
                (var x, _) = get_param_value(parametro, m);
                return x;
            }).ToArray();

            render_chart(plot, xData, yData, cor, parametro, id);
        }

        private void render_chart(FormsPlot plot, double[] xData, double[] yData, ScottPlot.Color cor, string parametro, int id)
        {
            plot.Plot.Clear();
            plot.Plot.Add.Scatter(xData, yData, color: cor);
            plot.Plot.XLabel("tempo [s]");
            plot.Plot.YLabel($"{parametro} {parametros[parametro]}");
            if (auto_scroll) plot.Plot.Axes.AutoScale();
            plot.Refresh();
        }






        // =============== TIMER ================
        private void auto_scroll_timer_Tick(object sender, EventArgs e)
        {
            auto_scroll = true;
            auto_scroll_timer.Stop();
            
            historico.Plot.Axes.AutoScale();
            historico.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            historico.MouseDown += (s, e) => { auto_scroll = false; auto_scroll_timer.Stop(); auto_scroll_timer.Start(); };
            historico.MouseWheel += (s, e) => { auto_scroll = false; auto_scroll_timer.Stop(); auto_scroll_timer.Start(); };
            historico.MouseMove += (s, e) =>
            {
                if (((MouseEventArgs)e).Button != MouseButtons.None) // Usuário apertou e arrastou no gráfico
                {
                    auto_scroll = false;
                    auto_scroll_timer.Stop();
                    auto_scroll_timer.Start();
                }
            };
        }






        // ============ COMBO BOX EVENTO ==============
        private void combx_variavel_SelectedIndexChanged(object sender, EventArgs e) => load_chart();

    }
}
