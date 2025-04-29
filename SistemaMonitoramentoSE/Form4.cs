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
    public partial class Form4 : Form
    {
        public Form4(string modulo, ColumnHeader[] headers)
        {
            InitializeComponent();

            lbl_modulo.Text = $"HISTÓRICO EVENTOS M{modulo}";
            historico.Columns.AddRange(headers);
            historico.View = View.Details;
            historico.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
