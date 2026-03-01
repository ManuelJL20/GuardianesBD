using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Guardian_BD_beta
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = ConexionGuardianBD.ObtConexion();

        public Form1()
        { 
            InitializeComponent();
            
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        public bool Jarvis()
        {
            bool resp = false;

            for (int v = 0; v < dataGridView2.Rows.Count - 1; v++)
            {
                if (Usuario1.Text == dataGridView2.Rows[v].Cells[0].Value.ToString() && Contraseña.Text == dataGridView2.Rows[v].Cells[1].Value.ToString() && Captcha.Text == CaptchaUs.Text.ToUpper())
                {
                    MessageBox.Show("Bienvenido " + Usuario1.Text.ToUpper());
                    resp = true;

                }

            }

            return resp;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            
        }
        char[] Letras = new char[36];
        string CaptCha1;
        Random Obj = new Random();
        private void LLenar()
        {
            Letras[0] = 'A';
            Letras[1] = 'B';
            Letras[2] = 'C';
            Letras[3] = 'D';
            Letras[4] = 'E';
            Letras[5] = 'F';
            Letras[6] = 'G';
            Letras[7] = 'H';
            Letras[8] = 'I';
            Letras[9] = 'J';
            Letras[10] = 'K';
            Letras[11] = 'L';
            Letras[12] = 'M';
            Letras[13] = 'N';
            Letras[14] = 'O';
            Letras[15] = 'P';
            Letras[16] = 'Q';
            Letras[17] = 'R';
            Letras[18] = 'S';
            Letras[19] = 'T';
            Letras[20] = 'U';
            Letras[21] = 'V';
            Letras[22] = 'W';
            Letras[23] = 'X';
            Letras[24] = 'Y';
            Letras[25] = 'Z';
            Letras[26] = '0';
            Letras[27] = '1';
            Letras[28] = '2';
            Letras[29] = '3';
            Letras[30] = '4';
            Letras[31] = '5';
            Letras[32] = '6';
            Letras[33] = '7';
            Letras[34] = '8';
            Letras[35] = '9';

        }
        public string GenerarCaptCha()
        {
            CaptCha1 = "";
            for (int C = 1; C <= 4; C++)
                CaptCha1 += Letras[Obj.Next(0, 36)].ToString();

            return CaptCha1;
        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CaptchaUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string consulta = "select * from Usuario";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta1 = "select u.Tipo_usuario from Usuario u where u.Contraseña = '" + Contraseña.Text + "' and u.Nombre = '" + Usuario1.Text + "'";
            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
            SqlDataReader lector1 = comando1.ExecuteReader();
            while (lector1.Read())
            {
                tipo.Text = lector1.GetString(0);
            }
            conexion.Close();
            if (Jarvis())
            {
                Form2 Obj = new Form2(Usuario1.Text, tipo.Text);
                Obj.ShowDialog();
            }


            else

                MessageBox.Show("Usuario o Contraseña o CaptCha incorrecto, intente nuevamente");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CaptchaUs_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            conexion.Open();
            string consulta1 = "select u.Tipo_usuario from Usuario u where u.Contraseña = '" + Contraseña.Text + "' and u.Nombre = '" + Usuario1.Text + "'";
            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
            SqlDataReader lector1 = comando1.ExecuteReader();
            while (lector1.Read())
            {
                tipo.Text = lector1.GetString(0);
            }
            conexion.Close();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                if (Jarvis())

                {
                    Form2 Obj = new Form2(Usuario1.Text, tipo.Text);
                    Obj.ShowDialog();

                }


                else

                    MessageBox.Show("Usuario o Contraseña o CaptCha incorrecto, intente nuevamente");
        }

        private void Generar_Click_1(object sender, EventArgs e)
        {
            LLenar();
            Captcha.Text = GenerarCaptCha();
        }

        private void Usuario1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Contraseña.Focus();
        }

        private void Contraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CaptchaUs.Focus();
                LLenar();
                Captcha.Text = GenerarCaptCha();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 Obj = new Form15();
            Obj.ShowDialog();
        }
    }
}