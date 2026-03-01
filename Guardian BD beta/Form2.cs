using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
    using System.IO;
using System.Data.SqlClient;


namespace Guardian_BD_beta
{
    public partial class Form2 : Form
    {
        string Usuario;
        string tipo;
        public Form2(string Usu, string tip)
        {
            InitializeComponent();
            Usuario = Usu;
            tipo = tip;
        }
        SqlConnection conexion = ConexionGuardianBD.ObtConexion();

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = tipo.ToUpper()+": " + Usuario.ToUpper();
            if(tipo=="Administrador")
            {
                button8.Visible = true;
                button6.Visible = true;

            }
            else
            {
                button8.Visible = false;
                button6.Visible = false;


            }
            conexion.Open();
            string consulta1 = "select max(m.Municipio_y_lugar) from Misión m where m.ID_Misión=(select max(m.ID_Misión) from Misión m)";
            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
            SqlDataReader lector1 = comando1.ExecuteReader();
            if (lector1.Read())  // Lee si existe un valor
            {
                // Verificamos si el valor es NULL.
                if (lector1.IsDBNull(0))
                {
                    button5.Enabled = false;
                }
                else
                {
                    button5.Enabled = true; ;
                }
            }
            conexion.Close();

            conexion.Open();
            string consulta5 = "select v.Apellidos from Voluntario v  where v.Estado='Activo' order by 1";
            SqlCommand comando5 = new SqlCommand(consulta5, conexion);
            SqlDataReader lector5 = comando5.ExecuteReader();

            if (lector5.Read())  // Lee si existe un valor
            {
                // Verificamos si el valor es NULL.
                if (lector5.IsDBNull(0))
                {
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true; ;
                }
            }
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 Obj = new Form6();
            Obj.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Obj = new Form3(Usuario, tipo);
            Obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 Obj = new Form7(Usuario, tipo);
            Obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 Obj = new Form11(Usuario, tipo);
            Obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pROVINCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 Obj = new Form6();
            Obj.ShowDialog();
        }

        private void gRADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 Obj = new Form12();
            Obj.ShowDialog();
        }

        private void cARGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 Obj = new Form13();
            Obj.ShowDialog();
        }

        private void cÓDIGO10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 Obj = new Form14();
            Obj.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Menú_parametros Obj = new Menú_parametros();
            Obj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grados Obj = new Grados();
            Obj.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Obj = new Form1();
            Obj.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Usuarios Obj = new Usuarios();
            Obj.ShowDialog();
        }
    }
    }
    
    
