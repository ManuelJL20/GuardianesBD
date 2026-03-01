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
    public partial class Form7 : Form
    {
        string Usuario;
        string tipo;
        public int incrementar()
        {
            int acc;


            acc = Convert.ToInt32(id.Text) + 1;
            return acc;



        }


        public Form7(string usu, string tip)
        {
            InitializeComponent();
            Usuario = usu;
            tipo = tip;
        }
        CValidacionM objV = new CValidacionM();
        SqlConnection conexion = ConexionGuardianBD.ObtConexion();
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            usu7.Text = tipo.ToUpper() + ": " + Usuario.ToUpper();
      if (tipo == "Administrador")
      {
        agregar.Visible = true;
        modificar.Visible = true;
        button4.Visible = true;
        label14.Visible = true;
        clear.Visible = true;

      }
      else
      {
        agregar.Visible = false;
        modificar.Visible = false;
        button4.Visible = false;
        label14.Visible = false;
        clear.Visible = false;
      }
      if (radioButton5.Checked)
            {
                string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información',  m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo' from Misión m, Voluntario v, Provincias p, Tipo_mision tp where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {

                if (radioButton4.Checked)
                {
                    string consultaa = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información', COUNT(hm.ID_Misión) as Voluntarios, m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo' from Misión m, Voluntario v, Provincias p, Tipo_mision tp, Historial_de_misiones hm where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión=m.ID_Tipo_misión  group by m.ID_Misión, p.Nombre, m.Municipio_y_lugar, m.Fecha , v.Apellidos , v.Nombre , tp.Tipo ,m.Informacion_de_la_misión, m.Casco,m.Blusa, m.Pantalon, m.Overol, m.Guantes, m.Antiparras,m.Botas, m.Machetes , m.McLoud , m.Pala_forestal, m.Gorgui, m.Mochila_bomba , m.Matafuego, m.Pulasky, m.Quemador_de_goteo, m.Kit_de_ataque_rápido, m.Lazo, m.Red_de_mano, m.Varilla_para_serpientes, m.Bastón_de_captura, m.Chaleco, m.Bolsa_de_tiro, m.Patas_de_rana, m.Visore, m.Cuerda_principal, m.Cuerda_auxiliar, m.Cuerda_utilitaria, m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho, m.Arnes, m.Casco_tactico, m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña, m.Botiquín_simple, m.Tabla_espinal, m.Camilla_táctica, m.Camilla_plegable, m.Chalecos_reflectivos, m.Linternas, m.Handy, m.Mochila,m.Conos_reflectivos, m.Cintas_de_delimitación, m.Vehiculo order by 1";
                    SqlDataAdapter adaptadora = new SqlDataAdapter(consultaa, conexion);
                    DataTable dta = new DataTable();
                    adaptadora.Fill(dta);
                    dataGridView1.DataSource = dta;
                }
            }
            conexion.Open();
            string consulta0 = "select max(m.ID_Misión) from Misión m";
            SqlCommand comando0 = new SqlCommand(consulta0, conexion);
            SqlDataReader lector0 = comando0.ExecuteReader();
            if (lector0.Read())  // Lee si existe un valor
            {
                // Verificamos si el valor es NULL.
                if (lector0.IsDBNull(0))
                {
                    id.Text = "0";  // Si es NULL, se asigna el valor "0" al TextBox.
                }
                else
                {
                    id.Text = lector0.GetInt32(0).ToString();  // Si no es NULL, convertimos el número a cadena.
                }
            }

            conexion.Close();

            ubi.Text = "#"+incrementar()+" :";

            conexion.Open();
            string consulta1 = "select p.Nombre from Provincias p";
            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
            SqlDataReader lector1 = comando1.ExecuteReader();

            while (lector1.Read())
            {
                idprov.Items.Add(lector1.GetString(0));
            }
            conexion.Close();

            conexion.Open();
            string consulta1t = "select t.Tipo from Tipo_mision t";
            SqlCommand comando1t = new SqlCommand(consulta1t, conexion);
            SqlDataReader lector1t = comando1t.ExecuteReader();

            while (lector1t.Read())
            {
                tipmis.Items.Add(lector1t.GetString(0));
            }
            conexion.Close();

            conexion.Open();
            string consulta1a = "select p.Nombre from Provincias p";
            SqlCommand comando1a = new SqlCommand(consulta1a, conexion);
            SqlDataReader lector1a = comando1a.ExecuteReader();

            while (lector1a.Read())
            {
                bus.Items.Add(lector1a.GetString(0));
            }
            conexion.Close();

            conexion.Open();
            string consulta3 = "select tp.Tipo from Tipo_mision tp";
            SqlCommand comando3 = new SqlCommand(consulta3, conexion);
            SqlDataReader lector3 = comando3.ExecuteReader();
            while (lector3.Read())
            {
                tipbus.Items.Add(lector3.GetString(0));
            }
            conexion.Close();

            conexion.Open();
            string consulta2 = "select v.Apellidos from Voluntario v, Grados g where v.Estado = 'Activo' and g.ID_Grado=v.ID_Grado and (g.Categoría= 'Brigadiers' or g.Categoría='Oficiales' or g.Grado= 'Cadete Primero') order by 1";
            SqlCommand comando2 = new SqlCommand(consulta2, conexion);
            SqlDataReader lector2 = comando2.ExecuteReader();

            while (lector2.Read())
            {
                jefe.Items.Add(lector2.GetString(0));
            }
            conexion.Close();

            conexion.Open();
            string consulta2a = "select v.Apellidos from Voluntario v, Grados g where v.Estado = 'Activo' and g.ID_Grado=v.ID_Grado and (g.Categoría= 'Brigadiers' or g.Categoría='Oficiales' or g.Grado= 'Cadete Primero') order by 1";
            SqlCommand comando2a = new SqlCommand(consulta2a, conexion);
            SqlDataReader lector2a = comando2a.ExecuteReader();

            while (lector2a.Read())
            {
                apebus.Items.Add(lector2a.GetString(0));
            }
            conexion.Close();

            string consulta4 = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado";
            SqlDataAdapter adaptador4 = new SqlDataAdapter(consulta4, conexion);
            DataTable dt2 = new DataTable();
            adaptador4.Fill(dt2);
            dataGridView2.DataSource = dt2;
            //VERIFICADOR SI EL VOLUNTARIO ESTA DE MISION U OTRAS COSAS PARA VERIFICAR DATOS AL REGISTRAR UNA NUEVA MISION

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void agregar_Click(object sender, EventArgs e)
        {

            if (objV.datosok(Error, idprov, fec, jefe, tipmis, jefenom, ubi, acerca, dataGridView2))
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea agregar dicha misión? Si tiene dudas antes de agregar revise bien los datos, una vez registrado solo podrá modificar los datos pero no borrarlos.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Misión (ID_Misión, ID_Tipo_misión, ID_Provincia, Municipio_y_lugar, Fecha, CI_Jefe, Casco, Blusa, Pantalon, Overol,  Guantes, Antiparras, Botas, Machetes, McLoud, Pala_forestal, Gorgui, Mochila_bomba, Matafuego, Pulasky, Quemador_de_goteo, Kit_de_ataque_rápido, Lazo, Red_de_mano, Varilla_para_serpientes, Bastón_de_captura, Chaleco, Bolsa_de_tiro, Patas_de_rana, Visore, Cuerda_principal, Cuerda_auxiliar, Cuerda_utilitaria, Cordino, Cinta, Mosquetón, Descensor_ocho, Arnes, Casco_tactico, Grigri, Roldanas, Ascender, Cortafilo, Botiquín_de_campaña, Botiquín_simple, Tabla_espinal, Camilla_táctica, Camilla_plegable, Chalecos_reflectivos, Linternas, Handy, Mochila, Conos_reflectivos, Cintas_de_delimitación, Vehiculo, Informacion_de_la_misión) VALUES('" + incrementar() + "','" + tip.Text + "','" + pr.Text + "','" + ubi.Text + "','" + (fec.Value.Date).ToString() + "','" + cj.Text + "', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,'" + acerca.Text + "')";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se registró con éxito");
                    conexion.Close();



                    conexion.Open();
                    string consulta0 = "select max(m.ID_Misión) from Misión m";
                    SqlCommand comando0 = new SqlCommand(consulta0, conexion);
                    SqlDataReader lector0 = comando0.ExecuteReader();
                    while (lector0.Read())
                    {
                        id.Text = (lector0.GetInt32(0)).ToString();
                    }
                    conexion.Close(); //OBTENER EL ID MAYOR



                    string consulta1 = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información',  m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo' from Misión m, Voluntario v, Provincias p, Tipo_mision tp where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión";
                    SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
                    DataTable dt = new DataTable();
                    adaptador1.Fill(dt);
                    dataGridView1.DataSource = dt;

                    ubi.Clear();
                    acerca.Clear();
                    idprov.SelectedIndex = -1;
                    jefe.SelectedIndex = -1;
                    jefenom.SelectedIndex = -1;
                    tipmis.SelectedIndex = -1;
                }
                else return;

            }
            ubi.Text = "#" + incrementar()+ " :";
        }




        private void idprov_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jefe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            agregar.Enabled = true;
            apebus.Visible = false;
            nombus.Visible = false;
            bus.Visible = true;
            ubi.Clear();
            acerca.Clear();
            idprov.SelectedIndex = -1;
            jefe.SelectedIndex = -1;
            tipmis.SelectedIndex = -1;
            jefenom.Items.Clear();
            modificar.Enabled = false;
            radioButton1.Checked = true;
            radioButton5.Checked = true;

            button1.Enabled = true;
            conexion.Open();
            string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información',  m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo' from Misión m, Voluntario v, Provincias p, Tipo_mision tp where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();

            conexion.Open();
            string consulta0 = "select max(m.ID_Misión) from Misión m";
            SqlCommand comando0 = new SqlCommand(consulta0, conexion);
            SqlDataReader lector0 = comando0.ExecuteReader();

            while (lector0.Read())
            {
                id.Text = (lector0.GetInt32(0)).ToString();
            }

            conexion.Close();
            ubi.Text = "#" + incrementar() + " :";

        }

        private void idprov_TextChanged(object sender, EventArgs e)
        {




        }

        private void jefe_TextChanged(object sender, EventArgs e)
        {



        }

        private void idher_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void idher_TextChanged(object sender, EventArgs e)
        {

        }

        private void idprov_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta2 = "select p.ID_Provincia from Provincias p where p.Nombre = '" + idprov.Text + "'";
            SqlCommand comando2 = new SqlCommand(consulta2, conexion);
            SqlDataReader lector2 = comando2.ExecuteReader();
            while (lector2.Read())
            {
                pr.Text = (lector2.GetInt32(0)).ToString();
            }
            conexion.Close();
        }

        private void jefe_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            conexion.Open();
            string consulta4 = "select v.Nombre from Voluntario v, Grados g where v.Apellidos = '" + jefe.Text + "' and g.ID_Grado=v.ID_Grado and (g.Categoría= 'Brigadiers' or g.Categoría='Oficiales' or g.Grado= 'Cadete Primero') order by 1";
            SqlCommand comando4 = new SqlCommand(consulta4, conexion);
            SqlDataReader lector4 = comando4.ExecuteReader();
            while (lector4.Read())
            {
                jefenom.Items.Add(lector4.GetString(0));
            }
            conexion.Close();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            agregar.Enabled = false;
            try
            {

                id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                idprov.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ubi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                fec.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                jefe.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                jefenom.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                tipmis.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                acerca.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch { }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (objV.datosok(Error, idprov, fec, jefe, tipmis, jefenom, ubi, acerca, dataGridView2))
            {

                conexion.Open();
                string consultaa = "update Misión set ID_Misión='" + id.Text + "', ID_Tipo_misión='" + tip.Text + "', ID_Provincia='" + pr.Text + "', Municipio_y_lugar ='" + ubi.Text + "', Fecha='" + (fec.Value.Date).ToString() + "', CI_Jefe='" + cj.Text + "', Informacion_de_la_misión = '" + acerca.Text + "' where ID_Misión = '" + id.Text + "'";
                SqlCommand comandoa = new SqlCommand(consultaa, conexion);
                int cant;
                cant = comandoa.ExecuteNonQuery();
                if (cant > 0)
                {
                    MessageBox.Show("Registro modificado");
                }
                conexion.Close();

                ubi.Clear();
                acerca.Clear();
                idprov.SelectedIndex = -1;
                jefe.SelectedIndex = -1;
                jefenom.SelectedIndex = -1;
                tipmis.SelectedIndex = -1;
                modificar.Enabled = false;

                string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información',  m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo' from Misión m, Voluntario v, Provincias p, Tipo_mision tp where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;

                conexion.Open();
                string consulta0 = "select max(m.ID_Misión) from Misión m";
                SqlCommand comando0 = new SqlCommand(consulta0, conexion);
                SqlDataReader lector0 = comando0.ExecuteReader();

                while (lector0.Read())
                {
                    id.Text = (lector0.GetInt32(0)).ToString();
                }

                conexion.Close();

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            agregar.Enabled = true;
            jefenom.Items.Clear();
            ubi.Clear();
            acerca.Clear();
            idprov.SelectedIndex = -1;
            jefe.SelectedIndex = -1;
            tipmis.SelectedIndex = -1;
            jefenom.SelectedIndex = -1;
            modificar.Enabled = false;
            radioButton1.Checked = true;
            button1.Enabled = true;
            radioButton5.Checked = true;
            apebus.Visible = false;
            nombus.Visible = false;
            bus.Visible = true;

            conexion.Open();
            string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información',  m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo' from Misión m, Voluntario v, Provincias p, Tipo_mision tp where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();

            conexion.Open();
            string consulta0 = "select max(m.ID_Misión) from Misión m";
            SqlCommand comando0 = new SqlCommand(consulta0, conexion);
            SqlDataReader lector0 = comando0.ExecuteReader();

            while (lector0.Read())
            {
                id.Text = (lector0.GetInt32(0)).ToString();
            }

            conexion.Close();
            ubi.Text = "#" + incrementar() +" :";


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modificar.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            apebus.Visible = true;
            nombus.Visible = true;
            bus.Visible = false;
            fecbus.Visible = false;
            fecbus1.Visible = false;
            buttonbusq.Enabled = true;
            tipbus.Visible = false;
            button3.Enabled = false;

        }

        private void jefenom_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta3 = "select v.CI_Voluntario from Voluntario v where v.Apellidos = '" + jefe.Text + "' and v.Nombre ='" + jefenom.Text + "'";
            SqlCommand comando3 = new SqlCommand(consulta3, conexion);
            SqlDataReader lector3 = comando3.ExecuteReader();
            while (lector3.Read())
            {
                cj.Text = (lector3.GetInt32(0)).ToString();
            }
            conexion.Close();
            jefenom.Enabled = false;
        }

        private void jefe_Click(object sender, EventArgs e)
        {
            jefenom.Items.Clear();
            jefenom.Enabled = true;

        }

        private void buttonbusq_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                if (string.IsNullOrEmpty(bus.Text))
                {
                    MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    button3.Enabled = true;
                    conexion.Open();
                    string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información', COUNT(hm.ID_Misión) as Voluntarios, m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo'  from Misión m, Voluntario v, Provincias p, Tipo_mision tp, Historial_de_misiones hm where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión and m.ID_Misión = hm.ID_Misión and p.Nombre = '" + bus.Text+"' group by m.ID_Misión, p.Nombre, m.Municipio_y_lugar, m.Fecha , v.Apellidos , v.Nombre , tp.Tipo ,m.Informacion_de_la_misión, m.Casco,m.Blusa, m.Pantalon, m.Overol, m.Guantes, m.Antiparras,m.Botas, m.Machetes , m.McLoud , m.Pala_forestal, m.Gorgui, m.Mochila_bomba , m.Matafuego, m.Pulasky, m.Quemador_de_goteo, m.Kit_de_ataque_rápido, m.Lazo, m.Red_de_mano, m.Varilla_para_serpientes, m.Bastón_de_captura, m.Chaleco, m.Bolsa_de_tiro, m.Patas_de_rana, m.Visore, m.Cuerda_principal, m.Cuerda_auxiliar, m.Cuerda_utilitaria, m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho, m.Arnes, m.Casco_tactico, m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña, m.Botiquín_simple, m.Tabla_espinal, m.Camilla_táctica, m.Camilla_plegable, m.Chalecos_reflectivos, m.Linternas, m.Handy, m.Mochila,m.Conos_reflectivos, m.Cintas_de_delimitación, m.Vehiculo order by 1";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
                    conexion.Close();
                    button1.Enabled = false;

                }
            }
            else
            {
                if (radioButton3.Checked)
                {
                    if (string.IsNullOrEmpty(fec.Text))
                    {
                        MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        button3.Enabled = true;

                        conexion.Open();
                        string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información', COUNT(hm.ID_Misión) as Voluntarios, m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo'  from Misión m, Voluntario v, Provincias p, Tipo_mision tp, Historial_de_misiones hm where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión and m.ID_Misión = hm.ID_Misión and m.Fecha >= '" + fecbus.Value.ToString() + "' and m.Fecha <= '" + fecbus1.Value.ToString() + "' group by m.ID_Misión, p.Nombre, m.Municipio_y_lugar, m.Fecha , v.Apellidos , v.Nombre , tp.Tipo ,m.Informacion_de_la_misión, m.Casco,m.Blusa, m.Pantalon, m.Overol, m.Guantes, m.Antiparras,m.Botas, m.Machetes , m.McLoud , m.Pala_forestal, m.Gorgui, m.Mochila_bomba , m.Matafuego, m.Pulasky, m.Quemador_de_goteo, m.Kit_de_ataque_rápido, m.Lazo, m.Red_de_mano, m.Varilla_para_serpientes, m.Bastón_de_captura, m.Chaleco, m.Bolsa_de_tiro, m.Patas_de_rana, m.Visore, m.Cuerda_principal, m.Cuerda_auxiliar, m.Cuerda_utilitaria, m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho, m.Arnes, m.Casco_tactico, m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña, m.Botiquín_simple, m.Tabla_espinal, m.Camilla_táctica, m.Camilla_plegable, m.Chalecos_reflectivos, m.Linternas, m.Handy, m.Mochila,m.Conos_reflectivos, m.Cintas_de_delimitación, m.Vehiculo order by 1";
                        SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        dataGridView1.DataSource = dt;
                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        SqlDataReader lector;
                        lector = comando.ExecuteReader();
                        conexion.Close();
                        button1.Enabled = false;

                    }
                }
                else
                {
                    if (radioButton2.Checked)
                    {
                        if (string.IsNullOrEmpty(apebus.Text) || string.IsNullOrEmpty(nombus.Text))
                        {
                            MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            button3.Enabled = true;

                            conexion.Open();
                            string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información', COUNT(hm.ID_Misión) as Voluntarios, m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo'  from Misión m, Voluntario v, Provincias p, Tipo_mision tp, Historial_de_misiones hm where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión and m.ID_Misión = hm.ID_Misión and v.Apellidos='" + apebus.Text + "' and v.Nombre='" + nombus.Text + "' group by m.ID_Misión, p.Nombre, m.Municipio_y_lugar, m.Fecha , v.Apellidos , v.Nombre , tp.Tipo ,m.Informacion_de_la_misión, m.Casco,m.Blusa, m.Pantalon, m.Overol, m.Guantes, m.Antiparras,m.Botas, m.Machetes , m.McLoud , m.Pala_forestal, m.Gorgui, m.Mochila_bomba , m.Matafuego, m.Pulasky, m.Quemador_de_goteo, m.Kit_de_ataque_rápido, m.Lazo, m.Red_de_mano, m.Varilla_para_serpientes, m.Bastón_de_captura, m.Chaleco, m.Bolsa_de_tiro, m.Patas_de_rana, m.Visore, m.Cuerda_principal, m.Cuerda_auxiliar, m.Cuerda_utilitaria, m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho, m.Arnes, m.Casco_tactico, m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña, m.Botiquín_simple, m.Tabla_espinal, m.Camilla_táctica, m.Camilla_plegable, m.Chalecos_reflectivos, m.Linternas, m.Handy, m.Mochila,m.Conos_reflectivos, m.Cintas_de_delimitación, m.Vehiculo order by 1";
                            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            dataGridView1.DataSource = dt;
                            SqlCommand comando = new SqlCommand(consulta, conexion);
                            SqlDataReader lector;
                            lector = comando.ExecuteReader();
                            conexion.Close();
                            button1.Enabled = false;

                        }
                    }
                    else
                    {
                        if (radioButton6.Checked)
                        {
                            if (string.IsNullOrEmpty(tipbus.Text))
                            {
                                MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                button3.Enabled = true;

                                conexion.Open();
                                string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información', COUNT(hm.ID_Misión) as Voluntarios, m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo'  from Misión m, Voluntario v, Provincias p, Tipo_mision tp, Historial_de_misiones hm where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión and m.ID_Misión = hm.ID_Misión and tp.Tipo='" + tipbus.Text+"' group by m.ID_Misión, p.Nombre, m.Municipio_y_lugar, m.Fecha , v.Apellidos , v.Nombre , tp.Tipo ,m.Informacion_de_la_misión, m.Casco,m.Blusa, m.Pantalon, m.Overol, m.Guantes, m.Antiparras,m.Botas, m.Machetes , m.McLoud , m.Pala_forestal, m.Gorgui, m.Mochila_bomba , m.Matafuego, m.Pulasky, m.Quemador_de_goteo, m.Kit_de_ataque_rápido, m.Lazo, m.Red_de_mano, m.Varilla_para_serpientes, m.Bastón_de_captura, m.Chaleco, m.Bolsa_de_tiro, m.Patas_de_rana, m.Visore, m.Cuerda_principal, m.Cuerda_auxiliar, m.Cuerda_utilitaria, m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho, m.Arnes, m.Casco_tactico, m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña, m.Botiquín_simple, m.Tabla_espinal, m.Camilla_táctica, m.Camilla_plegable, m.Chalecos_reflectivos, m.Linternas, m.Handy, m.Mochila,m.Conos_reflectivos, m.Cintas_de_delimitación, m.Vehiculo order by 1";
                                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                                DataTable dt = new DataTable();
                                adaptador.Fill(dt);
                                dataGridView1.DataSource = dt;
                                SqlCommand comando = new SqlCommand(consulta, conexion);
                                SqlDataReader lector;
                                lector = comando.ExecuteReader();
                                conexion.Close();
                                button1.Enabled = false;

                            }
                        }
                    }
                }


            }
        }

        private void apebus_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta4 = "select v.Nombre from Voluntario v, Grados g where v.Apellidos = '" + apebus.Text + "' and g.ID_Grado=v.ID_Grado and (g.Categoría= 'Brigadiers' or g.Categoría='Oficiales' or g.Grado= 'Cadete Primero') order by 1";
            SqlCommand comando4 = new SqlCommand(consulta4, conexion);
            SqlDataReader lector4 = comando4.ExecuteReader();
            while (lector4.Read())
            {
                nombus.Items.Add(lector4.GetString(0));
            }
            conexion.Close();
        }

        private void nombus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apebus_Click(object sender, EventArgs e)
        {
            nombus.Items.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            apebus.Visible = false;
            nombus.Visible = false;
            bus.Visible = true;
            fecbus.Visible = false;
            fecbus1.Visible = false;
            button3.Enabled = false;
            buttonbusq.Enabled = true ;
            tipbus.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = false;
            apebus.Visible = false;
            nombus.Visible = false;
            fecbus.Visible = true;
            fecbus1.Visible = true;
            bus.Visible = false;
            buttonbusq.Enabled = true;
            tipbus.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información',  m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo' from Misión m, Voluntario v, Provincias p, Tipo_mision tp where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            button1.Enabled = true;
            button3.Enabled = false;
            buttonbusq.Enabled = false;
            tipbus.Visible = false;


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
            buttonbusq.Enabled = false;
            tipbus.Visible = false;
            string consultaa = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información', COUNT(hm.ID_Misión) as Voluntarios, m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo'  from Misión m, Voluntario v, Provincias p, Tipo_mision tp, Historial_de_misiones hm where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión and m.ID_Misión = hm.ID_Misión group by m.ID_Misión, p.Nombre, m.Municipio_y_lugar, m.Fecha , v.Apellidos , v.Nombre , tp.Tipo ,m.Informacion_de_la_misión, m.Casco,m.Blusa, m.Pantalon, m.Overol, m.Guantes, m.Antiparras,m.Botas, m.Machetes , m.McLoud , m.Pala_forestal, m.Gorgui, m.Mochila_bomba , m.Matafuego, m.Pulasky, m.Quemador_de_goteo, m.Kit_de_ataque_rápido, m.Lazo, m.Red_de_mano, m.Varilla_para_serpientes, m.Bastón_de_captura, m.Chaleco, m.Bolsa_de_tiro, m.Patas_de_rana, m.Visore, m.Cuerda_principal, m.Cuerda_auxiliar, m.Cuerda_utilitaria, m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho, m.Arnes, m.Casco_tactico, m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña, m.Botiquín_simple, m.Tabla_espinal, m.Camilla_táctica, m.Camilla_plegable, m.Chalecos_reflectivos, m.Linternas, m.Handy, m.Mochila,m.Conos_reflectivos, m.Cintas_de_delimitación, m.Vehiculo order by 1";
            SqlDataAdapter adaptadora = new SqlDataAdapter(consultaa, conexion);
            DataTable dta = new DataTable();
            adaptadora.Fill(dta);
            dataGridView1.DataSource = dta;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Archivos de Excel|*.xlsx|Archivos de Excel 97-2003|*.xls" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)

                    {
                        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))

                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))

                            {
                                var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()


                                    {
                                        UseHeaderRow = true

                                    }
                                });

                                dataGridView1.DataSource = dataSet.Tables[0];
                            }

                        }

                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Provincia";
                        dataGridView1.Columns[2].HeaderText = "Municipio y lugar";
                        dataGridView1.Columns[3].HeaderText = "Fecha de misión";
                        dataGridView1.Columns[4].HeaderText = "Apellidos del Jefe";
                        dataGridView1.Columns[5].HeaderText = "Nombre del Jefe";
                        dataGridView1.Columns[6].HeaderText = "Tipo de misión";
                        dataGridView1.Columns[7].HeaderText = "Información";
                        dataGridView1.Columns[8].HeaderText = "Voluntarios";




                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView1.AutoResizeColumns();
                        dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11);


                    }



                }

            }
        }
        private void ExportToExcel(DataGridView dataGridView)

        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            Excel.Workbook workbook = excelApp.Workbooks.Add();

            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            int columnCount = dataGridView.ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            int rowCount = dataGridView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            }

            string tempFile = System.IO.Path.GetTempFileName() + ".xls";
            workbook.SaveAs(tempFile);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = string.Format("Reporte_{0}.pdf", DateTime.Now.ToString("yyyyMMdd_HHmmss"));

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document pdfDoc = null;
                PdfWriter writer = null;

                try
                {
                    // Crear documento PDF
                    pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                    writer = PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    pdfDoc.Open();

                    // Agregar encabezado al PDF
                    Font headerFont = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    Paragraph header = new Paragraph("FUNDACIÓN GUARDIÁN", headerFont);
                    Paragraph header1 = new Paragraph("FUEGO, BÚSQUEDA Y RESCATE", new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK));

                    header.Alignment = Element.ALIGN_CENTER;
                    header1.Alignment = Element.ALIGN_CENTER;

                    pdfDoc.Add(header);
                    pdfDoc.Add(header1);
                    if (radioButton1.Checked)
                {
                    conexion.Open();
                    string consulta = "select  FORMAT(m.Fecha, 'dd/MM/yyyy') as 'Fecha',p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio', tp.Tipo , v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', COUNT(hm.ID_Misión) as Voluntarios from Misión m, Voluntario v, Provincias p, Historial_de_misiones hm, Tipo_mision tp where  m.ID_Misión = hm.ID_Misión and m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and p.Nombre = '" + bus.Text+"' and m.ID_Tipo_misión = tp.ID_Tipo_misión group by  p.Nombre, m.Municipio_y_lugar , m.Fecha , v.Apellidos , v.Nombre, tp.Tipo order by 3";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
                    conexion.Close();
                        // Agregar una nueva columna combinada "Jefe de Patrulla" al DataTable
                        dt.Columns.Add("Jefe de Patrulla", typeof(string));

                        // Llenar la nueva columna combinando "Apellido" y "Nombre"
                        foreach (DataRow row in dt.Rows)
                        {
                            row["Jefe de Patrulla"] = row["Apellido del Jefe de Patrulla"] + " " + row["Nombre del Jefe de Patrulla"];
                        }

                        // Eliminar las columnas "Apellidos" y "Nombre" originales
                        dt.Columns.Remove("Apellido del Jefe de Patrulla");
                        dt.Columns.Remove("Nombre del Jefe de Patrulla");

                        // Asignar el DataTable modificado al DataGridView
                        dataGridView1.DataSource = dt;

                        // Agregar información adicional
                        pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
                    pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
                    pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
                    pdfDoc.Add(new Paragraph("Tipo de reporte: Por provincia"));
                    pdfDoc.Add(new Paragraph("Misiones en la provincia: " + bus.Text));
                    pdfDoc.Add(new Paragraph("\n")); // Espacio
                }
                else
                {
                    if (radioButton2.Checked)
                    {
                        conexion.Open();
                        //select m.ID_Misión as ID, p.Nombre as Provincia, m.Ubicación_específica as 'Ubicación específica', m.Fecha as 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', COUNT(hm.ID_Misión)o v, Herramientas h, Provincias p, Historial_de_misiones hm where  m.ID_Misión=hm.ID_Misión and m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and h.ID_Herramientas = m.ID_Herramientas and v.Apellidos='" + apebus.Text + "' and v.Nombre='" + nombus.Text + "' group by  m.ID_Misión, p.Nombre, m.Ubicación_específica , m.Fecha , v.Apellidos , v.Nombre  , h.Descripción , m.Acerca_de_la_misión order by 3    //
                        string consulta = "select  FORMAT(m.Fecha, 'dd/MM/yyyy') as 'Fecha',p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio', tp.Tipo , v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', COUNT(hm.ID_Misión) as Voluntarios from Misión m, Voluntario v, Provincias p, Historial_de_misiones hm, Tipo_mision tp where  m.ID_Misión = hm.ID_Misión and m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe  and v.Apellidos='" + apebus.Text + "' and v.Nombre='" + nombus.Text + "' and m.ID_Tipo_misión = tp.ID_Tipo_misión group by  p.Nombre, m.Municipio_y_lugar , m.Fecha , v.Apellidos , v.Nombre, tp.Tipo order by 3";
                        SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        dataGridView1.DataSource = dt;
                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        SqlDataReader lector;
                        lector = comando.ExecuteReader();
                        conexion.Close();
                            // Agregar una nueva columna combinada "Jefe de Patrulla" al DataTable
                            dt.Columns.Add("Jefe de Patrulla", typeof(string));

                            // Llenar la nueva columna combinando "Apellido" y "Nombre"
                            foreach (DataRow row in dt.Rows)
                            {
                                row["Jefe de Patrulla"] = row["Apellido del Jefe de Patrulla"] + " " + row["Nombre del Jefe de Patrulla"];
                            }

                            // Eliminar las columnas "Apellidos" y "Nombre" originales
                            dt.Columns.Remove("Apellido del Jefe de Patrulla");
                            dt.Columns.Remove("Nombre del Jefe de Patrulla");

                            // Asignar el DataTable modificado al DataGridView
                            dataGridView1.DataSource = dt;
                            pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
                        pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
                        pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
                        pdfDoc.Add(new Paragraph("Tipo de reporte: Por Jefe de Patrulla"));
                        pdfDoc.Add(new Paragraph("Voluntario: " + apebus.Text + " " + nombus.Text + " como Jefe de Patrulla"));
                        pdfDoc.Add(new Paragraph("\n")); // Espacio
                    }
                    else
                    {
                        if (radioButton3.Checked)
                        {
                            conexion.Open();
                             string consulta = "select m.ID_Misión as 'Nro. de misión', tp.Tipo as 'Tipo de misión', m.Municipio_y_lugar as 'Municipio', FORMAT(m.Fecha, 'dd/MM/yyyy') as 'Fecha', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', COUNT(hm.ID_Misión) as Voluntarios from Misión m, Voluntario v, Provincias p, Historial_de_misiones hm, Tipo_mision tp where  m.ID_Misión = hm.ID_Misión and m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión group by  m.ID_Misión, tp.Tipo, m.Municipio_y_lugar , m.Fecha , v.Apellidos , v.Nombre order by 1 ";
                            //select m.ID_Misión as ID, p.Nombre as Provincia, m.Ubicación_específica as 'Ubicación específica', m.Fecha as 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', COUNT(hm.ID_Misión) as Bomberos, h.Descripción as Herramientas, m.Acerca_de_la_misión as 'Acerca de la misión' from Misión m, Voluntario v, Herramientas h, Provincias p, Historial_de_misiones hm where  m.ID_Misión=hm.ID_Misión and m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and h.ID_Herramientas = m.ID_Herramientas and m.Fecha >= '" + fecbus.Value.ToString()+ "' and m.Fecha <= '" + fecbus1.Value.ToString() + "' group by  m.ID_Misión, p.Nombre, m.Ubicación_específica , m.Fecha , v.Apellidos , v.Nombre  , h.Descripción , m.Acerca_de_la_misión order by 3 //
                            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            dataGridView1.DataSource = dt;
                            SqlCommand comando = new SqlCommand(consulta, conexion);
                            SqlDataReader lector;
                            lector = comando.ExecuteReader();
                            conexion.Close();
                                // Agregar una nueva columna combinada "Jefe de Patrulla" al DataTable
                                dt.Columns.Add("Jefe de Patrulla", typeof(string));

                                // Llenar la nueva columna combinando "Apellido" y "Nombre"
                                foreach (DataRow row in dt.Rows)
                                {
                                    row["Jefe de Patrulla"] = row["Apellido del Jefe de Patrulla"] + " " + row["Nombre del Jefe de Patrulla"];
                                }

                                // Eliminar las columnas "Apellidos" y "Nombre" originales
                                dt.Columns.Remove("Apellido del Jefe de Patrulla");
                                dt.Columns.Remove("Nombre del Jefe de Patrulla");

                                // Asignar el DataTable modificado al DataGridView
                                dataGridView1.DataSource = dt;
                                pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
                            pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
                            pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
                            pdfDoc.Add(new Paragraph("Tipo de reporte: Por fechas"));
                            pdfDoc.Add(new Paragraph("Desde el " + fecbus.Value.ToString("dd/MM/yyyy") + " hasta el " + fecbus1.Value.ToString("dd/MM/yyyy")));
                            pdfDoc.Add(new Paragraph("\n")); // Espacio
                        }
                        else
                        {
                            if (radioButton4.Checked)
                            {
                                conexion.Open();
                                string consulta = "select  p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio', FORMAT(m.Fecha, 'dd/MM/yyyy') as 'Fecha', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', COUNT(hm.ID_Misión) as Voluntarios from Misión m, Voluntario v, Provincias p, Historial_de_misiones hm where  m.ID_Misión=hm.ID_Misión and m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe group by   p.Nombre, m.Municipio_y_lugar , m.Fecha , v.Apellidos , v.Nombre order by 2";
                                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                                DataTable dt = new DataTable();
                                adaptador.Fill(dt);
                                dataGridView1.DataSource = dt;
                                SqlCommand comando = new SqlCommand(consulta, conexion);
                                SqlDataReader lector;
                                lector = comando.ExecuteReader();
                                conexion.Close();
                                    // Agregar una nueva columna combinada "Jefe de Patrulla" al DataTable
                                    dt.Columns.Add("Jefe de Patrulla", typeof(string));

                                    // Llenar la nueva columna combinando "Apellido" y "Nombre"
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        row["Jefe de Patrulla"] = row["Apellido del Jefe de Patrulla"] + " " + row["Nombre del Jefe de Patrulla"];
                                    }

                                    // Eliminar las columnas "Apellidos" y "Nombre" originales
                                    dt.Columns.Remove("Apellido del Jefe de Patrulla");
                                    dt.Columns.Remove("Nombre del Jefe de Patrulla");

                                    // Asignar el DataTable modificado al DataGridView
                                    dataGridView1.DataSource = dt;
                                    pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
                                pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
                                pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
                                pdfDoc.Add(new Paragraph("Tipo de reporte: General"));
                                pdfDoc.Add(new Paragraph("\n")); // Espacio
                            }
                            else
                            {
                                if (radioButton6.Checked)
                                {
                                    conexion.Open();
                                    string consulta = "select  FORMAT(m.Fecha, 'dd/MM/yyyy') as 'Fecha',p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio', tp.Tipo , v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', COUNT(hm.ID_Misión) as Voluntarios from Misión m, Voluntario v, Provincias p, Historial_de_misiones hm, Tipo_mision tp where  m.ID_Misión = hm.ID_Misión and m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.Tipo='"+tipbus.Text+"' and m.ID_Tipo_misión = tp.ID_Tipo_misión group by  p.Nombre, m.Municipio_y_lugar , m.Fecha , v.Apellidos , v.Nombre, tp.Tipo order by 3";
                                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                                    DataTable dt = new DataTable();
                                    adaptador.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                    SqlCommand comando = new SqlCommand(consulta, conexion);
                                    SqlDataReader lector;
                                    lector = comando.ExecuteReader();
                                    conexion.Close();
                                        // Agregar una nueva columna combinada "Jefe de Patrulla" al DataTable
                        dt.Columns.Add("Jefe de Patrulla", typeof(string));

                        // Llenar la nueva columna combinando "Apellido" y "Nombre"
                        foreach (DataRow row in dt.Rows)
                        {
                            row["Jefe de Patrulla"] = row["Apellido del Jefe de Patrulla"] + " " + row["Nombre del Jefe de Patrulla"];
                        }

                        // Eliminar las columnas "Apellidos" y "Nombre" originales
                        dt.Columns.Remove("Apellido del Jefe de Patrulla");
                        dt.Columns.Remove("Nombre del Jefe de Patrulla");

                        // Asignar el DataTable modificado al DataGridView
                        dataGridView1.DataSource = dt;
                                    pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
                                    pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
                                    pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
                                    pdfDoc.Add(new Paragraph("Tipo de reporte: Por clasificación"));
                                    pdfDoc.Add(new Paragraph("Misiones de tipo: " + tipbus.Text));
                                    pdfDoc.Add(new Paragraph("\n")); // Espacio
                                }
                            }
                        }
                    }
                }



                    // Crear tabla para el DataGridView
                    // Crear tabla para el DataGridView
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                    // Configurar anchos de columna
                    float[] widths = new float[dataGridView1.Columns.Count];
                    Font cellFont = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        string columnName = dataGridView1.Columns[i].HeaderText;

                        if (columnName == "Voluntarios")
                        {
                            widths[i] = 100f;
                        }
                        else if (columnName == "Fecha")
                        {
                            widths[i] = 100f;
                        }
                        else
                        {
                            string longestCellValue = GetLongestCellValue(dataGridView1, i);
                            widths[i] = Math.Max(GetTextWidth(columnName, cellFont), GetTextWidth(longestCellValue, cellFont));
                        }
                    }

                    pdfTable.SetWidths(widths);

                    // Agregar encabezados de columna
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, cellFont));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(cell);
                    }

                    // Agregar filas del DataGridView al PDF
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value != null ? cell.Value.ToString() : "", cellFont));
                                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                pdfTable.AddCell(pdfCell);
                            }
                        }
                    }
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LOGO_FG_rediseño_008, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);
                    // Agregar tabla al documento
                    pdfDoc.Add(pdfTable);

                    MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (pdfDoc != null && pdfDoc.IsOpen())
                    {
                        pdfDoc.Close();
                    }

                    if (writer != null)
                    {
                        writer.Close();
                    }
                }
            }
        }

        // Obtener el ancho máximo del texto en una columna
        private string GetLongestCellValue(DataGridView gridView, int columnIndex)
        {
            string longest = "";

            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string cellValue = row.Cells[columnIndex].Value?.ToString() ?? "";
                    if (cellValue.Length > longest.Length)
                    {
                        longest = cellValue;
                    }
                }
            }

            return longest;
        }

        private float GetTextWidth(string text, Font font)
        {
            BaseFont baseFont = font.GetCalculatedBaseFont(false);
            return baseFont.GetWidthPoint(text, font.Size);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HerMision Obj = new HerMision();
            Obj.ShowDialog();
        }

        private void tipmis_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta3 = "select tp.ID_Tipo_misión from Tipo_mision tp where tp.Tipo = '" + tipmis.Text + "'";
            SqlCommand comando3 = new SqlCommand(consulta3, conexion);
            SqlDataReader lector3 = comando3.ExecuteReader();
            while (lector3.Read())
            {
                tip.Text = (lector3.GetInt32(0)).ToString();
            }
            conexion.Close();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = false;
            apebus.Visible = false;
            nombus.Visible = false;
            fecbus.Visible =false;
            fecbus1.Visible = false;
            bus.Visible = false;
            buttonbusq.Enabled = true;
            tipbus.Visible = true;
        }

        private void bus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    


