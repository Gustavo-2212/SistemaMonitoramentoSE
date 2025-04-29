namespace SistemaMonitoramentoSE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer_graficos = new System.Windows.Forms.Timer(components);
            status_bar = new StatusStrip();
            info_status = new ToolStripStatusLabel();
            status = new ToolStripStatusLabel();
            lbl_instancias = new Label();
            combx_instancias = new ComboBox();
            combx_sel_instancia = new ComboBox();
            lbl_sel_instancia = new Label();
            btn_sel_instancia = new Button();
            lbl_data_i = new Label();
            txt_data_i = new TextBox();
            txt_data_f = new TextBox();
            lbl_data_f = new Label();
            btn_historico = new Button();
            grafico_1 = new ScottPlot.WinForms.FormsPlot();
            grafico_2 = new ScottPlot.WinForms.FormsPlot();
            grafico_3 = new ScottPlot.WinForms.FormsPlot();
            grafico_4 = new ScottPlot.WinForms.FormsPlot();
            btn_grafico_1 = new Button();
            btn_grafico_2 = new Button();
            btn_grafico_3 = new Button();
            btn_grafico_4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_instancia_1 = new Label();
            lbl_param_1 = new Label();
            lbl_freq_1 = new Label();
            lbl_curto_1 = new Label();
            lbl_curto_2 = new Label();
            lbl_freq_2 = new Label();
            lbl_param_2 = new Label();
            lbl_instancia_2 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            lbl_curto_3 = new Label();
            lbl_freq_3 = new Label();
            lbl_param_3 = new Label();
            lbl_instancia_3 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            lbl_curto_4 = new Label();
            lbl_freq_4 = new Label();
            lbl_param_4 = new Label();
            lbl_instancia_4 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            groupBox3 = new GroupBox();
            card_m5_3 = new GroupBox();
            btn_em5 = new Button();
            card_m5_2 = new GroupBox();
            card_m5_1 = new GroupBox();
            groupBox4 = new GroupBox();
            filtros = new ListView();
            inst_modulo = new ColumnHeader();
            param = new ColumnHeader();
            filtro = new ColumnHeader();
            valor = new ColumnHeader();
            cor = new ColumnHeader();
            groupBox2 = new GroupBox();
            card_m4_3 = new GroupBox();
            btn_em4 = new Button();
            card_m4_2 = new GroupBox();
            card_m4_1 = new GroupBox();
            groupBox1 = new GroupBox();
            card_m2_3 = new GroupBox();
            lbl_curto_circuito_3 = new Label();
            label12 = new Label();
            lbl_data_f_3 = new Label();
            label20 = new Label();
            lbl_modulo1_id_3 = new Label();
            label17 = new Label();
            lbl_data_i_3 = new Label();
            label25 = new Label();
            lbl_mac_3 = new Label();
            lbl_modulo2_id_3 = new Label();
            label18 = new Label();
            label19 = new Label();
            card_m2_2 = new GroupBox();
            lbl_curto_circuito_2 = new Label();
            label6 = new Label();
            lbl_data_f_2 = new Label();
            label10 = new Label();
            lbl_modulo1_id_2 = new Label();
            label7 = new Label();
            lbl_data_i_2 = new Label();
            label11 = new Label();
            lbl_mac_2 = new Label();
            lbl_modulo2_id_2 = new Label();
            label8 = new Label();
            label9 = new Label();
            card_m2_1 = new GroupBox();
            lbl_curto_circuito_1 = new Label();
            lbl_data_f_1 = new Label();
            lbl_modulo1_id_1 = new Label();
            lbl_data_i_1 = new Label();
            lbl_mac_1 = new Label();
            lbl_modulo2_id_1 = new Label();
            lbl_2 = new Label();
            lbl_6 = new Label();
            lbl_1 = new Label();
            lbl_5 = new Label();
            lbl_3 = new Label();
            lbl_4 = new Label();
            btn_em2 = new Button();
            combx_variavel = new ComboBox();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            auto_scroll_timer = new System.Windows.Forms.Timer(components);
            timer_eventos = new System.Windows.Forms.Timer(components);
            status_bar.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            card_m2_3.SuspendLayout();
            card_m2_2.SuspendLayout();
            card_m2_1.SuspendLayout();
            SuspendLayout();
            // 
            // timer_graficos
            // 
            timer_graficos.Interval = 1000;
            timer_graficos.Tick += timer1_Tick;
            // 
            // status_bar
            // 
            status_bar.Items.AddRange(new ToolStripItem[] { info_status, status });
            status_bar.Location = new Point(0, 936);
            status_bar.Name = "status_bar";
            status_bar.Size = new Size(1627, 22);
            status_bar.TabIndex = 0;
            status_bar.Text = "statusStrip1";
            // 
            // info_status
            // 
            info_status.Name = "info_status";
            info_status.Size = new Size(0, 17);
            // 
            // status
            // 
            status.Name = "status";
            status.Size = new Size(65, 17);
            status.Text = " M3System";
            // 
            // lbl_instancias
            // 
            lbl_instancias.AutoSize = true;
            lbl_instancias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_instancias.Location = new Point(32, 24);
            lbl_instancias.Name = "lbl_instancias";
            lbl_instancias.Size = new Size(76, 15);
            lbl_instancias.TabIndex = 1;
            lbl_instancias.Text = "INSTÂNCIAS\r\n";
            // 
            // combx_instancias
            // 
            combx_instancias.FormattingEnabled = true;
            combx_instancias.Items.AddRange(new object[] { "-" });
            combx_instancias.Location = new Point(32, 52);
            combx_instancias.Name = "combx_instancias";
            combx_instancias.Size = new Size(152, 23);
            combx_instancias.TabIndex = 2;
            // 
            // combx_sel_instancia
            // 
            combx_sel_instancia.FormattingEnabled = true;
            combx_sel_instancia.Items.AddRange(new object[] { "-" });
            combx_sel_instancia.Location = new Point(209, 52);
            combx_sel_instancia.Name = "combx_sel_instancia";
            combx_sel_instancia.Size = new Size(152, 23);
            combx_sel_instancia.TabIndex = 4;
            // 
            // lbl_sel_instancia
            // 
            lbl_sel_instancia.AutoSize = true;
            lbl_sel_instancia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sel_instancia.Location = new Point(209, 24);
            lbl_sel_instancia.Name = "lbl_sel_instancia";
            lbl_sel_instancia.Size = new Size(142, 15);
            lbl_sel_instancia.TabIndex = 3;
            lbl_sel_instancia.Text = "SELECIONAR INSTÂNCIA";
            // 
            // btn_sel_instancia
            // 
            btn_sel_instancia.Location = new Point(209, 81);
            btn_sel_instancia.Name = "btn_sel_instancia";
            btn_sel_instancia.Size = new Size(83, 29);
            btn_sel_instancia.TabIndex = 5;
            btn_sel_instancia.Text = "Selecionar";
            btn_sel_instancia.UseVisualStyleBackColor = true;
            btn_sel_instancia.Click += btn_sel_instancia_Click;
            // 
            // lbl_data_i
            // 
            lbl_data_i.AutoSize = true;
            lbl_data_i.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_i.Location = new Point(414, 24);
            lbl_data_i.Name = "lbl_data_i";
            lbl_data_i.Size = new Size(82, 15);
            lbl_data_i.TabIndex = 6;
            lbl_data_i.Text = "DATA INICIAL";
            // 
            // txt_data_i
            // 
            txt_data_i.Location = new Point(414, 52);
            txt_data_i.Name = "txt_data_i";
            txt_data_i.Size = new Size(142, 23);
            txt_data_i.TabIndex = 7;
            // 
            // txt_data_f
            // 
            txt_data_f.Location = new Point(414, 122);
            txt_data_f.Name = "txt_data_f";
            txt_data_f.Size = new Size(142, 23);
            txt_data_f.TabIndex = 9;
            // 
            // lbl_data_f
            // 
            lbl_data_f.AutoSize = true;
            lbl_data_f.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_f.Location = new Point(414, 94);
            lbl_data_f.Name = "lbl_data_f";
            lbl_data_f.Size = new Size(73, 15);
            lbl_data_f.TabIndex = 8;
            lbl_data_f.Text = "DATA FINAL";
            // 
            // btn_historico
            // 
            btn_historico.Location = new Point(578, 52);
            btn_historico.Name = "btn_historico";
            btn_historico.Size = new Size(83, 29);
            btn_historico.TabIndex = 10;
            btn_historico.Text = "Histórico";
            btn_historico.UseVisualStyleBackColor = true;
            btn_historico.Click += btn_historico_Click;
            // 
            // grafico_1
            // 
            grafico_1.DisplayScale = 1F;
            grafico_1.Location = new Point(32, 169);
            grafico_1.Name = "grafico_1";
            grafico_1.Size = new Size(484, 179);
            grafico_1.TabIndex = 11;
            // 
            // grafico_2
            // 
            grafico_2.DisplayScale = 1F;
            grafico_2.Location = new Point(32, 354);
            grafico_2.Name = "grafico_2";
            grafico_2.Size = new Size(484, 179);
            grafico_2.TabIndex = 12;
            // 
            // grafico_3
            // 
            grafico_3.DisplayScale = 1F;
            grafico_3.Location = new Point(32, 539);
            grafico_3.Name = "grafico_3";
            grafico_3.Size = new Size(484, 179);
            grafico_3.TabIndex = 13;
            // 
            // grafico_4
            // 
            grafico_4.DisplayScale = 1F;
            grafico_4.Location = new Point(32, 737);
            grafico_4.Name = "grafico_4";
            grafico_4.Size = new Size(484, 179);
            grafico_4.TabIndex = 14;
            // 
            // btn_grafico_1
            // 
            btn_grafico_1.Location = new Point(522, 183);
            btn_grafico_1.Name = "btn_grafico_1";
            btn_grafico_1.Size = new Size(83, 29);
            btn_grafico_1.TabIndex = 15;
            btn_grafico_1.Text = "Selecionar";
            btn_grafico_1.UseVisualStyleBackColor = true;
            btn_grafico_1.Click += btn_grafico_1_Click;
            // 
            // btn_grafico_2
            // 
            btn_grafico_2.Location = new Point(522, 370);
            btn_grafico_2.Name = "btn_grafico_2";
            btn_grafico_2.Size = new Size(83, 29);
            btn_grafico_2.TabIndex = 16;
            btn_grafico_2.Text = "Selecionar";
            btn_grafico_2.UseVisualStyleBackColor = true;
            btn_grafico_2.Click += btn_grafico_2_Click;
            // 
            // btn_grafico_3
            // 
            btn_grafico_3.Location = new Point(522, 554);
            btn_grafico_3.Name = "btn_grafico_3";
            btn_grafico_3.Size = new Size(83, 29);
            btn_grafico_3.TabIndex = 17;
            btn_grafico_3.Text = "Selecionar";
            btn_grafico_3.UseVisualStyleBackColor = true;
            btn_grafico_3.Click += btn_grafico_3_Click;
            // 
            // btn_grafico_4
            // 
            btn_grafico_4.Location = new Point(522, 751);
            btn_grafico_4.Name = "btn_grafico_4";
            btn_grafico_4.Size = new Size(83, 29);
            btn_grafico_4.TabIndex = 18;
            btn_grafico_4.Text = "Selecionar";
            btn_grafico_4.UseVisualStyleBackColor = true;
            btn_grafico_4.Click += btn_grafico_4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(522, 229);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 19;
            label1.Text = "INSTÂNCIA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(522, 256);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 20;
            label2.Text = "PARÂMETRO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(524, 283);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 21;
            label3.Text = "FREQUÊNCIA DE ENVIO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(524, 310);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 22;
            label4.Text = "VALOR CURTO:";
            // 
            // lbl_instancia_1
            // 
            lbl_instancia_1.AutoSize = true;
            lbl_instancia_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_instancia_1.ForeColor = SystemColors.MenuHighlight;
            lbl_instancia_1.Location = new Point(671, 229);
            lbl_instancia_1.Name = "lbl_instancia_1";
            lbl_instancia_1.Size = new Size(12, 15);
            lbl_instancia_1.TabIndex = 23;
            lbl_instancia_1.Text = "-";
            // 
            // lbl_param_1
            // 
            lbl_param_1.AutoSize = true;
            lbl_param_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_param_1.ForeColor = SystemColors.MenuHighlight;
            lbl_param_1.Location = new Point(671, 256);
            lbl_param_1.Name = "lbl_param_1";
            lbl_param_1.Size = new Size(12, 15);
            lbl_param_1.TabIndex = 24;
            lbl_param_1.Text = "-";
            // 
            // lbl_freq_1
            // 
            lbl_freq_1.AutoSize = true;
            lbl_freq_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_freq_1.ForeColor = SystemColors.MenuHighlight;
            lbl_freq_1.Location = new Point(671, 283);
            lbl_freq_1.Name = "lbl_freq_1";
            lbl_freq_1.Size = new Size(12, 15);
            lbl_freq_1.TabIndex = 25;
            lbl_freq_1.Text = "-";
            // 
            // lbl_curto_1
            // 
            lbl_curto_1.AutoSize = true;
            lbl_curto_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_curto_1.ForeColor = SystemColors.Highlight;
            lbl_curto_1.Location = new Point(671, 310);
            lbl_curto_1.Name = "lbl_curto_1";
            lbl_curto_1.Size = new Size(12, 15);
            lbl_curto_1.TabIndex = 26;
            lbl_curto_1.Text = "-";
            // 
            // lbl_curto_2
            // 
            lbl_curto_2.AutoSize = true;
            lbl_curto_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_curto_2.ForeColor = SystemColors.Highlight;
            lbl_curto_2.Location = new Point(671, 497);
            lbl_curto_2.Name = "lbl_curto_2";
            lbl_curto_2.Size = new Size(12, 15);
            lbl_curto_2.TabIndex = 34;
            lbl_curto_2.Text = "-";
            // 
            // lbl_freq_2
            // 
            lbl_freq_2.AutoSize = true;
            lbl_freq_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_freq_2.ForeColor = SystemColors.MenuHighlight;
            lbl_freq_2.Location = new Point(671, 470);
            lbl_freq_2.Name = "lbl_freq_2";
            lbl_freq_2.Size = new Size(12, 15);
            lbl_freq_2.TabIndex = 33;
            lbl_freq_2.Text = "-";
            // 
            // lbl_param_2
            // 
            lbl_param_2.AutoSize = true;
            lbl_param_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_param_2.ForeColor = SystemColors.MenuHighlight;
            lbl_param_2.Location = new Point(671, 443);
            lbl_param_2.Name = "lbl_param_2";
            lbl_param_2.Size = new Size(12, 15);
            lbl_param_2.TabIndex = 32;
            lbl_param_2.Text = "-";
            // 
            // lbl_instancia_2
            // 
            lbl_instancia_2.AutoSize = true;
            lbl_instancia_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_instancia_2.ForeColor = SystemColors.MenuHighlight;
            lbl_instancia_2.Location = new Point(671, 416);
            lbl_instancia_2.Name = "lbl_instancia_2";
            lbl_instancia_2.Size = new Size(12, 15);
            lbl_instancia_2.TabIndex = 31;
            lbl_instancia_2.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(524, 497);
            label13.Name = "label13";
            label13.Size = new Size(91, 15);
            label13.TabIndex = 30;
            label13.Text = "VALOR CURTO:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(524, 470);
            label14.Name = "label14";
            label14.Size = new Size(139, 15);
            label14.TabIndex = 29;
            label14.Text = "FREQUÊNCIA DE ENVIO:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(522, 443);
            label15.Name = "label15";
            label15.Size = new Size(81, 15);
            label15.TabIndex = 28;
            label15.Text = "PARÂMETRO:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(522, 416);
            label16.Name = "label16";
            label16.Size = new Size(72, 15);
            label16.TabIndex = 27;
            label16.Text = "INSTÂNCIA:";
            // 
            // lbl_curto_3
            // 
            lbl_curto_3.AutoSize = true;
            lbl_curto_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_curto_3.ForeColor = SystemColors.Highlight;
            lbl_curto_3.Location = new Point(671, 684);
            lbl_curto_3.Name = "lbl_curto_3";
            lbl_curto_3.Size = new Size(12, 15);
            lbl_curto_3.TabIndex = 42;
            lbl_curto_3.Text = "-";
            // 
            // lbl_freq_3
            // 
            lbl_freq_3.AutoSize = true;
            lbl_freq_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_freq_3.ForeColor = SystemColors.MenuHighlight;
            lbl_freq_3.Location = new Point(671, 657);
            lbl_freq_3.Name = "lbl_freq_3";
            lbl_freq_3.Size = new Size(12, 15);
            lbl_freq_3.TabIndex = 41;
            lbl_freq_3.Text = "-";
            // 
            // lbl_param_3
            // 
            lbl_param_3.AutoSize = true;
            lbl_param_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_param_3.ForeColor = SystemColors.MenuHighlight;
            lbl_param_3.Location = new Point(671, 630);
            lbl_param_3.Name = "lbl_param_3";
            lbl_param_3.Size = new Size(12, 15);
            lbl_param_3.TabIndex = 40;
            lbl_param_3.Text = "-";
            // 
            // lbl_instancia_3
            // 
            lbl_instancia_3.AutoSize = true;
            lbl_instancia_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_instancia_3.ForeColor = SystemColors.MenuHighlight;
            lbl_instancia_3.Location = new Point(671, 603);
            lbl_instancia_3.Name = "lbl_instancia_3";
            lbl_instancia_3.Size = new Size(12, 15);
            lbl_instancia_3.TabIndex = 39;
            lbl_instancia_3.Text = "-";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(524, 684);
            label21.Name = "label21";
            label21.Size = new Size(91, 15);
            label21.TabIndex = 38;
            label21.Text = "VALOR CURTO:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(524, 657);
            label22.Name = "label22";
            label22.Size = new Size(139, 15);
            label22.TabIndex = 37;
            label22.Text = "FREQUÊNCIA DE ENVIO:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(522, 630);
            label23.Name = "label23";
            label23.Size = new Size(81, 15);
            label23.TabIndex = 36;
            label23.Text = "PARÂMETRO:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(522, 603);
            label24.Name = "label24";
            label24.Size = new Size(72, 15);
            label24.TabIndex = 35;
            label24.Text = "INSTÂNCIA:";
            // 
            // lbl_curto_4
            // 
            lbl_curto_4.AutoSize = true;
            lbl_curto_4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_curto_4.ForeColor = SystemColors.Highlight;
            lbl_curto_4.Location = new Point(673, 881);
            lbl_curto_4.Name = "lbl_curto_4";
            lbl_curto_4.Size = new Size(12, 15);
            lbl_curto_4.TabIndex = 50;
            lbl_curto_4.Text = "-";
            // 
            // lbl_freq_4
            // 
            lbl_freq_4.AutoSize = true;
            lbl_freq_4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_freq_4.ForeColor = SystemColors.MenuHighlight;
            lbl_freq_4.Location = new Point(673, 854);
            lbl_freq_4.Name = "lbl_freq_4";
            lbl_freq_4.Size = new Size(12, 15);
            lbl_freq_4.TabIndex = 49;
            lbl_freq_4.Text = "-";
            // 
            // lbl_param_4
            // 
            lbl_param_4.AutoSize = true;
            lbl_param_4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_param_4.ForeColor = SystemColors.MenuHighlight;
            lbl_param_4.Location = new Point(673, 827);
            lbl_param_4.Name = "lbl_param_4";
            lbl_param_4.Size = new Size(12, 15);
            lbl_param_4.TabIndex = 48;
            lbl_param_4.Text = "-";
            // 
            // lbl_instancia_4
            // 
            lbl_instancia_4.AutoSize = true;
            lbl_instancia_4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_instancia_4.ForeColor = SystemColors.MenuHighlight;
            lbl_instancia_4.Location = new Point(673, 800);
            lbl_instancia_4.Name = "lbl_instancia_4";
            lbl_instancia_4.Size = new Size(12, 15);
            lbl_instancia_4.TabIndex = 47;
            lbl_instancia_4.Text = "-";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(526, 881);
            label29.Name = "label29";
            label29.Size = new Size(91, 15);
            label29.TabIndex = 46;
            label29.Text = "VALOR CURTO:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(526, 854);
            label30.Name = "label30";
            label30.Size = new Size(139, 15);
            label30.TabIndex = 45;
            label30.Text = "FREQUÊNCIA DE ENVIO:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(524, 827);
            label31.Name = "label31";
            label31.Size = new Size(81, 15);
            label31.TabIndex = 44;
            label31.Text = "PARÂMETRO:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(524, 800);
            label32.Name = "label32";
            label32.Size = new Size(72, 15);
            label32.TabIndex = 43;
            label32.Text = "INSTÂNCIA:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(card_m5_3);
            groupBox3.Controls.Add(btn_em5);
            groupBox3.Controls.Add(card_m5_2);
            groupBox3.Controls.Add(card_m5_1);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(802, 483);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(813, 195);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "EVENTOS MÓDULO 5";
            // 
            // card_m5_3
            // 
            card_m5_3.Location = new Point(565, 23);
            card_m5_3.Name = "card_m5_3";
            card_m5_3.Size = new Size(237, 166);
            card_m5_3.TabIndex = 60;
            card_m5_3.TabStop = false;
            // 
            // btn_em5
            // 
            btn_em5.Location = new Point(6, 167);
            btn_em5.Name = "btn_em5";
            btn_em5.Size = new Size(69, 22);
            btn_em5.TabIndex = 57;
            btn_em5.Text = "Histórico";
            btn_em5.UseVisualStyleBackColor = true;
            btn_em5.Click += btn_em5_Click;
            // 
            // card_m5_2
            // 
            card_m5_2.Location = new Point(321, 22);
            card_m5_2.Name = "card_m5_2";
            card_m5_2.Size = new Size(237, 166);
            card_m5_2.TabIndex = 59;
            card_m5_2.TabStop = false;
            // 
            // card_m5_1
            // 
            card_m5_1.Location = new Point(78, 23);
            card_m5_1.Name = "card_m5_1";
            card_m5_1.Size = new Size(237, 166);
            card_m5_1.TabIndex = 58;
            card_m5_1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(filtros);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(802, 715);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(813, 218);
            groupBox4.TabIndex = 52;
            groupBox4.TabStop = false;
            groupBox4.Text = "FILTROS";
            // 
            // filtros
            // 
            filtros.Columns.AddRange(new ColumnHeader[] { inst_modulo, param, filtro, valor, cor });
            filtros.Location = new Point(6, 22);
            filtros.Name = "filtros";
            filtros.Size = new Size(800, 190);
            filtros.TabIndex = 0;
            filtros.UseCompatibleStateImageBehavior = false;
            // 
            // inst_modulo
            // 
            inst_modulo.Text = "INSTÂNCIA MÓDULO";
            // 
            // param
            // 
            param.Text = "PARÂMETRO";
            // 
            // filtro
            // 
            filtro.Text = "FILTRO";
            // 
            // valor
            // 
            valor.Text = "VALOR";
            // 
            // cor
            // 
            cor.Text = "COR";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(card_m4_3);
            groupBox2.Controls.Add(btn_em4);
            groupBox2.Controls.Add(card_m4_2);
            groupBox2.Controls.Add(card_m4_1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(802, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(813, 195);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            groupBox2.Text = "EVENTOS MÓDULO 4";
            // 
            // card_m4_3
            // 
            card_m4_3.Location = new Point(565, 23);
            card_m4_3.Name = "card_m4_3";
            card_m4_3.Size = new Size(237, 166);
            card_m4_3.TabIndex = 60;
            card_m4_3.TabStop = false;
            // 
            // btn_em4
            // 
            btn_em4.Location = new Point(6, 167);
            btn_em4.Name = "btn_em4";
            btn_em4.Size = new Size(69, 22);
            btn_em4.TabIndex = 56;
            btn_em4.Text = "Histórico";
            btn_em4.UseVisualStyleBackColor = true;
            btn_em4.Click += btn_em4_Click;
            // 
            // card_m4_2
            // 
            card_m4_2.Location = new Point(321, 23);
            card_m4_2.Name = "card_m4_2";
            card_m4_2.Size = new Size(237, 166);
            card_m4_2.TabIndex = 59;
            card_m4_2.TabStop = false;
            // 
            // card_m4_1
            // 
            card_m4_1.Location = new Point(78, 23);
            card_m4_1.Name = "card_m4_1";
            card_m4_1.Size = new Size(237, 166);
            card_m4_1.TabIndex = 58;
            card_m4_1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(card_m2_3);
            groupBox1.Controls.Add(card_m2_2);
            groupBox1.Controls.Add(card_m2_1);
            groupBox1.Controls.Add(btn_em2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(802, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(813, 195);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "EVENTOS MÓDULO 2";
            // 
            // card_m2_3
            // 
            card_m2_3.Controls.Add(lbl_curto_circuito_3);
            card_m2_3.Controls.Add(label12);
            card_m2_3.Controls.Add(lbl_data_f_3);
            card_m2_3.Controls.Add(label20);
            card_m2_3.Controls.Add(lbl_modulo1_id_3);
            card_m2_3.Controls.Add(label17);
            card_m2_3.Controls.Add(lbl_data_i_3);
            card_m2_3.Controls.Add(label25);
            card_m2_3.Controls.Add(lbl_mac_3);
            card_m2_3.Controls.Add(lbl_modulo2_id_3);
            card_m2_3.Controls.Add(label18);
            card_m2_3.Controls.Add(label19);
            card_m2_3.Location = new Point(565, 22);
            card_m2_3.Name = "card_m2_3";
            card_m2_3.Size = new Size(237, 166);
            card_m2_3.TabIndex = 57;
            card_m2_3.TabStop = false;
            // 
            // lbl_curto_circuito_3
            // 
            lbl_curto_circuito_3.AutoSize = true;
            lbl_curto_circuito_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_curto_circuito_3.ForeColor = SystemColors.MenuHighlight;
            lbl_curto_circuito_3.Location = new Point(100, 129);
            lbl_curto_circuito_3.Name = "lbl_curto_circuito_3";
            lbl_curto_circuito_3.Size = new Size(12, 15);
            lbl_curto_circuito_3.TabIndex = 84;
            lbl_curto_circuito_3.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.InfoText;
            label12.Location = new Point(7, 41);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 79;
            label12.Text = "M1:";
            // 
            // lbl_data_f_3
            // 
            lbl_data_f_3.AutoSize = true;
            lbl_data_f_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_f_3.ForeColor = SystemColors.MenuHighlight;
            lbl_data_f_3.Location = new Point(100, 107);
            lbl_data_f_3.Name = "lbl_data_f_3";
            lbl_data_f_3.Size = new Size(12, 15);
            lbl_data_f_3.TabIndex = 83;
            lbl_data_f_3.Text = "-";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.InfoText;
            label20.Location = new Point(7, 61);
            label20.Name = "label20";
            label20.Size = new Size(93, 15);
            label20.TabIndex = 75;
            label20.Text = "MAC ADDRESS:";
            // 
            // lbl_modulo1_id_3
            // 
            lbl_modulo1_id_3.AutoSize = true;
            lbl_modulo1_id_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_modulo1_id_3.ForeColor = SystemColors.MenuHighlight;
            lbl_modulo1_id_3.Location = new Point(100, 41);
            lbl_modulo1_id_3.Name = "lbl_modulo1_id_3";
            lbl_modulo1_id_3.Size = new Size(12, 15);
            lbl_modulo1_id_3.TabIndex = 82;
            lbl_modulo1_id_3.Text = "-";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.InfoText;
            label17.Location = new Point(7, 129);
            label17.Name = "label17";
            label17.Size = new Size(50, 15);
            label17.TabIndex = 78;
            label17.Text = "CURTO:";
            // 
            // lbl_data_i_3
            // 
            lbl_data_i_3.AutoSize = true;
            lbl_data_i_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_i_3.ForeColor = SystemColors.MenuHighlight;
            lbl_data_i_3.Location = new Point(100, 83);
            lbl_data_i_3.Name = "lbl_data_i_3";
            lbl_data_i_3.Size = new Size(12, 15);
            lbl_data_i_3.TabIndex = 81;
            lbl_data_i_3.Text = "-";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = SystemColors.InfoText;
            label25.Location = new Point(7, 83);
            label25.Name = "label25";
            label25.Size = new Size(47, 15);
            label25.TabIndex = 76;
            label25.Text = "INÍCIO:";
            // 
            // lbl_mac_3
            // 
            lbl_mac_3.AutoSize = true;
            lbl_mac_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mac_3.ForeColor = SystemColors.MenuHighlight;
            lbl_mac_3.Location = new Point(100, 61);
            lbl_mac_3.Name = "lbl_mac_3";
            lbl_mac_3.Size = new Size(12, 15);
            lbl_mac_3.TabIndex = 80;
            lbl_mac_3.Text = "-";
            // 
            // lbl_modulo2_id_3
            // 
            lbl_modulo2_id_3.AutoSize = true;
            lbl_modulo2_id_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_modulo2_id_3.ForeColor = SystemColors.MenuHighlight;
            lbl_modulo2_id_3.Location = new Point(100, 19);
            lbl_modulo2_id_3.Name = "lbl_modulo2_id_3";
            lbl_modulo2_id_3.Size = new Size(12, 15);
            lbl_modulo2_id_3.TabIndex = 79;
            lbl_modulo2_id_3.Text = "-";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.InfoText;
            label18.Location = new Point(7, 19);
            label18.Name = "label18";
            label18.Size = new Size(28, 15);
            label18.TabIndex = 74;
            label18.Text = "M2:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.InfoText;
            label19.Location = new Point(7, 107);
            label19.Name = "label19";
            label19.Size = new Size(31, 15);
            label19.TabIndex = 77;
            label19.Text = "FIM:";
            // 
            // card_m2_2
            // 
            card_m2_2.Controls.Add(lbl_curto_circuito_2);
            card_m2_2.Controls.Add(label6);
            card_m2_2.Controls.Add(lbl_data_f_2);
            card_m2_2.Controls.Add(label10);
            card_m2_2.Controls.Add(lbl_modulo1_id_2);
            card_m2_2.Controls.Add(label7);
            card_m2_2.Controls.Add(lbl_data_i_2);
            card_m2_2.Controls.Add(label11);
            card_m2_2.Controls.Add(lbl_mac_2);
            card_m2_2.Controls.Add(lbl_modulo2_id_2);
            card_m2_2.Controls.Add(label8);
            card_m2_2.Controls.Add(label9);
            card_m2_2.Location = new Point(321, 22);
            card_m2_2.Name = "card_m2_2";
            card_m2_2.Size = new Size(237, 166);
            card_m2_2.TabIndex = 57;
            card_m2_2.TabStop = false;
            // 
            // lbl_curto_circuito_2
            // 
            lbl_curto_circuito_2.AutoSize = true;
            lbl_curto_circuito_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_curto_circuito_2.ForeColor = SystemColors.MenuHighlight;
            lbl_curto_circuito_2.Location = new Point(106, 130);
            lbl_curto_circuito_2.Name = "lbl_curto_circuito_2";
            lbl_curto_circuito_2.Size = new Size(12, 15);
            lbl_curto_circuito_2.TabIndex = 78;
            lbl_curto_circuito_2.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.InfoText;
            label6.Location = new Point(11, 42);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 73;
            label6.Text = "M1:";
            // 
            // lbl_data_f_2
            // 
            lbl_data_f_2.AutoSize = true;
            lbl_data_f_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_f_2.ForeColor = SystemColors.MenuHighlight;
            lbl_data_f_2.Location = new Point(106, 108);
            lbl_data_f_2.Name = "lbl_data_f_2";
            lbl_data_f_2.Size = new Size(12, 15);
            lbl_data_f_2.TabIndex = 77;
            lbl_data_f_2.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.InfoText;
            label10.Location = new Point(11, 62);
            label10.Name = "label10";
            label10.Size = new Size(93, 15);
            label10.TabIndex = 69;
            label10.Text = "MAC ADDRESS:";
            // 
            // lbl_modulo1_id_2
            // 
            lbl_modulo1_id_2.AutoSize = true;
            lbl_modulo1_id_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_modulo1_id_2.ForeColor = SystemColors.MenuHighlight;
            lbl_modulo1_id_2.Location = new Point(106, 42);
            lbl_modulo1_id_2.Name = "lbl_modulo1_id_2";
            lbl_modulo1_id_2.Size = new Size(12, 15);
            lbl_modulo1_id_2.TabIndex = 76;
            lbl_modulo1_id_2.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.InfoText;
            label7.Location = new Point(11, 130);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 72;
            label7.Text = "CURTO:";
            // 
            // lbl_data_i_2
            // 
            lbl_data_i_2.AutoSize = true;
            lbl_data_i_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_i_2.ForeColor = SystemColors.MenuHighlight;
            lbl_data_i_2.Location = new Point(106, 84);
            lbl_data_i_2.Name = "lbl_data_i_2";
            lbl_data_i_2.Size = new Size(12, 15);
            lbl_data_i_2.TabIndex = 75;
            lbl_data_i_2.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.InfoText;
            label11.Location = new Point(11, 84);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 70;
            label11.Text = "INÍCIO:";
            // 
            // lbl_mac_2
            // 
            lbl_mac_2.AutoSize = true;
            lbl_mac_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mac_2.ForeColor = SystemColors.MenuHighlight;
            lbl_mac_2.Location = new Point(106, 62);
            lbl_mac_2.Name = "lbl_mac_2";
            lbl_mac_2.Size = new Size(12, 15);
            lbl_mac_2.TabIndex = 74;
            lbl_mac_2.Text = "-";
            // 
            // lbl_modulo2_id_2
            // 
            lbl_modulo2_id_2.AutoSize = true;
            lbl_modulo2_id_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_modulo2_id_2.ForeColor = SystemColors.MenuHighlight;
            lbl_modulo2_id_2.Location = new Point(106, 20);
            lbl_modulo2_id_2.Name = "lbl_modulo2_id_2";
            lbl_modulo2_id_2.Size = new Size(12, 15);
            lbl_modulo2_id_2.TabIndex = 73;
            lbl_modulo2_id_2.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.InfoText;
            label8.Location = new Point(11, 20);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 68;
            label8.Text = "M2:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.InfoText;
            label9.Location = new Point(11, 108);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 71;
            label9.Text = "FIM:";
            // 
            // card_m2_1
            // 
            card_m2_1.Controls.Add(lbl_curto_circuito_1);
            card_m2_1.Controls.Add(lbl_data_f_1);
            card_m2_1.Controls.Add(lbl_modulo1_id_1);
            card_m2_1.Controls.Add(lbl_data_i_1);
            card_m2_1.Controls.Add(lbl_mac_1);
            card_m2_1.Controls.Add(lbl_modulo2_id_1);
            card_m2_1.Controls.Add(lbl_2);
            card_m2_1.Controls.Add(lbl_6);
            card_m2_1.Controls.Add(lbl_1);
            card_m2_1.Controls.Add(lbl_5);
            card_m2_1.Controls.Add(lbl_3);
            card_m2_1.Controls.Add(lbl_4);
            card_m2_1.Location = new Point(78, 22);
            card_m2_1.Name = "card_m2_1";
            card_m2_1.Size = new Size(237, 166);
            card_m2_1.TabIndex = 56;
            card_m2_1.TabStop = false;
            // 
            // lbl_curto_circuito_1
            // 
            lbl_curto_circuito_1.AutoSize = true;
            lbl_curto_circuito_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_curto_circuito_1.ForeColor = SystemColors.MenuHighlight;
            lbl_curto_circuito_1.Location = new Point(106, 130);
            lbl_curto_circuito_1.Name = "lbl_curto_circuito_1";
            lbl_curto_circuito_1.Size = new Size(12, 15);
            lbl_curto_circuito_1.TabIndex = 72;
            lbl_curto_circuito_1.Text = "-";
            // 
            // lbl_data_f_1
            // 
            lbl_data_f_1.AutoSize = true;
            lbl_data_f_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_f_1.ForeColor = SystemColors.MenuHighlight;
            lbl_data_f_1.Location = new Point(106, 108);
            lbl_data_f_1.Name = "lbl_data_f_1";
            lbl_data_f_1.Size = new Size(12, 15);
            lbl_data_f_1.TabIndex = 71;
            lbl_data_f_1.Text = "-";
            // 
            // lbl_modulo1_id_1
            // 
            lbl_modulo1_id_1.AutoSize = true;
            lbl_modulo1_id_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_modulo1_id_1.ForeColor = SystemColors.MenuHighlight;
            lbl_modulo1_id_1.Location = new Point(106, 42);
            lbl_modulo1_id_1.Name = "lbl_modulo1_id_1";
            lbl_modulo1_id_1.Size = new Size(12, 15);
            lbl_modulo1_id_1.TabIndex = 70;
            lbl_modulo1_id_1.Text = "-";
            // 
            // lbl_data_i_1
            // 
            lbl_data_i_1.AutoSize = true;
            lbl_data_i_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_i_1.ForeColor = SystemColors.MenuHighlight;
            lbl_data_i_1.Location = new Point(106, 84);
            lbl_data_i_1.Name = "lbl_data_i_1";
            lbl_data_i_1.Size = new Size(12, 15);
            lbl_data_i_1.TabIndex = 69;
            lbl_data_i_1.Text = "-";
            // 
            // lbl_mac_1
            // 
            lbl_mac_1.AutoSize = true;
            lbl_mac_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mac_1.ForeColor = SystemColors.MenuHighlight;
            lbl_mac_1.Location = new Point(106, 62);
            lbl_mac_1.Name = "lbl_mac_1";
            lbl_mac_1.Size = new Size(12, 15);
            lbl_mac_1.TabIndex = 68;
            lbl_mac_1.Text = "-";
            // 
            // lbl_modulo2_id_1
            // 
            lbl_modulo2_id_1.AutoSize = true;
            lbl_modulo2_id_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_modulo2_id_1.ForeColor = SystemColors.MenuHighlight;
            lbl_modulo2_id_1.Location = new Point(106, 20);
            lbl_modulo2_id_1.Name = "lbl_modulo2_id_1";
            lbl_modulo2_id_1.Size = new Size(12, 15);
            lbl_modulo2_id_1.TabIndex = 57;
            lbl_modulo2_id_1.Text = "-";
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_2.ForeColor = SystemColors.InfoText;
            lbl_2.Location = new Point(11, 42);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(28, 15);
            lbl_2.TabIndex = 67;
            lbl_2.Text = "M1:";
            // 
            // lbl_6
            // 
            lbl_6.AutoSize = true;
            lbl_6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_6.ForeColor = SystemColors.InfoText;
            lbl_6.Location = new Point(11, 130);
            lbl_6.Name = "lbl_6";
            lbl_6.Size = new Size(50, 15);
            lbl_6.TabIndex = 66;
            lbl_6.Text = "CURTO:";
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_1.ForeColor = SystemColors.InfoText;
            lbl_1.Location = new Point(11, 20);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(28, 15);
            lbl_1.TabIndex = 62;
            lbl_1.Text = "M2:";
            // 
            // lbl_5
            // 
            lbl_5.AutoSize = true;
            lbl_5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_5.ForeColor = SystemColors.InfoText;
            lbl_5.Location = new Point(11, 108);
            lbl_5.Name = "lbl_5";
            lbl_5.Size = new Size(31, 15);
            lbl_5.TabIndex = 65;
            lbl_5.Text = "FIM:";
            // 
            // lbl_3
            // 
            lbl_3.AutoSize = true;
            lbl_3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_3.ForeColor = SystemColors.InfoText;
            lbl_3.Location = new Point(11, 62);
            lbl_3.Name = "lbl_3";
            lbl_3.Size = new Size(93, 15);
            lbl_3.TabIndex = 63;
            lbl_3.Text = "MAC ADDRESS:";
            // 
            // lbl_4
            // 
            lbl_4.AutoSize = true;
            lbl_4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_4.ForeColor = SystemColors.InfoText;
            lbl_4.Location = new Point(11, 84);
            lbl_4.Name = "lbl_4";
            lbl_4.Size = new Size(47, 15);
            lbl_4.TabIndex = 64;
            lbl_4.Text = "INÍCIO:";
            // 
            // btn_em2
            // 
            btn_em2.Location = new Point(6, 167);
            btn_em2.Name = "btn_em2";
            btn_em2.Size = new Size(69, 22);
            btn_em2.TabIndex = 55;
            btn_em2.Text = "Histórico";
            btn_em2.UseVisualStyleBackColor = true;
            btn_em2.Click += btn_em2_Click;
            // 
            // combx_variavel
            // 
            combx_variavel.Font = new Font("Segoe UI", 10F);
            combx_variavel.FormattingEnabled = true;
            combx_variavel.Items.AddRange(new object[] { "tensão", "corrente", "angTensão", "potApaVA", "potRealVAr", "potRealW", "fatorP" });
            combx_variavel.Location = new Point(32, 120);
            combx_variavel.Name = "combx_variavel";
            combx_variavel.Size = new Size(91, 25);
            combx_variavel.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 94);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 56;
            label5.Text = "VARIÁVEL";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // auto_scroll_timer
            // 
            auto_scroll_timer.Enabled = true;
            auto_scroll_timer.Interval = 5000;
            auto_scroll_timer.Tick += auto_scroll_timer_Tick;
            // 
            // timer_eventos
            // 
            timer_eventos.Enabled = true;
            timer_eventos.Interval = 4500;
            timer_eventos.Tick += timer_eventos_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1627, 958);
            Controls.Add(label5);
            Controls.Add(combx_variavel);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(lbl_curto_4);
            Controls.Add(lbl_freq_4);
            Controls.Add(lbl_param_4);
            Controls.Add(lbl_instancia_4);
            Controls.Add(label29);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label32);
            Controls.Add(lbl_curto_3);
            Controls.Add(lbl_freq_3);
            Controls.Add(lbl_param_3);
            Controls.Add(lbl_instancia_3);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(lbl_curto_2);
            Controls.Add(lbl_freq_2);
            Controls.Add(lbl_param_2);
            Controls.Add(lbl_instancia_2);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(lbl_curto_1);
            Controls.Add(lbl_freq_1);
            Controls.Add(lbl_param_1);
            Controls.Add(lbl_instancia_1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_grafico_4);
            Controls.Add(btn_grafico_3);
            Controls.Add(btn_grafico_2);
            Controls.Add(btn_grafico_1);
            Controls.Add(grafico_4);
            Controls.Add(grafico_3);
            Controls.Add(grafico_2);
            Controls.Add(grafico_1);
            Controls.Add(btn_historico);
            Controls.Add(txt_data_f);
            Controls.Add(lbl_data_f);
            Controls.Add(txt_data_i);
            Controls.Add(lbl_data_i);
            Controls.Add(btn_sel_instancia);
            Controls.Add(combx_sel_instancia);
            Controls.Add(lbl_sel_instancia);
            Controls.Add(combx_instancias);
            Controls.Add(lbl_instancias);
            Controls.Add(status_bar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Principal";
            Load += Form1_Load;
            status_bar.ResumeLayout(false);
            status_bar.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            card_m2_3.ResumeLayout(false);
            card_m2_3.PerformLayout();
            card_m2_2.ResumeLayout(false);
            card_m2_2.PerformLayout();
            card_m2_1.ResumeLayout(false);
            card_m2_1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer_graficos;
        private StatusStrip status_bar;
        private Label lbl_instancias;
        private ComboBox combx_instancias;
        private ComboBox combx_sel_instancia;
        private Label lbl_sel_instancia;
        private Button btn_sel_instancia;
        private Label lbl_data_i;
        private TextBox txt_data_i;
        private TextBox txt_data_f;
        private Label lbl_data_f;
        private ToolStripStatusLabel info_status;
        private ToolStripStatusLabel status;
        private Button btn_historico;
        private ScottPlot.WinForms.FormsPlot grafico_1;
        private ScottPlot.WinForms.FormsPlot grafico_2;
        private ScottPlot.WinForms.FormsPlot grafico_3;
        private ScottPlot.WinForms.FormsPlot grafico_4;
        private Button btn_grafico_1;
        private Button btn_grafico_2;
        private Button btn_grafico_3;
        private Button btn_grafico_4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_instancia_1;
        private Label lbl_param_1;
        private Label lbl_freq_1;
        private Label lbl_curto_1;
        private Label lbl_curto_2;
        private Label lbl_freq_2;
        private Label lbl_param_2;
        private Label lbl_instancia_2;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label lbl_curto_3;
        private Label lbl_freq_3;
        private Label lbl_param_3;
        private Label lbl_instancia_3;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label lbl_curto_4;
        private Label lbl_freq_4;
        private Label lbl_param_4;
        private Label lbl_instancia_4;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private GroupBox groupBox3;
        private Button btn_em5;
        private GroupBox groupBox4;
        private ListView filtros;
        private GroupBox groupBox2;
        private Button btn_em4;
        private GroupBox groupBox1;
        private Button btn_em2;
        private ColumnHeader inst_modulo;
        private ColumnHeader param;
        private ColumnHeader filtro;
        private ColumnHeader valor;
        private ColumnHeader cor;
        private GroupBox card_m2_2;
        private GroupBox card_m2_1;
        private GroupBox card_m2_3;
        private GroupBox card_m5_3;
        private GroupBox card_m5_2;
        private GroupBox card_m5_1;
        private GroupBox card_m4_3;
        private GroupBox card_m4_2;
        private GroupBox card_m4_1;
        private ComboBox combx_variavel;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer auto_scroll_timer;
        private Label lbl_6;
        private Label lbl_1;
        private Label lbl_5;
        private Label lbl_3;
        private Label lbl_4;
        private Label lbl_2;
        private Label lbl_curto_circuito_3;
        private Label label12;
        private Label lbl_data_f_3;
        private Label label20;
        private Label lbl_modulo1_id_3;
        private Label label17;
        private Label lbl_data_i_3;
        private Label label25;
        private Label lbl_mac_3;
        private Label lbl_modulo2_id_3;
        private Label label18;
        private Label label19;
        private Label lbl_curto_circuito_2;
        private Label label6;
        private Label lbl_data_f_2;
        private Label label10;
        private Label lbl_modulo1_id_2;
        private Label label7;
        private Label lbl_data_i_2;
        private Label label11;
        private Label lbl_mac_2;
        private Label lbl_modulo2_id_2;
        private Label label8;
        private Label label9;
        private Label lbl_curto_circuito_1;
        private Label lbl_data_f_1;
        private Label lbl_modulo1_id_1;
        private Label lbl_data_i_1;
        private Label lbl_mac_1;
        private Label lbl_modulo2_id_1;
        private System.Windows.Forms.Timer timer_eventos;
    }
}
