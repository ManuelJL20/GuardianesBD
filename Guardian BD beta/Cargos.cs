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
    public partial class Cargos : Form
    {
        public Cargos()
        {
            InitializeComponent();
        }
        SqlConnection conexion = ConexionGuardianBD.ObtConexion();
        CValTabParamIDText objv = new CValTabParamIDText();
        private void Cargos_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Cargo ";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú_parametros Obj = new Menú_parametros();
            Obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (objv.datosok(Error, id, nom))
            {
                conexion.Open();
                string consulta = "insert into Cargo values('" + id.Text + "','" + nom.Text + "')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se registró con éxito");
                conexion.Close();
            }
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            string consulta = "select * from Cargo ";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
