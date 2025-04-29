namespace SistemaMonitoramentoSE
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            instancia_m1 = new ScottPlot.WinForms.FormsPlot();
            btn_voltar = new Button();
            lbl_instancia = new Label();
            combx_variavel = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            auto_scroll_timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // instancia_m1
            // 
            instancia_m1.DisplayScale = 1F;
            instancia_m1.Location = new Point(49, 158);
            instancia_m1.Name = "instancia_m1";
            instancia_m1.Size = new Size(1218, 458);
            instancia_m1.TabIndex = 0;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(1169, 45);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(98, 33);
            btn_voltar.TabIndex = 1;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // lbl_instancia
            // 
            lbl_instancia.AutoSize = true;
            lbl_instancia.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_instancia.Location = new Point(518, 85);
            lbl_instancia.Name = "lbl_instancia";
            lbl_instancia.Size = new Size(311, 32);
            lbl_instancia.TabIndex = 2;
            lbl_instancia.Text = "INSTÂNCIA ? - MÓDULO 1";
            // 
            // combx_variavel
            // 
            combx_variavel.Font = new Font("Segoe UI", 10F);
            combx_variavel.FormattingEnabled = true;
            combx_variavel.Items.AddRange(new object[] { "tensão", "corrente", "angTensão", "potApaVA", "potRealVAr", "potRealW", "fatorP" });
            combx_variavel.Location = new Point(1014, 51);
            combx_variavel.Name = "combx_variavel";
            combx_variavel.Size = new Size(121, 25);
            combx_variavel.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // auto_scroll_timer
            // 
            auto_scroll_timer.Enabled = true;
            auto_scroll_timer.Interval = 5000;
            auto_scroll_timer.Tick += auto_scroll_timer_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 710);
            Controls.Add(combx_variavel);
            Controls.Add(lbl_instancia);
            Controls.Add(btn_voltar);
            Controls.Add(instancia_m1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Visualizar M1";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot instancia_m1;
        private Button btn_voltar;
        private Label lbl_instancia;
        private ComboBox combx_variavel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer auto_scroll_timer;
    }
}