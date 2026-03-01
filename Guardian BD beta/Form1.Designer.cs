
namespace Guardian_BD_beta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Captcha = new System.Windows.Forms.Label();
            this.Usuario1 = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.CaptchaUs = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Generar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(693, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(362, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "GUARDIAN IDENTIFIQUESE";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "CONTRASEÑA:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(476, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "USUARIO:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(397, 660);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "ESCRIBE EL CÓDIGO";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(749, 551);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "CAPTCHA";
            // 
            // Captcha
            // 
            this.Captcha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Captcha.Location = new System.Drawing.Point(709, 592);
            this.Captcha.Name = "Captcha";
            this.Captcha.Size = new System.Drawing.Size(295, 29);
            this.Captcha.TabIndex = 5;
            this.Captcha.Tag = "";
            this.Captcha.Text = "SOLICITA TU CAPTCHA";
            // 
            // Usuario1
            // 
            this.Usuario1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usuario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario1.Location = new System.Drawing.Point(687, 379);
            this.Usuario1.Name = "Usuario1";
            this.Usuario1.Size = new System.Drawing.Size(294, 36);
            this.Usuario1.TabIndex = 6;
            this.Usuario1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Usuario1_KeyPress);
            // 
            // Contraseña
            // 
            this.Contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(687, 458);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(294, 36);
            this.Contraseña.TabIndex = 7;
            this.Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contraseña_KeyPress_1);
            // 
            // CaptchaUs
            // 
            this.CaptchaUs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CaptchaUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptchaUs.Location = new System.Drawing.Point(687, 657);
            this.CaptchaUs.Name = "CaptchaUs";
            this.CaptchaUs.Size = new System.Drawing.Size(294, 36);
            this.CaptchaUs.TabIndex = 8;
            this.CaptchaUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CaptchaUs_KeyPress_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1406, 760);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 56);
            this.button4.TabIndex = 10;
            this.button4.Text = "INGRESAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Generar
            // 
            this.Generar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Generar.BackColor = System.Drawing.Color.Orange;
            this.Generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generar.Location = new System.Drawing.Point(481, 578);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(180, 56);
            this.Generar.TabIndex = 11;
            this.Generar.Text = "GENERAR";
            this.Generar.UseVisualStyleBackColor = false;
            this.Generar.Click += new System.EventHandler(this.Generar_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1134, 318);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(105, 38);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.Visible = false;
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(1152, 444);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(121, 24);
            this.tipo.TabIndex = 13;
            this.tipo.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Guardian_BD_beta.Properties.Resources.LOGO_FG_rediseño_008;
            this.pictureBox2.Location = new System.Drawing.Point(687, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 285);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(12, 760);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 56);
            this.button3.TabIndex = 15;
            this.button3.Text = "ACERCA DE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1649, 828);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CaptchaUs);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario1);
            this.Controls.Add(this.Captcha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Usuario1;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox CaptchaUs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Label Captcha;
        private System.Windows.Forms.Button button3;
    }
}

