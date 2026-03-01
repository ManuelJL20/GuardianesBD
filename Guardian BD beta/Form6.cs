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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=ESCUDE29\\SQLEXPRESS04; database=Guardian_beta1; integrated security=true");

        private void Form6_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Provincias ";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta,conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource=dt;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
