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
    public partial class verif_para : Form
    {
        public verif_para()
        {
            InitializeComponent();
        }

        private void verif_para_Load(object sender, EventArgs e)
        {

        }
        private bool Jarvis()
        {
            if (Captcha.Text == CaptchaUs.Text.ToUpper())
                if (Usuario.Text.ToUpper() == "RICARDO" && Contraseña.Text == "2906")
                {
                    this.Hide();

                    return true;
                }
                else
                    return false;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Jarvis())

            {
                Menú_parametros Obj = new Menú_parametros();
                Obj.ShowDialog();

            }


            else

                MessageBox.Show("Usuario o Contraseña o CaptCha incorrecto, intente nuevamente");
        }
        public string GenerarCaptCha()
        {
            CaptCha1 = "";
            for (int C = 1; C <= 4; C++)
                CaptCha1 += Letras[Obj.Next(0, 36)].ToString();

            return CaptCha1;
        }
        private void Generar_Click(object sender, EventArgs e)
        {
            LLenar();
            Captcha.Text = GenerarCaptCha();
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
        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Contraseña.Focus();
        }

        private void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CaptchaUs.Focus();
                LLenar();
                Captcha.Text = GenerarCaptCha();
            }
        }

        private void CaptchaUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                if (Jarvis())

                {
                    Menú_parametros Obj = new Menú_parametros();
                    Obj.ShowDialog();

                }


                else

                    MessageBox.Show("Usuario o Contraseña o CaptCha incorrecto, intente nuevamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void Usuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Contraseña.Focus();
        }

        private void Contraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                CaptchaUs.Focus();
        }

        private void CaptchaUs_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                if (Jarvis())

                {
                    Menú_parametros Obj = new Menú_parametros();
                    Obj.ShowDialog();

                }


                else

                    MessageBox.Show("Usuario o Contraseña o CaptCha incorrecto, intente nuevamente");
        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
