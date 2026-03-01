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
    public partial class Provincias : Form
    {
        public int incrementar()
        {
            if (id.Text == "NULL")
            {
                id.Text = "0";
                int acc = Convert.ToInt32(id.Text) + 1;
                return acc;
            }
            else
            {
                int acc = Convert.ToInt32(id.Text) + 1;
                return acc;
            }
        }
        public Provincias()
        {
            InitializeComponent();
        }
        SqlConnection conexion = ConexionGuardianBD.ObtConexion();
        CValTabParamIdint objv = new CValTabParamIdint();
        private void Provincias_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Provincias ";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            conexion.Open();
            string consulta1 = "select max(p.ID_Provincia) from Provincias p ";
            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
            SqlDataReader lector1 = comando1.ExecuteReader();
            while (lector1.Read())
            {
                id.Text=(lector1.GetInt32(0)).ToString();
            }
            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú_parametros Obj = new Menú_parametros();
            Obj.ShowDialog();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (objv.datosok(Error, nom))
            {
                conexion.Open();
                string consulta = "insert into Provincias values('" + incrementar() + "','" + nom.Text + "')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se registró con éxito");
                conexion.Close();

                conexion.Open();
                string consulta1 = "select max(p.ID_Provincia) from Provincias p ";
                SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                SqlDataReader lector1 = comando1.ExecuteReader();
                while (lector1.Read())
                {
                    id.Text = (lector1.GetInt32(0)).ToString();
                }
                conexion.Close();
            }
        }

       
       
        private void refresh_Click(object sender, EventArgs e)
        {
            string consulta = "select * from Provincias ";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            
        }
    }
}
