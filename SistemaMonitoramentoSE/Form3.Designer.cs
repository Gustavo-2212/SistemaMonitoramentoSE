namespace SistemaMonitoramentoSE
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            lbl_instancia = new Label();
            label1 = new Label();
            historico = new ScottPlot.WinForms.FormsPlot();
            label2 = new Label();
            label3 = new Label();
            lbl_data_i = new Label();
            lbl_data_f = new Label();
            btn_voltar = new Button();
            combx_variavel = new ComboBox();
            auto_scroll_timer = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbl_instancia
            // 
            lbl_instancia.AutoSize = true;
            lbl_instancia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_instancia.Location = new Point(445, 65);
            lbl_instancia.Name = "lbl_instancia";
            lbl_instancia.Size = new Size(336, 32);
            lbl_instancia.TabIndex = 0;
            lbl_instancia.Text = "INSTÂNCIA #?? - MÓDULO 1";
            lbl_instancia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(569, 117);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 1;
            label1.Text = "HISTÓRICO";
            // 
            // historico
            // 
            historico.DisplayScale = 1F;
            historico.Location = new Point(60, 158);
            historico.Name = "historico";
            historico.Size = new Size(1157, 434);
            historico.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 611);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 3;
            label2.Text = "DATA INICIAL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 643);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 4;
            label3.Text = "DATA FINAL:";
            // 
            // lbl_data_i
            // 
            lbl_data_i.AutoSize = true;
            lbl_data_i.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_i.ForeColor = SystemColors.Highlight;
            lbl_data_i.Location = new Point(222, 611);
            lbl_data_i.Name = "lbl_data_i";
            lbl_data_i.Size = new Size(16, 21);
            lbl_data_i.TabIndex = 5;
            lbl_data_i.Text = "-";
            // 
            // lbl_data_f
            // 
            lbl_data_f.AutoSize = true;
            lbl_data_f.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_f.ForeColor = SystemColors.Highlight;
            lbl_data_f.Location = new Point(222, 643);
            lbl_data_f.Name = "lbl_data_f";
            lbl_data_f.Size = new Size(16, 21);
            lbl_data_f.TabIndex = 6;
            lbl_data_f.Text = "-";
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(1121, 50);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(96, 30);
            btn_voltar.TabIndex = 7;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // combx_variavel
            // 
            combx_variavel.Font = new Font("Segoe UI", 10F);
            combx_variavel.FormattingEnabled = true;
            combx_variavel.Items.AddRange(new object[] { "tensão", "corrente", "angTensão", "potApaVA", "potRealVAr", "potRealW", "fatorP" });
            combx_variavel.Location = new Point(966, 55);
            combx_variavel.Name = "combx_variavel";
            combx_variavel.Size = new Size(121, 25);
            combx_variavel.TabIndex = 8;
            combx_variavel.SelectedIndexChanged += combx_variavel_SelectedIndexChanged;
            // 
            // auto_scroll_timer
            // 
            auto_scroll_timer.Enabled = true;
            auto_scroll_timer.Interval = 5000;
            auto_scroll_timer.Tick += auto_scroll_timer_Tick;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 684);
            Controls.Add(combx_variavel);
            Controls.Add(btn_voltar);
            Controls.Add(lbl_data_f);
            Controls.Add(lbl_data_i);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(historico);
            Controls.Add(label1);
            Controls.Add(lbl_instancia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Histórico";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_instancia;
        private Label label1;
        private ScottPlot.WinForms.FormsPlot historico;
        private Label label2;
        private Label label3;
        private Label lbl_data_i;
        private Label lbl_data_f;
        private Button btn_voltar;
        private ComboBox combx_variavel;
        private System.Windows.Forms.Timer auto_scroll_timer;
        private System.Windows.Forms.Timer timer1;
    }
}