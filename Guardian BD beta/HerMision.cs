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
    public partial class HerMision : Form
    {
        public HerMision()
        {
            InitializeComponent();
        }
        CValidacionM objV = new CValidacionM();
        SqlConnection conexion = ConexionGuardianBD.ObtConexion();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HerMision_Load(object sender, EventArgs e)
        {
            string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información',  m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo' from Misión m, Voluntario v, Provincias p, Tipo_mision tp where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv.DataSource = dt;

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
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modificar.Enabled = true;
            try
            {
                id.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                cas.Value = Convert.ToInt32(dgv.CurrentRow.Cells[8].Value);
                blu.Value = Convert.ToInt32(dgv.CurrentRow.Cells[9].Value);
                pan.Value = Convert.ToInt32(dgv.CurrentRow.Cells[10].Value);
                ove.Value = Convert.ToInt32(dgv.CurrentRow.Cells[11].Value);
                par.Value = Convert.ToInt32(dgv.CurrentRow.Cells[12].Value);
                ant.Value = Convert.ToInt32(dgv.CurrentRow.Cells[13].Value);
                bot.Value = Convert.ToInt32(dgv.CurrentRow.Cells[14].Value);
                mac.Value = Convert.ToInt32(dgv.CurrentRow.Cells[15].Value);
                mcl.Value = Convert.ToInt32(dgv.CurrentRow.Cells[16].Value);
                pal.Value = Convert.ToInt32(dgv.CurrentRow.Cells[17].Value);
                gor.Value = Convert.ToInt32(dgv.CurrentRow.Cells[18].Value);
                moc.Value = Convert.ToInt32(dgv.CurrentRow.Cells[19].Value);
                mat.Value = Convert.ToInt32(dgv.CurrentRow.Cells[20].Value);
                pul.Value = Convert.ToInt32(dgv.CurrentRow.Cells[21].Value);
                que.Value = Convert.ToInt32(dgv.CurrentRow.Cells[22].Value);
                kit.Value = Convert.ToInt32(dgv.CurrentRow.Cells[23].Value);
                laz.Value = Convert.ToInt32(dgv.CurrentRow.Cells[24].Value);
                red.Value = Convert.ToInt32(dgv.CurrentRow.Cells[25].Value);
                var.Value = Convert.ToInt32(dgv.CurrentRow.Cells[26].Value);
                bas.Value = Convert.ToInt32(dgv.CurrentRow.Cells[27].Value);
                cha.Value = Convert.ToInt32(dgv.CurrentRow.Cells[28].Value);
                bol.Value = Convert.ToInt32(dgv.CurrentRow.Cells[29].Value);
                pat.Value = Convert.ToInt32(dgv.CurrentRow.Cells[30].Value);
                vis.Value = Convert.ToInt32(dgv.CurrentRow.Cells[31].Value);
                cuep.Value = Convert.ToInt32(dgv.CurrentRow.Cells[32].Value);
                cuea.Value = Convert.ToInt32(dgv.CurrentRow.Cells[33].Value);
                cueu.Value = Convert.ToInt32(dgv.CurrentRow.Cells[34].Value);
                cor.Value = Convert.ToInt32(dgv.CurrentRow.Cells[35].Value);
                cin.Value = Convert.ToInt32(dgv.CurrentRow.Cells[36].Value);
                mos.Value = Convert.ToInt32(dgv.CurrentRow.Cells[37].Value);
                ocho.Value = Convert.ToInt32(dgv.CurrentRow.Cells[38].Value);
                arn.Value = Convert.ToInt32(dgv.CurrentRow.Cells[39].Value);
                castac.Value = Convert.ToInt32(dgv.CurrentRow.Cells[40].Value);
                gri.Value = Convert.ToInt32(dgv.CurrentRow.Cells[41].Value);
                rol.Value = Convert.ToInt32(dgv.CurrentRow.Cells[42].Value);
                asc.Value = Convert.ToInt32(dgv.CurrentRow.Cells[43].Value);
                cort.Value = Convert.ToInt32(dgv.CurrentRow.Cells[44].Value);
                botcaph.Value = Convert.ToInt32(dgv.CurrentRow.Cells[45].Value);
                botsaph.Value = Convert.ToInt32(dgv.CurrentRow.Cells[46].Value);
                tabahp.Value = Convert.ToInt32(dgv.CurrentRow.Cells[47].Value);
                camtaph.Value = Convert.ToInt32(dgv.CurrentRow.Cells[48].Value);
                campaph.Value = Convert.ToInt32(dgv.CurrentRow.Cells[49].Value);
                chabr.Value = Convert.ToInt32(dgv.CurrentRow.Cells[50].Value);
                linbr.Value = Convert.ToInt32(dgv.CurrentRow.Cells[51].Value);
                handy.Value = Convert.ToInt32(dgv.CurrentRow.Cells[52].Value);
                mochila.Value = Convert.ToInt32(dgv.CurrentRow.Cells[53].Value);
                Cono.Value = Convert.ToInt32(dgv.CurrentRow.Cells[54].Value);
                cintaseg.Value = Convert.ToInt32(dgv.CurrentRow.Cells[55].Value);
                veh.Value = Convert.ToInt32(dgv.CurrentRow.Cells[56].Value);

            }
            catch { }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consultaa = "UPDATE Misión SET Casco = '" + cas.Text + "', Blusa = '" + blu.Text + "', Pantalon = '" + pan.Text + "', Overol = '" + ove.Text + "', Guantes = '" + par.Text + "', Antiparras = '" + ant.Text + "', Botas = '" + bot.Text + "', Machetes = '" + mac.Text + "', McLoud = '" + mcl.Text + "', Pala_forestal = '" + pal.Text + "', Gorgui = '" + gor.Text + "', Mochila_bomba = '" + moc.Text + "', Matafuego = '" + mat.Text + "', Pulasky = '" + pul.Text + "', Quemador_de_goteo = '" + que.Text + "', Kit_de_ataque_rápido = '" + kit.Text + "', Lazo = '" + laz.Text + "', Red_de_mano = '" + red.Text + "', Varilla_para_serpientes = '" + var.Text + "', Bastón_de_captura = '" + bas.Text + "', Chaleco = '" + cha.Text + "', Bolsa_de_tiro = '" + bol.Text + "', Patas_de_rana = '" + pat.Text + "', Visore = '" + vis.Text + "', Cuerda_principal = '" + cuep.Text + "', Cuerda_auxiliar = '" + cuea.Text + "', Cuerda_utilitaria = '" + cueu.Text + "', Cordino = '" + cor.Text + "', Cinta = '" + cin.Text + "', Mosquetón = '" + mos.Text + "', Descensor_ocho = '" + ocho.Text + "', Arnes = '" + arn.Text + "', Casco_tactico = '" + castac.Text + "', Grigri = '" + gri.Text + "', Roldanas = '" + rol.Text + "', Ascender = '" + asc.Text + "', Cortafilo = '" + cort.Text + "', Botiquín_de_campaña = '" + botcaph.Text + "', Botiquín_simple = '" + botsaph.Text + "', Tabla_espinal = '" + tabahp.Text + "', Camilla_táctica = '" + camtaph.Text + "', Camilla_plegable = '" + campaph.Text + "', Chalecos_reflectivos = '" + chabr.Text + "', Linternas = '" + linbr.Text + "', Handy = '" + handy.Text + "', Mochila = '" + mochila.Text + "', Conos_reflectivos = '" + Cono.Text + "', Cintas_de_delimitación = '" + cintaseg.Text + "', Vehiculo = '" + veh.Text + "' WHERE ID_Misión = '" + id.Text + "'";
            SqlCommand comandoa = new SqlCommand(consultaa, conexion);
            int cant;
            cant = comandoa.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Registro modificado");
            }
            conexion.Close();

            string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información',  m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo' from Misión m, Voluntario v, Provincias p, Tipo_mision tp where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv.DataSource = dt;
            modificar.Enabled = false;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            string consulta = "select m.ID_Misión as ID, p.Nombre as Provincia, m.Municipio_y_lugar as 'Municipio y lugar', m.Fecha 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', tp.Tipo as 'Tipo de misión', m.Informacion_de_la_misión as 'Información',  m.Casco,m.Blusa, m.Pantalon as 'Pantalón', m.Overol, m.Guantes as 'Par de guantes', m.Antiparras, m.Botas as 'Par de botas', m.Machetes as 'Machete', m.McLoud as 'Mcleoud', m.Pala_forestal as 'Pala forestal', m.Gorgui, m.Mochila_bomba as 'Mochila bomba', m.Matafuego, m.Pulasky, m.Quemador_de_goteo as 'Quemador de goteo', m.Kit_de_ataque_rápido as 'Kit de atque rápido', m.Lazo, m.Red_de_mano as 'Red de mano', m.Varilla_para_serpientes as 'Varilla para serpientes', m.Bastón_de_captura as 'Bastón de captura', m.Chaleco, m.Bolsa_de_tiro as 'Bolsa de tiro', m.Patas_de_rana as 'Patas de rana (par)', m.Visore as 'Visor', m.Cuerda_principal as 'Cuerda principal', m.Cuerda_auxiliar as 'Cuerda auxiliar', m.Cuerda_utilitaria as 'Cuerda utilitaria', m.Cordino, m.Cinta, m.Mosquetón, m.Descensor_ocho as 'Descensor ocho', m.Arnes, m.Casco_tactico as 'Casco táctico', m.Grigri, m.Roldanas, m.Ascender, m.Cortafilo, m.Botiquín_de_campaña as 'Botiquín de campaña', m.Botiquín_simple as 'Botiquín simple', m.Tabla_espinal as 'Tabla espinal', m.Camilla_táctica as 'Camilla táctica', m.Camilla_plegable as 'Camilla plegable', m.Chalecos_reflectivos as 'Chaleco reflectivo', m.Linternas as 'Linterna', m.Handy, m.Mochila,m.Conos_reflectivos as 'Conos reflectivos', m.Cintas_de_delimitación as 'Cinta de delimitación', m.Vehiculo as 'Vehículo' from Misión m, Voluntario v, Provincias p, Tipo_mision tp where m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and tp.ID_Tipo_misión = m.ID_Tipo_misión";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv.DataSource = dt;

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
            cas.Value = 0;
            blu.Value = 0;
            pan.Value = 0;
            ove.Value = 0;
            par.Value = 0;
            ant.Value = 0;
            bot.Value = 0;
            mac.Value = 0;
            mcl.Value = 0;
            pal.Value = 0;
            gor.Value = 0;
            moc.Value = 0;
            mat.Value = 0;
            pul.Value = 0;
            que.Value = 0;
            kit.Value = 0;
            laz.Value = 0;
            red.Value = 0;
            var.Value = 0;
            bas.Value = 0;
            cha.Value = 0;
            bol.Value = 0;
            pat.Value = 0;
            vis.Value = 0;
            cuep.Value = 0;
            cuea.Value = 0;
            cueu.Value = 0;
            cor.Value = 0;
            cin.Value = 0;
            mos.Value = 0;
            ocho.Value = 0;
            arn.Value = 0;
            castac.Value = 0;
            gri.Value = 0;
            rol.Value = 0;
            asc.Value = 0;
            cort.Value = 0;
            botcaph.Value = 0;
            botsaph.Value = 0;
            tabahp.Value = 0;
            camtaph.Value = 0;
            campaph.Value = 0;
            chabr.Value = 0;
            linbr.Value = 0;
            handy.Value = 0;
            mochila.Value = 0;
            Cono.Value = 0;
            cintaseg.Value = 0;
            veh.Value = 0;
            modificar.Enabled = true;

        }
    }
}
