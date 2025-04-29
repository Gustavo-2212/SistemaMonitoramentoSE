namespace SistemaMonitoramentoSE
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            lbl_modulo = new Label();
            btn_voltar = new Button();
            historico = new ListView();
            SuspendLayout();
            // 
            // lbl_modulo
            // 
            lbl_modulo.AutoSize = true;
            lbl_modulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_modulo.Location = new Point(470, 77);
            lbl_modulo.Name = "lbl_modulo";
            lbl_modulo.Size = new Size(294, 32);
            lbl_modulo.TabIndex = 0;
            lbl_modulo.Text = "HISTÓRICO EVENTOS M?";
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(1094, 107);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(91, 31);
            btn_voltar.TabIndex = 1;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // historico
            // 
            historico.Location = new Point(84, 198);
            historico.Name = "historico";
            historico.Size = new Size(1101, 431);
            historico.TabIndex = 2;
            historico.UseCompatibleStateImageBehavior = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 677);
            Controls.Add(historico);
            Controls.Add(btn_voltar);
            Controls.Add(lbl_modulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Histórico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_modulo;
        private Button btn_voltar;
        private ListView historico;
    }
}