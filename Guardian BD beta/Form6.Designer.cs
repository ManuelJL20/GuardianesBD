
namespace Guardian_BD_beta
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnregresar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnacercade = new System.Windows.Forms.ToolStripMenuItem();
            this.cARGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cÓDIGO10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsalir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(147, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(580, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnregresar,
            this.btnacercade,
            this.btnsalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 31);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnregresar
            // 
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(109, 27);
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnacercade
            // 
            this.btnacercade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cARGOSToolStripMenuItem,
            this.gRADOSToolStripMenuItem,
            this.cÓDIGO10ToolStripMenuItem});
            this.btnacercade.Name = "btnacercade";
            this.btnacercade.Size = new System.Drawing.Size(104, 27);
            this.btnacercade.Text = "DETALLES";
            // 
            // cARGOSToolStripMenuItem
            // 
            this.cARGOSToolStripMenuItem.Name = "cARGOSToolStripMenuItem";
            this.cARGOSToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.cARGOSToolStripMenuItem.Text = "CARGOS";
            // 
            // gRADOSToolStripMenuItem
            // 
            this.gRADOSToolStripMenuItem.Name = "gRADOSToolStripMenuItem";
            this.gRADOSToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.gRADOSToolStripMenuItem.Text = "GRADOS";
            // 
            // cÓDIGO10ToolStripMenuItem
            // 
            this.cÓDIGO10ToolStripMenuItem.Name = "cÓDIGO10ToolStripMenuItem";
            this.cÓDIGO10ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.cÓDIGO10ToolStripMenuItem.Text = "CÓDIGO 10";
            // 
            // btnsalir
            // 
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(71, 27);
            this.btnsalir.Text = "SALIR";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 618);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnregresar;
        private System.Windows.Forms.ToolStripMenuItem btnacercade;
        private System.Windows.Forms.ToolStripMenuItem cARGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cÓDIGO10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnsalir;
    }
}