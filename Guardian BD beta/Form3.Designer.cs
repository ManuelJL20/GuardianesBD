
namespace Guardian_BD_beta
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.san = new System.Windows.Forms.ComboBox();
            this.celu = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.ComboBox();
            this.agregar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.mas = new System.Windows.Forms.RadioButton();
            this.fem = new System.Windows.Forms.RadioButton();
            this.act = new System.Windows.Forms.RadioButton();
            this.inact = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Usu3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.pdf = new System.Windows.Forms.Button();
            this.sanbus = new System.Windows.Forms.ComboBox();
            this.grabus = new System.Windows.Forms.ComboBox();
            this.carbus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nro = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nro)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(603, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ci
            // 
            this.ci.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ci.Location = new System.Drawing.Point(12, 287);
            this.ci.Name = "ci";
            this.ci.ShortcutsEnabled = false;
            this.ci.Size = new System.Drawing.Size(214, 36);
            this.ci.TabIndex = 17;
            this.ci.TextChanged += new System.EventHandler(this.ci_TextChanged);
            this.ci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ci_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "CI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grado
            // 
            this.grado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grado.FormattingEnabled = true;
            this.grado.Location = new System.Drawing.Point(12, 376);
            this.grado.Name = "grado";
            this.grado.Size = new System.Drawing.Size(214, 37);
            this.grado.TabIndex = 19;
            this.grado.SelectedIndexChanged += new System.EventHandler(this.grado_SelectedIndexChanged);
            this.grado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grado_MouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Num. Emergencia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Correo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Celular";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Grupo sanguíneo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 623);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha nacimiento";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Apellidos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 29);
            this.label9.TabIndex = 27;
            this.label9.Text = "Nombre";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 29);
            this.label10.TabIndex = 28;
            this.label10.Text = "Grado";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // nombre
            // 
            this.nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(12, 475);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(214, 36);
            this.nombre.TabIndex = 29;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // apellidos
            // 
            this.apellidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidos.Location = new System.Drawing.Point(12, 567);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(214, 36);
            this.apellidos.TabIndex = 30;
            this.apellidos.TextChanged += new System.EventHandler(this.apellidos_TextChanged);
            // 
            // fecha_nac
            // 
            this.fecha_nac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fecha_nac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_nac.Location = new System.Drawing.Point(12, 655);
            this.fecha_nac.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.fecha_nac.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.fecha_nac.Name = "fecha_nac";
            this.fecha_nac.Size = new System.Drawing.Size(214, 36);
            this.fecha_nac.TabIndex = 32;
            this.fecha_nac.Value = new System.DateTime(2026, 1, 23, 0, 0, 0, 0);
            this.fecha_nac.ValueChanged += new System.EventHandler(this.fecha_nac_ValueChanged);
            // 
            // san
            // 
            this.san.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.san.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.san.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.san.FormattingEnabled = true;
            this.san.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.san.Location = new System.Drawing.Point(291, 287);
            this.san.Name = "san";
            this.san.Size = new System.Drawing.Size(214, 37);
            this.san.TabIndex = 33;
            this.san.SelectedIndexChanged += new System.EventHandler(this.san_SelectedIndexChanged);
            // 
            // celu
            // 
            this.celu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.celu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celu.Location = new System.Drawing.Point(291, 376);
            this.celu.Name = "celu";
            this.celu.Size = new System.Drawing.Size(214, 36);
            this.celu.TabIndex = 34;
            this.celu.TextChanged += new System.EventHandler(this.celu_TextChanged);
            this.celu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.celu_KeyPress);
            // 
            // correo
            // 
            this.correo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(291, 475);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(214, 36);
            this.correo.TabIndex = 35;
            this.correo.TextChanged += new System.EventHandler(this.correo_TextChanged);
            this.correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correo_KeyPress);
            // 
            // num
            // 
            this.num.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(291, 567);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(214, 36);
            this.num.TabIndex = 36;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            this.num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // cargo
            // 
            this.cargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.FormattingEnabled = true;
            this.cargo.Location = new System.Drawing.Point(291, 658);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(214, 37);
            this.cargo.TabIndex = 37;
            this.cargo.SelectedIndexChanged += new System.EventHandler(this.cargo_SelectedIndexChanged);
            // 
            // agregar
            // 
            this.agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agregar.BackColor = System.Drawing.Color.Gold;
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(921, 910);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(214, 65);
            this.agregar.TabIndex = 38;
            this.agregar.Text = "AGREGAR";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modificar.BackColor = System.Drawing.Color.Gold;
            this.modificar.Enabled = false;
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(1153, 910);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(212, 65);
            this.modificar.TabIndex = 40;
            this.modificar.Text = "MODIFICAR";
            this.modificar.UseVisualStyleBackColor = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonbuscar.BackColor = System.Drawing.Color.Gold;
            this.buttonbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuscar.Location = new System.Drawing.Point(942, 386);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(161, 45);
            this.buttonbuscar.TabIndex = 41;
            this.buttonbuscar.Text = "BUSCAR";
            this.buttonbuscar.UseVisualStyleBackColor = false;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buscar
            // 
            this.buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(603, 386);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(333, 45);
            this.buscar.TabIndex = 42;
            this.buscar.TextChanged += new System.EventHandler(this.buscar_TextChanged);
            this.buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscar_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(704, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 33);
            this.label11.TabIndex = 43;
            this.label11.Text = "VOLUNTARIOS";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gold;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 45);
            this.button5.TabIndex = 44;
            this.button5.Text = "VOLVER";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // refresh
            // 
            this.refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.refresh.BackColor = System.Drawing.Color.Gold;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(1104, 386);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(170, 45);
            this.refresh.TabIndex = 45;
            this.refresh.Text = "RESETEAR";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // mas
            // 
            this.mas.AutoSize = true;
            this.mas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mas.Location = new System.Drawing.Point(14, 79);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(158, 33);
            this.mas.TabIndex = 46;
            this.mas.Text = "Masculino";
            this.mas.UseVisualStyleBackColor = true;
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.Checked = true;
            this.fem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fem.Location = new System.Drawing.Point(14, 40);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(155, 33);
            this.fem.TabIndex = 47;
            this.fem.TabStop = true;
            this.fem.Text = "Femenino";
            this.fem.UseVisualStyleBackColor = true;
            // 
            // act
            // 
            this.act.AutoSize = true;
            this.act.Checked = true;
            this.act.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.act.Location = new System.Drawing.Point(22, 36);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(110, 33);
            this.act.TabIndex = 49;
            this.act.TabStop = true;
            this.act.Text = "Activo";
            this.act.UseVisualStyleBackColor = true;
            this.act.CheckedChanged += new System.EventHandler(this.act_CheckedChanged);
            // 
            // inact
            // 
            this.inact.AutoSize = true;
            this.inact.Enabled = false;
            this.inact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inact.Location = new System.Drawing.Point(22, 75);
            this.inact.Name = "inact";
            this.inact.Size = new System.Drawing.Size(129, 33);
            this.inact.TabIndex = 48;
            this.inact.Text = "Inactivo";
            this.inact.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.fem);
            this.groupBox1.Controls.Add(this.mas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 721);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 130);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Género";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Controls.Add(this.act);
            this.groupBox2.Controls.Add(this.inact);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(291, 721);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 130);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 29);
            this.label12.TabIndex = 52;
            this.label12.Text = "Formulario de registro:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(603, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 91);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda por:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(523, 35);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(107, 33);
            this.radioButton4.TabIndex = 51;
            this.radioButton4.Text = "Cargo";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(258, 36);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(242, 33);
            this.radioButton3.TabIndex = 50;
            this.radioButton3.Text = "Grupo sanguíneo";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(22, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 33);
            this.radioButton1.TabIndex = 49;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CI";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(118, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 33);
            this.radioButton2.TabIndex = 48;
            this.radioButton2.Text = "Grado";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Guardian_BD_beta.Properties.Resources.LOGO_FG_rediseño_008;
            this.pictureBox1.Location = new System.Drawing.Point(1462, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clear
            // 
            this.clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear.BackColor = System.Drawing.Color.Gold;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(921, 981);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(444, 58);
            this.clear.TabIndex = 55;
            this.clear.Text = "CANCELAR Y NUEVO REGISTRO";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(603, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(753, 91);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar:";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(448, 36);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(299, 33);
            this.radioButton5.TabIndex = 51;
            this.radioButton5.Text = "Cantidad de misiones";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(282, 36);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(143, 33);
            this.radioButton6.TabIndex = 50;
            this.radioButton6.Text = "Inactivos";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(22, 36);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(95, 33);
            this.radioButton7.TabIndex = 49;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Todo";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(138, 36);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(124, 33);
            this.radioButton8.TabIndex = 48;
            this.radioButton8.Text = "Activos";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1065, 835);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(10, 10);
            this.dataGridView2.TabIndex = 56;
            this.dataGridView2.Visible = false;
            // 
            // Usu3
            // 
            this.Usu3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Usu3.AutoSize = true;
            this.Usu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usu3.Location = new System.Drawing.Point(275, 96);
            this.Usu3.Name = "Usu3";
            this.Usu3.Size = new System.Drawing.Size(22, 29);
            this.Usu3.TabIndex = 57;
            this.Usu3.Text = "-";
            this.Usu3.Click += new System.EventHandler(this.Usu3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1285, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 45);
            this.button1.TabIndex = 58;
            this.button1.Text = "IMPORTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1452, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 45);
            this.button2.TabIndex = 59;
            this.button2.Text = "EXPORTAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(598, 860);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(416, 25);
            this.label14.TabIndex = 136;
            this.label14.Text = "Si desea modificar haga doble click en la tabla.";
            // 
            // pdf
            // 
            this.pdf.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pdf.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pdf.Enabled = false;
            this.pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdf.Location = new System.Drawing.Point(1452, 860);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(161, 60);
            this.pdf.TabIndex = 137;
            this.pdf.Text = "IMPRIMIR REPORTE";
            this.pdf.UseVisualStyleBackColor = false;
            this.pdf.Click += new System.EventHandler(this.button3_Click);
            // 
            // sanbus
            // 
            this.sanbus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sanbus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sanbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sanbus.FormattingEnabled = true;
            this.sanbus.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.sanbus.Location = new System.Drawing.Point(603, 393);
            this.sanbus.Name = "sanbus";
            this.sanbus.Size = new System.Drawing.Size(214, 37);
            this.sanbus.TabIndex = 138;
            this.sanbus.Visible = false;
            this.sanbus.SelectedIndexChanged += new System.EventHandler(this.sanbus_SelectedIndexChanged);
            // 
            // grabus
            // 
            this.grabus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grabus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grabus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabus.FormattingEnabled = true;
            this.grabus.Location = new System.Drawing.Point(603, 393);
            this.grabus.Name = "grabus";
            this.grabus.Size = new System.Drawing.Size(321, 37);
            this.grabus.TabIndex = 139;
            this.grabus.Visible = false;
            this.grabus.SelectedIndexChanged += new System.EventHandler(this.grabus_SelectedIndexChanged);
            // 
            // carbus
            // 
            this.carbus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.carbus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbus.FormattingEnabled = true;
            this.carbus.Location = new System.Drawing.Point(603, 393);
            this.carbus.Name = "carbus";
            this.carbus.Size = new System.Drawing.Size(262, 37);
            this.carbus.TabIndex = 140;
            this.carbus.Visible = false;
            this.carbus.SelectedIndexChanged += new System.EventHandler(this.carbus_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(141, 910);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(245, 29);
            this.label13.TabIndex = 141;
            this.label13.Text = "Nro. de antigüedad";
            // 
            // nro
            // 
            this.nro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nro.Location = new System.Drawing.Point(208, 942);
            this.nro.Name = "nro";
            this.nro.Size = new System.Drawing.Size(89, 36);
            this.nro.TabIndex = 147;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1625, 1102);
            this.Controls.Add(this.nro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.carbus);
            this.Controls.Add(this.grabus);
            this.Controls.Add(this.sanbus);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Usu3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.num);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.celu);
            this.Controls.Add(this.san);
            this.Controls.Add(this.fecha_nac);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ci);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Registro de voluntarios";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox grado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.DateTimePicker fecha_nac;
        private System.Windows.Forms.ComboBox san;
        private System.Windows.Forms.TextBox celu;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.ComboBox cargo;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.RadioButton mas;
        private System.Windows.Forms.RadioButton fem;
        private System.Windows.Forms.RadioButton act;
        private System.Windows.Forms.RadioButton inact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Usu3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.ComboBox carbus;
        private System.Windows.Forms.ComboBox grabus;
        private System.Windows.Forms.ComboBox sanbus;
        private System.Windows.Forms.NumericUpDown nro;
        private System.Windows.Forms.Label label13;
    }
}