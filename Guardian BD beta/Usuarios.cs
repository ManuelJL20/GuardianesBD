using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using draw = System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace Guardian_BD_beta
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        CUsuario objv = new CUsuario();
        CUsuarioM objm = new CUsuarioM();

        SqlConnection conexion = ConexionGuardianBD.ObtConexion();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Usuario";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void insertar()
        {

            conexion.Open();
            string consulta= "INSERT INTO Usuario(Nombre, Contraseña, Tipo_usuario) VALUES('"+nom.Text+ "', '" + con.Text + "', '" + rol.Text + "')"; 
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se registró con éxito");
            conexion.Close();

            nom.Clear();
            con.Clear();
            rol.SelectedIndex = -1;


            string consulta1 = "select * from Usuario";
            SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
            DataTable dt = new DataTable();
            adaptador1.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(objv.datosok(Error, nom, con, rol, dataGridView1))
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea agregar un nuevo usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    insertar();
                }
                else return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (objm.datosok(Error, nom, con, rol, dataGridView1))
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea modificar los datos del usuario?.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    conexion.Open();
                    string consulta = "UPDATE Usuario SET Nombre = '" + nom.Text + "', Contraseña = '" + con.Text + "',Tipo_usuario = '" + rol.Text + "' WHERE Contraseña = '" + conres.Text + "' and Nombre ='" + nomres.Text + "'";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se modificó con éxito");
                    conexion.Close();

                    button2.Enabled = false;
                    button3.Enabled = false;
                    button1.Enabled = true;
                    nom.Clear();
                    con.Clear();
                    rol.SelectedIndex = -1;

                    string consulta1 = "select * from Usuario";
                    SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
                    DataTable dt = new DataTable();
                    adaptador1.Fill(dt);
                    dataGridView1.DataSource = dt;



                }
                else return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "DELETE FROM Usuario WHERE Contraseña = '"+con.Text+"'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("El registro ha sido borrado con éxito.");
            conexion.Close();

            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;
            nom.Clear();
            con.Clear();
            rol.SelectedIndex = -1;
            string consulta1 = "select * from Usuario";
            SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
            DataTable dt = new DataTable();
            adaptador1.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = false;

            try
            {
                nom.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                con.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                rol.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                conres.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                nomres.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();



            }
            catch { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true ;
            button3.Enabled = true;
            button1.Enabled = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;
            nom.Clear();
            con.Clear();
            rol.SelectedIndex = -1;
        }
    }
}
