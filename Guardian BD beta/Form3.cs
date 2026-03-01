using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using draw=System.Drawing;
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
    public partial class Form3 : Form
    {
        string Usuario;
        string tipo;
        public Form3(string usu, string tip)
        {
            InitializeComponent();
            Usuario = usu;
            tipo = tip;
        }
        CValidacion objV = new CValidacion();
        CValidacionV objM = new CValidacionV();

        SqlConnection conexion = ConexionGuardianBD.ObtConexion();


        private void Form3_Load(object sender, EventArgs e)
        {
            Usu3.Text = tipo.ToUpper() + ": " + Usuario.ToUpper();
      if (tipo == "Administrador")
      {
        agregar.Visible = true;
        modificar.Visible = true;
        clear.Visible = true;
        label14.Visible = true;

      }
      else
      {
        agregar.Visible = false;
        modificar.Visible = false;
        clear.Visible = false;
        label14.Visible = false;


      }
      if (radioButton7.Checked)
            {

                string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v order by 1, 4";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                if (radioButton8.Checked)
                {
                    string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v where v.Estado='Activo' order by 1,4";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    if (radioButton6.Checked)
                    {
                        string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v where v.Estado='Inactivo' order by 1,4";
                        SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        if (radioButton5.Checked)
                        {
                            string consulta = "select v.Antiguedad as 'Nro', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Estado, count(hm.CI_Voluntario) as Misiones from Voluntario v, Historial_de_misiones hm where v.CI_Voluntario = hm.CI_Voluntario group by v.Antiguedad,v.CI_Voluntario, v.ID_Grado, v.Apellidos, v.Nombre, v.Estado order by 1,4";
                            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            dataGridView1.DataSource = dt;
                            button1.Enabled = false;
                        }
                    }
                }
            }

            string consulta0 = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado";
            SqlDataAdapter adaptador0 = new SqlDataAdapter(consulta0, conexion);
            DataTable dt0 = new DataTable();
            adaptador0.Fill(dt0);
            dataGridView2.DataSource = dt0;

            conexion.Open();
            string consulta1 = "select * from Grados ";
            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
            SqlDataReader lector1 = comando1.ExecuteReader();

            while (lector1.Read())
            {
                grado.Items.Add(lector1.GetString(0));
            }
            conexion.Close();
            conexion.Open();
            string consulta2 = "select * from Cargo ";
            SqlCommand comando2 = new SqlCommand(consulta2, conexion);
            SqlDataReader lector2 = comando2.ExecuteReader();

            while (lector2.Read())
            {
                cargo.Items.Add(lector2.GetString(0));
            }
            conexion.Close();

            conexion.Open();
            string consulta1a = "select * from Grados ";
            SqlCommand comando1a = new SqlCommand(consulta1a, conexion);
            SqlDataReader lector1a = comando1a.ExecuteReader();

            while (lector1a.Read())
            {
                grabus.Items.Add(lector1a.GetString(1));
            }
            conexion.Close();

            conexion.Open();
            string consulta2a = "select * from Cargo ";
            SqlCommand comando2a = new SqlCommand(consulta2a, conexion);
            SqlDataReader lector2a = comando2a.ExecuteReader();

            while (lector2a.Read())
            {
                carbus.Items.Add(lector2a.GetString(1));
            }
            conexion.Close();
        }



        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Obj = new Form2(Usuario, tipo);
            Obj.ShowDialog();

        }
        public string sexo()
        {
            if (mas.Checked)
                return mas.Text;
            else
                return fem.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
        public string actividad_vol()
        {
            if (act.Checked)
            {
                inact.Enabled = true;
                return act.Text;
            }
            else
                return inact.Text;

        }



        public void insertar()
        {

            conexion.Open();
            string consulta = "insert into Voluntario values('" + nro.Text + "','" + ci.Text + "','" + grado.Text + "','" + nombre.Text + "','" + apellidos.Text + "','" + (fecha_nac.Value.Date).ToString()+ "','" + sexo() + "','" + san.Text + "','" + actividad_vol() + "','" + celu.Text + "','" + correo.Text + "','" + num.Text + "','" + cargo.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se registró con éxito");

            conexion.Close();

            ci.Clear();
            nombre.Clear();
            apellidos.Clear();
            celu.Clear();
            correo.Clear();
            num.Clear();
            grado.SelectedIndex = -1;
            cargo.SelectedIndex = -1;
            san.SelectedIndex = -1;

            string consulta1 = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v order by 1, 4";
            SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
            DataTable dt = new DataTable();
            adaptador1.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        public void agregar_Click(object sender, EventArgs e)
        {
            if (objV.datosok(Error, nro, fecha_nac, grado, cargo, san, ci, celu, num, nombre, apellidos, correo, dataGridView1))
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea agregar al voluntario? Si tiene dudas antes de agregar revise bien los datos, una vez registrado solo podrá modificar los datos pero no borrarlos.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    insertar();
                }
                else return;
            }
        }





        private void grado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ci_TextChanged(object sender, EventArgs e)
        {

        }

        private void ci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                grado.Focus();

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                apellidos.Focus();
        }

        private void celu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                correo.Focus();
        }

        private void correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                num.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void grado_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            ci.Clear();
            ci.Enabled = true;
            nro.Value = 0;
            nro.Enabled = true;
            grado.SelectedIndex = -1;
            grado.Enabled = true;
            nombre.Clear();
            nombre.Enabled = true;
            apellidos.Clear();
            apellidos.Enabled = true;
            san.SelectedIndex = -1;
            san.Enabled = true;
            celu.Clear();
            celu.Enabled = true;
            correo.Clear();
            correo.Enabled = true;
            num.Clear();
            num.Enabled = true;
            cargo.SelectedIndex = -1;
            cargo.Enabled = true;
            agregar.Enabled = true;
            modificar.Enabled = false;
            buscar.Clear();
            radioButton7.Checked = true;
            inact.Enabled = false;
            button1.Enabled = true;
            pdf.Enabled = false;
            nro.Value = 0;
            carbus.Visible = false;
            grabus.Visible = false;
            sanbus.Visible = false;
            buscar.Visible = true;
            radioButton1.Checked = true;
            string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v order by 1, 4";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            agregar.Enabled = false;
            inact.Enabled = true;
            string sex;
            string est;
            ci.Enabled = false;
            try
            {
                nro.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                ci.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                grado.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                apellidos.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                nombre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                fecha_nac.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                san.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                celu.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                num.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                correo.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                cargo.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                sex = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                est = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                if (sex == "Masculino")
                {
                    mas.Checked = true;

                }
                else { fem.Checked = true; }
                if (est == "Activo")
                {
                    act.Checked = true;

                }
                else { inact.Checked = true; }

            }
            catch { }
        }

        private void borrar_Click(object sender, EventArgs e)
        {

        }

        private void act_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (objM.datosok(Error, fecha_nac, grado, cargo, san, ci, celu, num, nombre, apellidos, correo, dataGridView1, dataGridView2))
            {

                conexion.Open();
                string consulta = "update Voluntario set  Antiguedad='" + nro.Text + "', ID_Grado='" + grado.Text + "', Nombre ='" + nombre.Text + "', Apellidos='" + apellidos.Text + "', Fecha_de_nacimiento='" + (fecha_nac.Value.Date).ToString() + "', Sexo='" + sexo() + "', Grupo_sanguíneo = '" + san.Text + "', Estado ='" + actividad_vol() + "', Celular='" + celu.Text + "', Email='" + correo.Text + "', Número_de_emergencia='" + num.Text + "', ID_Cargo='" + cargo.Text + "' where CI_Voluntario = '" + ci.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant > 0)
                {
                    MessageBox.Show("Registro modificado");
                }
                conexion.Close();

                string consulta1 = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v order by 1, 4";
                SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
                DataTable dt1 = new DataTable();
                adaptador1.Fill(dt1);
                dataGridView1.DataSource = dt1;

                
                agregar.Enabled = true;
                ci.Clear();
                nombre.Clear();
                apellidos.Clear();
                celu.Clear();
                correo.Clear();
                num.Clear();
                grado.SelectedIndex = -1;
                cargo.SelectedIndex = -1;
                san.SelectedIndex = -1;
                inact.Enabled = false;
                modificar.Enabled = false;
                
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            ci.Clear();
            ci.Enabled = true;
            nro.Value = 0;
            nro.Enabled = true;
            grado.SelectedIndex = -1;
            grado.Enabled = true;
            nombre.Clear();
            nombre.Enabled = true;
            apellidos.Clear();
            apellidos.Enabled = true;
            san.SelectedIndex = -1;
            san.Enabled = true;
            celu.Clear();
            celu.Enabled = true;
            correo.Clear();
            correo.Enabled = true;
            num.Clear();
            num.Enabled = true;
            cargo.SelectedIndex = -1;
            cargo.Enabled = true;
            agregar.Enabled = true;
            modificar.Enabled = false;
            buscar.Clear();
            radioButton7.Checked = true;
            inact.Enabled = false;
            button1.Enabled = true;
            pdf.Enabled = false;
            carbus.Visible = false;
            grabus.Visible = false;
            sanbus.Visible = false;
            buscar.Visible = true;
            radioButton1.Checked = true;

            string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v order by 1, 4";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton7.Checked)
                modificar.Enabled = true;
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                if (string.IsNullOrEmpty(buscar.Text))
                {
                    MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    pdf.Enabled = false;

                    conexion.Open();
                    string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v where CI_Voluntario= " + buscar.Text + " order by 1,4";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
                    conexion.Close();
                }
            }
            else
            {
                if (radioButton2.Checked)
                {
                    if (string.IsNullOrEmpty(grabus.Text))
                    {
                        MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        pdf.Enabled = false;

                        conexion.Open();
                        string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v, Grados g where g.ID_Grado=v.ID_Grado and g.Grado= '" + grabus.Text + "'order by 1,4";
                        SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        dataGridView1.DataSource = dt;
                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        SqlDataReader lector;
                        lector = comando.ExecuteReader();
                        conexion.Close();
                    }
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        if (string.IsNullOrEmpty(sanbus.Text))
                        {
                            MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            pdf.Enabled = false;

                            conexion.Open();
                            string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v where Grupo_sanguíneo='" + sanbus.Text + "'order by 1,4";
                            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            dataGridView1.DataSource = dt;
                            SqlCommand comando = new SqlCommand(consulta, conexion);
                            SqlDataReader lector;
                            lector = comando.ExecuteReader();
                            conexion.Close();
                        }
                    }
                    else
                    {
                        if (radioButton4.Checked)
                        {
                            if (string.IsNullOrEmpty(carbus.Text))
                            {
                                MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                pdf.Enabled = false;
                                conexion.Open();
                                string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v, Cargo c where c.ID_Cargo=v.ID_Cargo and c.Nombre='" + carbus.Text + "'order by 1,4";
                                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                                DataTable dt = new DataTable();
                                adaptador.Fill(dt);
                                dataGridView1.DataSource = dt;
                                SqlCommand comando = new SqlCommand(consulta, conexion);
                                SqlDataReader lector;
                                lector = comando.ExecuteReader();
                                conexion.Close();
                            }
                        }
                    }
                }

            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ci.Clear();
            ci.Enabled = true;
            grado.SelectedIndex = -1;
            grado.Enabled = true;
            nombre.Clear();
            nombre.Enabled = true;
            apellidos.Clear();
            apellidos.Enabled = true;
            san.SelectedIndex = -1;
            san.Enabled = true;
            celu.Clear();
            celu.Enabled = true;
            correo.Clear();
            correo.Enabled = true;
            num.Clear();
            num.Enabled = true;
            cargo.SelectedIndex = -1;
            cargo.Enabled = true;
            agregar.Enabled = true;
            modificar.Enabled = true;
            button1.Enabled = true;

            string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v where v.Estado='Activo' order by 1,4";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            pdf.Enabled = false;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ci.Clear();
            ci.Enabled = true;
            grado.SelectedIndex = -1;
            grado.Enabled = true;
            nombre.Clear();
            nombre.Enabled = true;
            apellidos.Clear();
            apellidos.Enabled = true;
            san.SelectedIndex = -1;
            san.Enabled = true;
            celu.Clear();
            celu.Enabled = true;
            correo.Clear();
            correo.Enabled = true;
            num.Clear();
            num.Enabled = true;
            cargo.SelectedIndex = -1;
            cargo.Enabled = true;
            agregar.Enabled = true;
            modificar.Enabled = true;
            modificar.Enabled = false;
            agregar.Enabled = false;
            button1.Enabled = true;
            pdf.Enabled = false;

            string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v where v.Estado='Inactivo' order by 1,4";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ci.Clear();
            ci.Enabled = false;
            grado.SelectedIndex = -1;
            grado.Enabled = false;
            nombre.Clear();
            nombre.Enabled = false;
            apellidos.Clear();
            apellidos.Enabled = false;
            san.SelectedIndex = -1;
            san.Enabled = false;
            celu.Clear();
            celu.Enabled = false;
            correo.Clear();
            correo.Enabled = false;
            num.Clear();
            num.Enabled = false;
            cargo.SelectedIndex = -1;
            cargo.Enabled = false;
            agregar.Enabled = false;
            modificar.Enabled = false;
            button1.Enabled = false;
            pdf.Enabled = true;
            string consulta = "select v.Antiguedad as 'Nro', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Estado, count(hm.CI_Voluntario) as Misiones from Voluntario v, Historial_de_misiones hm where v.CI_Voluntario = hm.CI_Voluntario and v.Estado='Activo' group by v.Antiguedad,v.CI_Voluntario, v.ID_Grado, v.Apellidos, v.Nombre, v.Estado order by 1,4";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ci.Clear();
            ci.Enabled = true;
            grado.SelectedIndex = -1;
            grado.Enabled = true;
            nombre.Clear();
            nombre.Enabled = true;
            apellidos.Clear();
            apellidos.Enabled = true;
            san.SelectedIndex = -1;
            san.Enabled = true;
            celu.Clear();
            celu.Enabled = true;
            correo.Clear();
            correo.Enabled = true;
            num.Clear();
            num.Enabled = true;
            cargo.SelectedIndex = -1;
            cargo.Enabled = true;
            agregar.Enabled = true;
            modificar.Enabled = true;
            inact.Enabled = false;
            button1.Enabled = true;
            pdf.Enabled = false;
            string consulta = "select v.Antiguedad as 'Nro.', v.CI_Voluntario as 'Cédula de identidad', v.ID_Grado as Grado, v.Apellidos, v.Nombre, v.Fecha_de_nacimiento as 'Fecha de nacimiento', v.Grupo_sanguíneo as 'Grupo sanguíneo', v.Sexo, v.Celular, v.Número_de_emergencia as 'Número de emergencia', v.Email as Correo, v.ID_Cargo as Cargo, v.Estado from Voluntario v order by 1, 4";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
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
                        dataGridView1.Columns[0].HeaderText = "Nro.";
                        dataGridView1.Columns[1].HeaderText = "Cédula de identidad";
                        dataGridView1.Columns[2].HeaderText = "Grado";
                        dataGridView1.Columns[3].HeaderText = "Apellidos";
                        dataGridView1.Columns[4].HeaderText = "Nombre";
                        dataGridView1.Columns[5].HeaderText = "Fecha de nacimiento";
                        dataGridView1.Columns[6].HeaderText = "Tipo de sangre";
                        dataGridView1.Columns[7].HeaderText = "Sexo";
                        dataGridView1.Columns[8].HeaderText = "Celular";
                        dataGridView1.Columns[9].HeaderText = "Número de emergencia";
                        dataGridView1.Columns[10].HeaderText = "Correo";
                        dataGridView1.Columns[11].HeaderText = "Cargo";
                        dataGridView1.Columns[12].HeaderText = "Estado";

                        /*ci.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                grado.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                apellidos.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                nombre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                fecha_nac.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                san.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                celu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                num.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                correo.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                cargo.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                sex = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                est= dataGridView1.CurrentRow.Cells[11].Value.ToString();*/

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
                PdfWriter writer1 = null;

                try
                {
                    // Crear documento PDF
                    pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);

                    if (string.IsNullOrEmpty(saveFileDialog.FileName))
                    {
                        MessageBox.Show("No se seleccionó un archivo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    writer1 = PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    pdfDoc.Open();

                    // Agregar encabezado al PDF
                    Font headerFont = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    Paragraph header = new Paragraph("FUNDACIÓN GUARDIÁN", headerFont);
                    Paragraph header1 = new Paragraph("FUEGO, BÚSQUEDA Y RESCATE", new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK));

                    header.Alignment = Element.ALIGN_CENTER;
                    header1.Alignment = Element.ALIGN_CENTER;

                    pdfDoc.Add(header);
                    pdfDoc.Add(header1);

                    // Agregar información adicional
                    pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
                    pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
                    pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
                    pdfDoc.Add(new Paragraph("Tipo de reporte: Listado de total de misiones"));
                    pdfDoc.Add(new Paragraph("\n")); // Espacio

                    // Crear la tabla para el DataGridView
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                    pdfTable.WidthPercentage = 90;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    // Ajustar el tamaño de las columnas según el contenido
                    float[] widths = new float[dataGridView1.Columns.Count];
                    Font cellFont = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);  // Fuente de las celdas
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        widths[i] = GetTextWidth(dataGridView1.Columns[i].HeaderText, cellFont);  // Obtener el ancho del texto
                    }
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        if (i == 0) // Ajustar la primera columna ("Nro.")
                        {
                            widths[i] = GetTextWidth("Nro.", cellFont) + 10; // Añadir espacio adicional
                        }
                        else
                        {
                            widths[i] = GetTextWidth(dataGridView1.Columns[i].HeaderText, cellFont);
                        }
                    }
                    pdfTable.SetWidths(widths);

                    // Agregar encabezados de columna
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, cellFont));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER; // Alinear el texto en el centro
                        pdfTable.AddCell(cell);
                    }

                    // Agregar filas del DataGridView al PDF
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow) // Ignorar la fila nueva vacía si está presente
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value != null ? cell.Value.ToString() : "", cellFont));
                                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER; // Alinear el texto en el centro
                                pdfTable.AddCell(pdfCell);
                            }
                        }
                    }

                    // Agregar imagen
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LOGO_FG_rediseño_008, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    // Añadir la tabla al documento
                    pdfDoc.Add(pdfTable);

                    // Notificación al usuario
                    MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cerrar documento y liberar recursos
                    if (pdfDoc != null && pdfDoc.IsOpen())
                    {
                        pdfDoc.Close();
                    }

                    if (writer1 != null)
                    {
                        writer1.Close();
                    }
                }
            }
        }

        // Función para calcular el ancho del texto
        private float GetTextWidth(string text, Font font)
        {
            BaseFont baseFont = font.GetCalculatedBaseFont(false);
            float textWidth = baseFont.GetWidthPoint(text, font.Size);
            return textWidth;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            carbus.Visible = false;
            grabus.Visible = false;
            sanbus.Visible = false;
            buscar.Visible = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            carbus.Visible = false;
            grabus.Visible = true;
            sanbus.Visible = false;
            buscar.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            carbus.Visible = false;
            grabus.Visible = false;
            sanbus.Visible = true;
            buscar.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            carbus.Visible = true;
            grabus.Visible = false;
            sanbus.Visible = false;
            buscar.Visible = false;
        }

        private void buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void grabus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sanbus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Usu3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void carbus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void celu_TextChanged(object sender, EventArgs e)
        {

        }

        private void san_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fecha_nac_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    

