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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=ESCUDE29\\SQLEXPRESS04; database=Guardian_beta1; integrated security=true");

        private void Form12_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Grados ";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
