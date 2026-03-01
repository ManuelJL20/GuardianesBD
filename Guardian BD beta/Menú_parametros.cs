using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guardian_BD_beta
{
    public partial class Menú_parametros : Form
    {
        public Menú_parametros()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Provincias Obj = new Provincias();
            Obj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grados Obj = new Grados();
            Obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cargos Obj = new Cargos();
            Obj.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Codigos Obj = new Codigos();
            Obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menú_parametros_Load(object sender, EventArgs e)
        {

        }
    }
}
