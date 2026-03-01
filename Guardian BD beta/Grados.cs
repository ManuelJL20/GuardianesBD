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
    using System.Data.SqlClient;
    public partial class Grados : Form
    {
        public Grados()
        {
            InitializeComponent();
        }
        SqlConnection conexion = ConexionGuardianBD.ObtConexion();
        CValGrados objv = new CValGrados();
        private void Grados_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Grados ";
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

        private void agregar_Click(object sender, EventArgs e)
        {
            if (objv.datosok(Error, id, nom, cat))
            {
                conexion.Open();
                string consulta = "insert into Grados values('" + id.Text + "','" + nom.Text + "', '" + cat.Text + "')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se registró con éxito");
                conexion.Close();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            string consulta = "select * from Grados ";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
