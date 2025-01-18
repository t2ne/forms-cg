namespace desenhaFaces_v1
{
    partial class Form1
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
            this.tb_transx = new System.Windows.Forms.TrackBar();
            this.tb_transy = new System.Windows.Forms.TrackBar();
            this.tb_transz = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_desenho = new System.Windows.Forms.PictureBox();
            this.CorStroke_pb = new System.Windows.Forms.PictureBox();
            this.CorStroke_btn = new System.Windows.Forms.Button();
            this.CorFill_btn = new System.Windows.Forms.Button();
            this.CorFill_pb = new System.Windows.Forms.PictureBox();
            this.cb_wireframe = new System.Windows.Forms.CheckBox();
            this.Espessura_nud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirOBJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tetraedroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prismaHexagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troncoConeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Roty_tb = new System.Windows.Forms.TrackBar();
            this.Rotx_tb = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Rotz_tb = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.disCamara = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.pb_desenhoParalela = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ResetT_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transz)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorStroke_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorFill_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Espessura_nud)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Roty_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotx_tb)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rotz_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenhoParalela)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_transx
            // 
            this.tb_transx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_transx.BackColor = System.Drawing.Color.White;
            this.tb_transx.Location = new System.Drawing.Point(785, 55);
            this.tb_transx.Margin = new System.Windows.Forms.Padding(2);
            this.tb_transx.Maximum = 50;
            this.tb_transx.Minimum = -50;
            this.tb_transx.Name = "tb_transx";
            this.tb_transx.Size = new System.Drawing.Size(139, 45);
            this.tb_transx.TabIndex = 1;
            this.tb_transx.ValueChanged += new System.EventHandler(this.tb_transx_ValueChanged);
            // 
            // tb_transy
            // 
            this.tb_transy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_transy.BackColor = System.Drawing.Color.White;
            this.tb_transy.Location = new System.Drawing.Point(785, 101);
            this.tb_transy.Margin = new System.Windows.Forms.Padding(2);
            this.tb_transy.Maximum = 50;
            this.tb_transy.Minimum = -50;
            this.tb_transy.Name = "tb_transy";
            this.tb_transy.Size = new System.Drawing.Size(139, 45);
            this.tb_transy.TabIndex = 3;
            this.tb_transy.ValueChanged += new System.EventHandler(this.tb_transy_ValueChanged);
            // 
            // tb_transz
            // 
            this.tb_transz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_transz.Location = new System.Drawing.Point(38, 112);
            this.tb_transz.Margin = new System.Windows.Forms.Padding(2);
            this.tb_transz.Maximum = 50;
            this.tb_transz.Minimum = -50;
            this.tb_transz.Name = "tb_transz";
            this.tb_transz.Size = new System.Drawing.Size(139, 45);
            this.tb_transz.TabIndex = 4;
            this.tb_transz.ValueChanged += new System.EventHandler(this.tb_transz_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tb_transz);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(747, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // pb_desenho
            // 
            this.pb_desenho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_desenho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_desenho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_desenho.Location = new System.Drawing.Point(24, 34);
            this.pb_desenho.Margin = new System.Windows.Forms.Padding(2);
            this.pb_desenho.Name = "pb_desenho";
            this.pb_desenho.Size = new System.Drawing.Size(294, 533);
            this.pb_desenho.TabIndex = 0;
            this.pb_desenho.TabStop = false;
            this.pb_desenho.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_desenho_Paint);
            // 
            // CorStroke_pb
            // 
            this.CorStroke_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorStroke_pb.BackColor = System.Drawing.Color.Blue;
            this.CorStroke_pb.Location = new System.Drawing.Point(887, 444);
            this.CorStroke_pb.Name = "CorStroke_pb";
            this.CorStroke_pb.Size = new System.Drawing.Size(47, 44);
            this.CorStroke_pb.TabIndex = 6;
            this.CorStroke_pb.TabStop = false;
            // 
            // CorStroke_btn
            // 
            this.CorStroke_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorStroke_btn.BackColor = System.Drawing.Color.White;
            this.CorStroke_btn.Location = new System.Drawing.Point(747, 444);
            this.CorStroke_btn.Name = "CorStroke_btn";
            this.CorStroke_btn.Size = new System.Drawing.Size(124, 44);
            this.CorStroke_btn.TabIndex = 7;
            this.CorStroke_btn.Text = "Cor Contorno";
            this.CorStroke_btn.UseVisualStyleBackColor = false;
            this.CorStroke_btn.Click += new System.EventHandler(this.CorStroke_btn_Click);
            // 
            // CorFill_btn
            // 
            this.CorFill_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorFill_btn.BackColor = System.Drawing.Color.White;
            this.CorFill_btn.Location = new System.Drawing.Point(747, 500);
            this.CorFill_btn.Name = "CorFill_btn";
            this.CorFill_btn.Size = new System.Drawing.Size(124, 44);
            this.CorFill_btn.TabIndex = 9;
            this.CorFill_btn.Text = "Cor Preenchimento";
            this.CorFill_btn.UseVisualStyleBackColor = false;
            this.CorFill_btn.Click += new System.EventHandler(this.CorFill_btn_Click);
            // 
            // CorFill_pb
            // 
            this.CorFill_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorFill_pb.BackColor = System.Drawing.Color.OrangeRed;
            this.CorFill_pb.Location = new System.Drawing.Point(887, 500);
            this.CorFill_pb.Name = "CorFill_pb";
            this.CorFill_pb.Size = new System.Drawing.Size(47, 44);
            this.CorFill_pb.TabIndex = 8;
            this.CorFill_pb.TabStop = false;
            // 
            // cb_wireframe
            // 
            this.cb_wireframe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_wireframe.AutoSize = true;
            this.cb_wireframe.BackColor = System.Drawing.Color.White;
            this.cb_wireframe.Location = new System.Drawing.Point(15, 57);
            this.cb_wireframe.Name = "cb_wireframe";
            this.cb_wireframe.Size = new System.Drawing.Size(74, 17);
            this.cb_wireframe.TabIndex = 10;
            this.cb_wireframe.Text = "Wireframe";
            this.cb_wireframe.UseVisualStyleBackColor = false;
            this.cb_wireframe.CheckedChanged += new System.EventHandler(this.cb_wireframe_CheckedChanged);
            // 
            // Espessura_nud
            // 
            this.Espessura_nud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Espessura_nud.Location = new System.Drawing.Point(72, 80);
            this.Espessura_nud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Espessura_nud.Name = "Espessura_nud";
            this.Espessura_nud.Size = new System.Drawing.Size(49, 20);
            this.Espessura_nud.TabIndex = 11;
            this.Espessura_nud.ValueChanged += new System.EventHandler(this.Espessura_nud_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Espessura";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.formasToolStripMenuItem,
            this.desenvolvedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.abrirOBJToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir TXT";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reiniciar";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // abrirOBJToolStripMenuItem
            // 
            this.abrirOBJToolStripMenuItem.Name = "abrirOBJToolStripMenuItem";
            this.abrirOBJToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirOBJToolStripMenuItem.Text = "Abrir OBJ";
            this.abrirOBJToolStripMenuItem.Click += new System.EventHandler(this.abrirOBJToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.sobreToolStripMenuItem.Text = "Informações do Modelo";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // formasToolStripMenuItem
            // 
            this.formasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuboToolStripMenuItem,
            this.tetraedroToolStripMenuItem,
            this.prismaHexagonalToolStripMenuItem,
            this.troncoConeToolStripMenuItem});
            this.formasToolStripMenuItem.Name = "formasToolStripMenuItem";
            this.formasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.formasToolStripMenuItem.Text = "Formas";
            // 
            // cuboToolStripMenuItem
            // 
            this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
            this.cuboToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cuboToolStripMenuItem.Text = "Cubo";
            this.cuboToolStripMenuItem.Click += new System.EventHandler(this.cuboToolStripMenuItem_Click);
            // 
            // tetraedroToolStripMenuItem
            // 
            this.tetraedroToolStripMenuItem.Name = "tetraedroToolStripMenuItem";
            this.tetraedroToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tetraedroToolStripMenuItem.Text = "Tetraedro";
            this.tetraedroToolStripMenuItem.Click += new System.EventHandler(this.tetraedroToolStripMenuItem_Click);
            // 
            // prismaHexagonalToolStripMenuItem
            // 
            this.prismaHexagonalToolStripMenuItem.Name = "prismaHexagonalToolStripMenuItem";
            this.prismaHexagonalToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.prismaHexagonalToolStripMenuItem.Text = "PrismaHexagonal";
            this.prismaHexagonalToolStripMenuItem.Click += new System.EventHandler(this.prismaHexagonalToolStripMenuItem_Click);
            // 
            // troncoConeToolStripMenuItem
            // 
            this.troncoConeToolStripMenuItem.Name = "troncoConeToolStripMenuItem";
            this.troncoConeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.troncoConeToolStripMenuItem.Text = "TroncoCone";
            this.troncoConeToolStripMenuItem.Click += new System.EventHandler(this.troncoConeToolStripMenuItem_Click);
            // 
            // desenvolvedoresToolStripMenuItem
            // 
            this.desenvolvedoresToolStripMenuItem.Name = "desenvolvedoresToolStripMenuItem";
            this.desenvolvedoresToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.desenvolvedoresToolStripMenuItem.Text = "Desenvolvedores";
            this.desenvolvedoresToolStripMenuItem.Click += new System.EventHandler(this.desenvolvedoresToolStripMenuItem_Click);
            // 
            // Roty_tb
            // 
            this.Roty_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Roty_tb.BackColor = System.Drawing.Color.White;
            this.Roty_tb.Location = new System.Drawing.Point(783, 283);
            this.Roty_tb.Margin = new System.Windows.Forms.Padding(2);
            this.Roty_tb.Maximum = 180;
            this.Roty_tb.Minimum = -180;
            this.Roty_tb.Name = "Roty_tb";
            this.Roty_tb.Size = new System.Drawing.Size(139, 45);
            this.Roty_tb.TabIndex = 15;
            this.Roty_tb.ValueChanged += new System.EventHandler(this.Roty_tb_ValueChanged);
            // 
            // Rotx_tb
            // 
            this.Rotx_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rotx_tb.BackColor = System.Drawing.Color.White;
            this.Rotx_tb.Location = new System.Drawing.Point(783, 235);
            this.Rotx_tb.Margin = new System.Windows.Forms.Padding(2);
            this.Rotx_tb.Maximum = 180;
            this.Rotx_tb.Minimum = -180;
            this.Rotx_tb.Name = "Rotx_tb";
            this.Rotx_tb.Size = new System.Drawing.Size(139, 45);
            this.Rotx_tb.TabIndex = 14;
            this.Rotx_tb.ValueChanged += new System.EventHandler(this.Rotx_tb_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Rotz_tb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(747, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 162);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "X";
            // 
            // Rotz_tb
            // 
            this.Rotz_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rotz_tb.Location = new System.Drawing.Point(38, 110);
            this.Rotz_tb.Margin = new System.Windows.Forms.Padding(2);
            this.Rotz_tb.Maximum = 180;
            this.Rotz_tb.Minimum = -180;
            this.Rotz_tb.Name = "Rotz_tb";
            this.Rotz_tb.Size = new System.Drawing.Size(139, 45);
            this.Rotz_tb.TabIndex = 4;
            this.Rotz_tb.ValueChanged += new System.EventHandler(this.Rotz_tb_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Raio";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(81, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(603, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 165);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tronco de Cone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Nº Faces";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(81, 108);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown3.TabIndex = 22;
            this.numericUpDown3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Altura";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(81, 70);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(15, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Backface Culling";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.disCamara);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.cb_wireframe);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Espessura_nud);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(603, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 162);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // disCamara
            // 
            this.disCamara.Location = new System.Drawing.Point(19, 124);
            this.disCamara.Maximum = 1000;
            this.disCamara.Minimum = 400;
            this.disCamara.Name = "disCamara";
            this.disCamara.Size = new System.Drawing.Size(104, 45);
            this.disCamara.TabIndex = 24;
            this.disCamara.Value = 400;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Distancia Camera";
            // 
            // pb_desenhoParalela
            // 
            this.pb_desenhoParalela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_desenhoParalela.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_desenhoParalela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_desenhoParalela.Location = new System.Drawing.Point(327, 34);
            this.pb_desenhoParalela.Margin = new System.Windows.Forms.Padding(2);
            this.pb_desenhoParalela.Name = "pb_desenhoParalela";
            this.pb_desenhoParalela.Size = new System.Drawing.Size(271, 533);
            this.pb_desenhoParalela.TabIndex = 24;
            this.pb_desenhoParalela.TabStop = false;
            this.pb_desenhoParalela.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_desenhoParalela_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Projeção Perspetiva";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(346, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Projeção Paralela";
            // 
            // ResetT_btn
            // 
            this.ResetT_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetT_btn.BackColor = System.Drawing.Color.White;
            this.ResetT_btn.Location = new System.Drawing.Point(747, 385);
            this.ResetT_btn.Name = "ResetT_btn";
            this.ResetT_btn.Size = new System.Drawing.Size(187, 26);
            this.ResetT_btn.TabIndex = 29;
            this.ResetT_btn.Text = "Reiniciar Transformações";
            this.ResetT_btn.UseVisualStyleBackColor = false;
            this.ResetT_btn.Click += new System.EventHandler(this.ResetT_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(949, 600);
            this.Controls.Add(this.ResetT_btn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pb_desenhoParalela);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Roty_tb);
            this.Controls.Add(this.Rotx_tb);
            this.Controls.Add(this.CorFill_btn);
            this.Controls.Add(this.CorFill_pb);
            this.Controls.Add(this.CorStroke_btn);
            this.Controls.Add(this.CorStroke_pb);
            this.Controls.Add(this.tb_transy);
            this.Controls.Add(this.tb_transx);
            this.Controls.Add(this.pb_desenho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(965, 639);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Desenho de Faces Poligonais";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tb_transx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorStroke_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorFill_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Espessura_nud)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Roty_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotx_tb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rotz_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenhoParalela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar tb_transx;
        private System.Windows.Forms.TrackBar tb_transy;
        private System.Windows.Forms.TrackBar tb_transz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_desenho;
        private System.Windows.Forms.PictureBox CorStroke_pb;
        private System.Windows.Forms.Button CorStroke_btn;
        private System.Windows.Forms.Button CorFill_btn;
        private System.Windows.Forms.PictureBox CorFill_pb;
        private System.Windows.Forms.CheckBox cb_wireframe;
        private System.Windows.Forms.NumericUpDown Espessura_nud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TrackBar Roty_tb;
        private System.Windows.Forms.TrackBar Rotx_tb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar Rotz_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem formasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tetraedroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prismaHexagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troncoConeToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem abrirOBJToolStripMenuItem;
        private System.Windows.Forms.TrackBar disCamara;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pb_desenhoParalela;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedoresToolStripMenuItem;
        private System.Windows.Forms.Button ResetT_btn;
    }
}

