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
  public partial class Form11 : Form
  {
    string Usuario;
    string tipo;
    public int incrementar()
    {
      if (id.Text == null)
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


    public Form11(string usu, string tip)
    {
      InitializeComponent();
      Usuario = usu;
      tipo = tip;
    }

    CValidacionH objV = new CValidacionH();
    CValidacionHMod objw = new CValidacionHMod();
    SqlConnection conexion = ConexionGuardianBD.ObtConexion();
    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form2 Obj = new Form2(Usuario, tipo);
      Obj.ShowDialog();
    }

    private void Form11_Load(object sender, EventArgs e)
    {

      usu11.Text = tipo.ToUpper() + ": " + Usuario.ToUpper();
      if (tipo == "Administrador")
      {
        agregar.Visible = true;
        modificar.Visible = true;
        button1.Visible = true;
        borrar.Visible = true;
        label14.Visible = true;

      }
      else
      {
        agregar.Visible = false;
        modificar.Visible = false;
        button1.Visible = false;
        label14.Visible = false;
        borrar.Visible = false;

      }
      string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado";
      SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
      DataTable dt = new DataTable();
      adaptador.Fill(dt);
      dataGridView1.DataSource = dt;

      conexion.Open();
      string consulta0 = "select max(hm.ID_Historial) from Historial_de_misiones hm ";
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

      conexion.Open();
      string consulta1 = "select max(m.Municipio_y_lugar) from Misión m where m.ID_Misión=(select max(m.ID_Misión) from Misión m)";
      SqlCommand comando1 = new SqlCommand(consulta1, conexion);
      SqlDataReader lector1 = comando1.ExecuteReader();

      while (lector1.Read())
      {
        idmin.Items.Add(lector1.GetString(0));
      }


      conexion.Close();

      conexion.Open();
      string consulta1a = "select m.Municipio_y_lugar from Misión m";
      SqlCommand comando1a = new SqlCommand(consulta1a, conexion);
      SqlDataReader lector1a = comando1a.ExecuteReader();

      while (lector1a.Read())
      {
        refbus.Items.Add(lector1a.GetString(0));
      }


      conexion.Close();

      conexion.Open();
      string consulta2 = "select m.Municipio_y_lugar from Misión m";
      SqlCommand comando2 = new SqlCommand(consulta2, conexion);
      SqlDataReader lector2 = comando2.ExecuteReader();
      while (lector2.Read())
      {
        minres.Items.Add(lector2.GetString(0));
      }
      conexion.Close();


      conexion.Open();
      string consulta3 = "select v.Apellidos from Voluntario v  where v.Estado='Activo' order by 1";
      SqlCommand comando3 = new SqlCommand(consulta3, conexion);
      SqlDataReader lector3 = comando3.ExecuteReader();

      while (lector3.Read())
      {
        civol.Items.Add(lector3.GetString(0));
      }
      conexion.Close();

      conexion.Open();
      string consulta2a = "select v.Apellidos from Voluntario v  where v.Estado='Activo' order by 1";
      SqlCommand comando2a = new SqlCommand(consulta2a, conexion);
      SqlDataReader lector2a = comando2a.ExecuteReader();

      while (lector2a.Read())
      {
        apebus.Items.Add(lector2a.GetString(0));
      }
      conexion.Close();

      conexion.Open();
      string consulta5 = "select v.Apellidos from Voluntario v  where v.Estado='Activo' order by 1";
      SqlCommand comando5 = new SqlCommand(consulta5, conexion);
      SqlDataReader lector5 = comando5.ExecuteReader();

      while (lector5.Read())
      {
        aperes.Items.Add(lector5.GetString(0));
      }
      conexion.Close();

      conexion.Open();
      string consulta4 = "select * from Estado_misión ";
      SqlCommand comando4 = new SqlCommand(consulta4, conexion);
      SqlDataReader lector4 = comando4.ExecuteReader();

      while (lector4.Read())
      {
        estado.Items.Add(lector4.GetString(1));
      }
      conexion.Close();

      conexion.Open();
      string consulta4a = "select * from Estado_misión ";
      SqlCommand comando4a = new SqlCommand(consulta4a, conexion);
      SqlDataReader lector4a = comando4a.ExecuteReader();

      while (lector4a.Read())
      {
        estbus.Items.Add(lector4a.GetString(1));
      }
      conexion.Close();

    }

    private void toolStripMenuItem3_Click(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void agregar_Click(object sender, EventArgs e)
    {
      if (objV.datosok(Error, idmin, civol, volnom, estado, fec_par, dataGridView1))
      {

        conexion.Open();
        string consulta = "insert into Historial_de_misiones values('" + incrementar() + "','" + idm.Text + "','" + civ.Text + "','" + fec_par.Text + "', NULL ,'" + est.Text + "')";
        SqlCommand comando = new SqlCommand(consulta, conexion);
        comando.ExecuteNonQuery();
        MessageBox.Show("Se registró con éxito");
        conexion.Close();

        conexion.Open();
        string consulta0 = "select max(hm.ID_Historial) from Historial_de_misiones hm ";
        SqlCommand comando0 = new SqlCommand(consulta0, conexion);
        SqlDataReader lector0 = comando0.ExecuteReader();

        while (lector0.Read())
        {
          id.Text = (lector0.GetInt32(0)).ToString();
        }

        conexion.Close();

        idmin.SelectedIndex = -1;
        civol.SelectedIndex = -1;
        volnom.SelectedIndex = -1;
        aperes.SelectedIndex = -1;
        nomres.SelectedIndex = -1;
        estado.SelectedIndex = -1;
        agregar.Enabled = true;
        borrar.Enabled = false;
        modificar.Enabled = false;
        fec_ret.Enabled = false;
        minres.SelectedIndex = -1;
        minres.Enabled = false;

        string consulta1 = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado";
        SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
        DataTable dt1 = new DataTable();
        adaptador1.Fill(dt1);
        dataGridView1.DataSource = dt1;

      }

    }

    private void estado_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void cijefe_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void civol_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void refresh_Click(object sender, EventArgs e)
    {


      string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado";
      SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
      DataTable dt = new DataTable();
      adaptador.Fill(dt);
      dataGridView1.DataSource = dt;
      idmin.SelectedIndex = -1;
      civol.SelectedIndex = -1;
      volnom.SelectedIndex = -1;
      aperes.SelectedIndex = -1;
      nomres.SelectedIndex = -1;
      estado.SelectedIndex = -1;
      minres.SelectedIndex = -1;
      minres.Enabled = false;
      agregar.Enabled = true;
      borrar.Enabled = false;
      modificar.Enabled = false;
      fec_ret.Enabled = false;
      aperes.Enabled = false;
      nomres.Enabled = false;

      idmin.Enabled = true;
      civol.Enabled = true;
      volnom.Enabled = true;
      radioButton1.Checked = true;
      button4.Enabled = false;
      conexion.Open();
      string consulta0 = "select max(hm.ID_Historial) from Historial_de_misiones hm";
      SqlCommand comando0 = new SqlCommand(consulta0, conexion);
      SqlDataReader lector0 = comando0.ExecuteReader();

      while (lector0.Read())
      {
        id.Text = (lector0.GetInt32(0)).ToString();
      }

      conexion.Close();

    }

    private void cijefe_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }

    private void civol_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      volnom.Items.Clear();
      volnom.Enabled = true;
      conexion.Open();
      string consulta4 = "select v.Nombre from Voluntario v where v.Apellidos = '" + civol.Text + "'";
      SqlCommand comando4 = new SqlCommand(consulta4, conexion);
      SqlDataReader lector4 = comando4.ExecuteReader();
      while (lector4.Read())
      {
        volnom.Items.Add(lector4.GetString(0));
      }
      conexion.Close();

    }

    private void idmin_SelectedIndexChanged(object sender, EventArgs e)
    {
      conexion.Open();
      string consulta3 = "select m.ID_Misión from Misión m where m.Municipio_y_lugar = '" + idmin.Text + "'";
      SqlCommand comando3 = new SqlCommand(consulta3, conexion);
      SqlDataReader lector3 = comando3.ExecuteReader();
      while (lector3.Read())
      {
        idm.Text = (lector3.GetInt32(0)).ToString();
      }
      conexion.Close();
    }

    private void estado_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      conexion.Open();
      string consulta3 = "select e.Cod_Estado from Estado_misión e where e.Significado = '" + estado.Text + "'";
      SqlCommand comando3 = new SqlCommand(consulta3, conexion);
      SqlDataReader lector3 = comando3.ExecuteReader();
      while (lector3.Read())
      {
        est.Text = (lector3.GetString(0));
      }
      conexion.Close();
    }

    private void modificar_Click(object sender, EventArgs e)
    {
      if (objw.datosok(Error, minmod, civmod, estado, fec_par, fec_ret))
      {
        conexion.Open();
        string consultaa = "update Historial_de_misiones set ID_Historial='" + id.Text + "', ID_Misión='" + minmod.Text + "', CI_Voluntario ='" + civmod.Text + "', Fecha_de_partida='" + fec_par.Text + "', Fecha_de_retorno='" + fec_ret.Text + "', Cod_Estado='" + est.Text + "' where ID_Historial = '" + id.Text + "'";
        SqlCommand comandoa = new SqlCommand(consultaa, conexion);
        int cant;
        cant = comandoa.ExecuteNonQuery();
        if (cant > 0)
        {
          MessageBox.Show("Registro modificado");
        }
        conexion.Close();

        modificar.Enabled = false;
        string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado";
        SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
        DataTable dt = new DataTable();
        adaptador.Fill(dt);
        dataGridView1.DataSource = dt;

        idmin.SelectedIndex = -1;
        civol.SelectedIndex = -1;
        volnom.SelectedIndex = -1;
        aperes.SelectedIndex = -1;
        nomres.SelectedIndex = -1;
        estado.SelectedIndex = -1;
        agregar.Enabled = true;
        borrar.Enabled = false;
        modificar.Enabled = false;
        fec_ret.Enabled = false;
        minres.SelectedIndex = -1;
        minres.Enabled = false;
        aperes.Enabled = false;

        idmin.Enabled = true;
        civol.Enabled = true;

        conexion.Open();
        string consulta0 = "select max(hm.ID_Historial) from Historial_de_misiones hm";
        SqlCommand comando0 = new SqlCommand(consulta0, conexion);
        SqlDataReader lector0 = comando0.ExecuteReader();

        while (lector0.Read())
        {
          id.Text = (lector0.GetInt32(0)).ToString();
        }

        conexion.Close();

      }
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      agregar.Enabled = false;
      idmin.Enabled = false;
      idmin.SelectedIndex = -1;
      civol.Enabled = false;
      civol.SelectedIndex = -1;
      volnom.SelectedIndex = -1;
      volnom.Enabled = false;
      minres.Enabled = true;
      aperes.Enabled = true;
      nomres.Enabled = true;

      try
      {
        id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        minres.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        aperes.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        nomres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        if (e.RowIndex >= 0)
        {
          DateTime fecha = Convert.ToDateTime(
              dataGridView1.Rows[e.RowIndex].Cells[4].Value
          );

          fec_par.Text = fecha.ToString("d/M/yyyy");
        }
        if (e.RowIndex >= 0)
        {
          DateTime fecha = Convert.ToDateTime(
              dataGridView1.Rows[e.RowIndex].Cells[5].Value
          );

          fec_ret.Text = fecha.ToString("d/M/yyyy");
        }
        estado.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
      }

      catch { }
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

      modificar.Enabled = true;

      fec_ret.Enabled = true;
      borrar.Enabled = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      volnom.Items.Clear();
      idmin.SelectedIndex = -1;
      civol.SelectedIndex = -1;
      volnom.SelectedIndex = -1;
      aperes.SelectedIndex = -1;
      nomres.SelectedIndex = -1;
      estado.SelectedIndex = -1;
      minres.SelectedIndex = -1;
      minres.Enabled = false;
      agregar.Enabled = true;
      borrar.Enabled = false;
      modificar.Enabled = false;
      fec_ret.Enabled = false;
      aperes.Enabled = false;
      nomres.Enabled = false;
      button4.Enabled = false;

      idmin.Enabled = true;
      civol.Enabled = true;
      volnom.Enabled = true;
      radioButton1.Checked = true;

      string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado";
      SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
      DataTable dt = new DataTable();
      adaptador.Fill(dt);
      dataGridView1.DataSource = dt;

      conexion.Open();
      string consulta0 = "select max(hm.ID_Historial) from Historial_de_misiones hm";
      SqlCommand comando0 = new SqlCommand(consulta0, conexion);
      SqlDataReader lector0 = comando0.ExecuteReader();

      while (lector0.Read())
      {
        id.Text = (lector0.GetInt32(0)).ToString();
      }

      conexion.Close();
    }

    private void borrar_Click(object sender, EventArgs e)
    {
      conexion.Open();
      string consulta = "DELETE FROM Historial_de_misiones WHERE ID_Historial = '" + id.Text + "'";
      SqlCommand comando = new SqlCommand(consulta, conexion);
      comando.ExecuteNonQuery();
      MessageBox.Show("El registro ha sido borrado con éxito.");
      conexion.Close();

      string consulta1 = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado";
      SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
      DataTable dt = new DataTable();
      adaptador1.Fill(dt);
      dataGridView1.DataSource = dt;

      idmin.SelectedIndex = -1;
      civol.SelectedIndex = -1;
      volnom.SelectedIndex = -1;
      aperes.SelectedIndex = -1;
      nomres.SelectedIndex = -1;
      estado.SelectedIndex = -1;
      agregar.Enabled = true;
      borrar.Enabled = false;
      modificar.Enabled = false;
      fec_ret.Enabled = false;
      minres.SelectedIndex = -1;
      minres.Enabled = false;
      aperes.Enabled = false;

      idmin.Enabled = true;
      civol.Enabled = true;
      conexion.Open();
      string consulta0 = "select max(hm.ID_Historial) from Historial_de_misiones hm";
      SqlCommand comando0 = new SqlCommand(consulta0, conexion);
      SqlDataReader lector0 = comando0.ExecuteReader();

      while (lector0.Read())
      {
        id.Text = (lector0.GetInt32(0)).ToString();
      }

      conexion.Close();
    }

    private void aperes_SelectedIndexChanged(object sender, EventArgs e)
    {
      conexion.Open();
      string consulta4 = "select v.Nombre from Voluntario v where v.Apellidos = '" + aperes.Text + "'";
      SqlCommand comando4 = new SqlCommand(consulta4, conexion);
      SqlDataReader lector4 = comando4.ExecuteReader();
      while (lector4.Read())
      {
        nomres.Items.Add(lector4.GetString(0)); ;
      }
      conexion.Close();


    }

    private void minres_SelectedIndexChanged(object sender, EventArgs e)
    {
      conexion.Open();
      string consulta3 = "select m.ID_Misión from Misión m where m.Municipio_y_lugar = '" + minres.Text + "'";
      SqlCommand comando3 = new SqlCommand(consulta3, conexion);
      SqlDataReader lector3 = comando3.ExecuteReader();
      while (lector3.Read())
      {
        minmod.Text = (lector3.GetInt32(0)).ToString();
      }
      conexion.Close();
    }

    private void civol_Click(object sender, EventArgs e)
    {
      volnom.Items.Clear();
      volnom.Enabled = true;
    }

    private void nomres_Click(object sender, EventArgs e)
    {

    }

    private void volnom_SelectedIndexChanged(object sender, EventArgs e)
    {
      conexion.Open();
      string consulta3 = "select v.CI_Voluntario from Voluntario v where v.Apellidos = '" + civol.Text + "' and v.Nombre='" + volnom.Text + "'";
      SqlCommand comando3 = new SqlCommand(consulta3, conexion);
      SqlDataReader lector3 = comando3.ExecuteReader();
      while (lector3.Read())
      {
        civ.Text = (lector3.GetInt32(0)).ToString();
      }
      conexion.Close();
      volnom.Enabled = false;
    }

    private void nomres_SelectedIndexChanged(object sender, EventArgs e)
    {
      conexion.Open();
      string consulta3 = "select v.CI_Voluntario from Voluntario v where v.Apellidos = '" + aperes.Text + "' and v.Nombre='" + nomres.Text + "'";
      SqlCommand comando3 = new SqlCommand(consulta3, conexion);
      SqlDataReader lector3 = comando3.ExecuteReader();
      while (lector3.Read())
      {
        civmod.Text = (lector3.GetInt32(0)).ToString();
      }
      conexion.Close();
      nomres.Enabled = false;
    }

    private void aperes_Click(object sender, EventArgs e)
    {
      nomres.Items.Clear();
      nomres.Enabled = true;
    }

    private void apebus_SelectedIndexChanged(object sender, EventArgs e)
    {
      nombus.Items.Clear();
      conexion.Open();
      string consulta4 = "select v.Nombre from Voluntario v  where v.Apellidos = '" + apebus.Text + "'  order by 1";
      SqlCommand comando4 = new SqlCommand(consulta4, conexion);
      SqlDataReader lector4 = comando4.ExecuteReader();
      while (lector4.Read())
      {
        nombus.Items.Add(lector4.GetString(0));
      }
      conexion.Close();
    }

    private void apebus_Click(object sender, EventArgs e)
    {
      nombus.Items.Clear();
      nombus.Enabled = true;
    }

    private void nombus_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      refbus.Visible = true;
      fecbus1.Visible = false;
      button4.Enabled = false;

      apebus.Visible = false;
      nombus.Visible = false;
      fecbus.Visible = false;
      estbus.Visible = false;
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      apebus.Visible = true;
      nombus.Visible = true;
      button4.Enabled = false;

      fecbus.Visible = false;
      fecbus1.Visible = false;
      estbus.Visible = false;
      refbus.Visible = false;

    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
      button4.Enabled = false;
      fecbus.Visible = true;
      fecbus1.Visible = true;
      apebus.Visible = false;
      nombus.Visible = false;
      estbus.Visible = false;
      refbus.Visible = false;
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
      estbus.Visible = true;
      apebus.Visible = false;
      nombus.Visible = false;
      fecbus.Visible = false;
      refbus.Visible = false;
      fecbus1.Visible = false;
      button4.Enabled = false;


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
    private void buttonbusq_Click(object sender, EventArgs e)
    {
      if (radioButton1.Checked)
      {
        if (string.IsNullOrEmpty(refbus.Text))
        {
          MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          button4.Enabled = true;
          conexion.Open();
          string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado and m.Municipio_y_lugar= '" + refbus.Text + "' ";
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
          if (string.IsNullOrEmpty(fecbus.Text))
          {
            MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else
          {
            button4.Enabled = true;

            conexion.Open();
            string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado and hm.Fecha_de_partida >= '" + fecbus.Text + "' and hm.Fecha_de_partida <= '" + fecbus1.Text + "'";
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
            if (string.IsNullOrEmpty(apebus.Text) || string.IsNullOrEmpty(nombus.Text))
            {
              MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
              button4.Enabled = true;

              conexion.Open();
              string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado and v.Apellidos= '" + apebus.Text + "' and v.Nombre= '" + nombus.Text + "'";
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
              if (string.IsNullOrEmpty(estbus.Text))
              {
                MessageBox.Show("Buscador vacío, inserte el dato que desea buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
              else
              {
                button4.Enabled = true;

                conexion.Open();
                string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Municipio y lugar', v.Apellidos as 'Apellido del voluntario', v.Nombre as 'Nombre del voluntario', hm.Fecha_de_partida as 'Fecha de partida', hm.Fecha_de_retorno as 'Fecha de retorno', e.Significado as 'Estado de la misión' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado and e.Significado= '" + estbus.Text + "'";
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

    private void button2_Click(object sender, EventArgs e)
    {
      ExportToExcel(dataGridView1);
    }

    private void button3_Click(object sender, EventArgs e)
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
            dataGridView1.Columns[1].HeaderText = "Municipio y lugar";
            dataGridView1.Columns[2].HeaderText = "Apellidos del voluntario";
            dataGridView1.Columns[3].HeaderText = "Nombre del voluntario";
            dataGridView1.Columns[4].HeaderText = "Fecha de partida";
            dataGridView1.Columns[5].HeaderText = "Fecha de retorno";
            dataGridView1.Columns[6].HeaderText = "Estado de la misión";




            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11);


          }



        }

      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
      saveFileDialog.FileName = string.Format("Reporte_{0}.pdf", DateTime.Now.ToString("yyyyMMdd_HHmmss"));

      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        // Crear documento PDF
        Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));

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
          string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Misión', v.Apellidos as 'Ape. Voluntario', v.Nombre as 'Nombre Voluntario', FORMAT(hm.Fecha_de_partida, 'dd/MM/yyyy') as 'Fecha de partida', FORMAT(hm.Fecha_de_retorno, 'dd/MM/yyyy') as 'Fecha de retorno', e.Significado as 'Estado' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado and m.Municipio_y_lugar= '" + refbus.Text + "'";
          SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
          DataTable dt = new DataTable();
          adaptador.Fill(dt);
          dataGridView1.DataSource = dt;
          SqlCommand comando = new SqlCommand(consulta, conexion);
          SqlDataReader lector;
          lector = comando.ExecuteReader();
          conexion.Close();

          // Agregar información adicional
          pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
          pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
          pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
          pdfDoc.Add(new Paragraph("Tipo de reporte: Específica"));
          pdfDoc.Add(new Paragraph("Misión:  " + refbus.Text + "."));
          pdfDoc.Add(new Paragraph("\n")); // Espacio
        }
        else
        {
          if (radioButton2.Checked)
          {
            conexion.Open();
            string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Misión', v.Apellidos as 'Ape. Voluntario', v.Nombre as 'Nombre Voluntario',  FORMAT(hm.Fecha_de_partida, 'dd/MM/yyyy') as 'Fecha de partida', FORMAT(hm.Fecha_de_retorno, 'dd/MM/yyyy') as 'Fecha de retorno', e.Significado as 'Estado' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado  and v.Apellidos='" + apebus.Text + "' and v.Nombre='" + nombus.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            conexion.Close();
            pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
            pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
            pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
            pdfDoc.Add(new Paragraph("Tipo de reporte: Voluntario en específico"));
            pdfDoc.Add(new Paragraph("Historial del voluntario: " + apebus.Text + " " + nombus.Text + " en las misiones que participó."));
            pdfDoc.Add(new Paragraph("\n")); // Espacio
          }
          else
          {
            if (radioButton3.Checked)
            {
              conexion.Open();
              string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Misión', v.Apellidos as 'Ape. Voluntario', v.Nombre as 'Nombre Voluntario',  FORMAT(hm.Fecha_de_partida, 'dd/MM/yyyy') as 'Fecha de partida', FORMAT(hm.Fecha_de_retorno, 'dd/MM/yyyy') as 'Fecha de retorno', e.Significado as 'Estado' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado  and hm.Fecha_de_partida >= '" + fecbus.Value.ToString() + "' and hm.Fecha_de_partida <= '" + fecbus1.Value.ToString() + "'";
              //select m.ID_Misión as ID, p.Nombre as Provincia, m.Ubicación_específica as 'Ubicación específica', m.Fecha as 'Fecha de misión', v.Apellidos as 'Apellido del Jefe de Patrulla', v.Nombre as 'Nombre del Jefe de Patrulla', COUNT(hm.ID_Misión) as Bomberos, h.Descripción as Herramientas, m.Acerca_de_la_misión as 'Acerca de la misión' from Misión m, Voluntario v, Herramientas h, Provincias p, Historial_de_misiones hm where  m.ID_Misión=hm.ID_Misión and m.ID_Provincia = p.ID_Provincia and v.CI_Voluntario = m.CI_Jefe and h.ID_Herramientas = m.ID_Herramientas and m.Fecha >= '" + fecbus.Value.ToString()+ "' and m.Fecha <= '" + fecbus1.Value.ToString() + "' group by  m.ID_Misión, p.Nombre, m.Ubicación_específica , m.Fecha , v.Apellidos , v.Nombre  , h.Descripción , m.Acerca_de_la_misión order by 3 //
              SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
              DataTable dt = new DataTable();
              adaptador.Fill(dt);
              dataGridView1.DataSource = dt;
              SqlCommand comando = new SqlCommand(consulta, conexion);
              SqlDataReader lector;
              lector = comando.ExecuteReader();
              conexion.Close();
              pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
              pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
              pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
              pdfDoc.Add(new Paragraph("Tipo de reporte: Por fechas"));
              pdfDoc.Add(new Paragraph("Misiones desde el " + fecbus.Value.ToString("dd/MM/yyyy") + " hasta el " + fecbus1.Value.ToString("dd/MM/yyyy")));
              pdfDoc.Add(new Paragraph("\n")); // Espacio
            }
            else
            {
              if (radioButton4.Checked)
              {
                conexion.Open();
                string consulta = "select hm.ID_Historial as ID, m.Municipio_y_lugar as 'Misión', v.Apellidos as 'Ape. Voluntario', v.Nombre as 'Nombre Voluntario', FORMAT(hm.Fecha_de_partida, 'dd/MM/yyyy') as 'Fecha de partida', FORMAT(hm.Fecha_de_retorno, 'dd/MM/yyyy') as 'Fecha de retorno', e.Significado as 'Estado' from Misión m, Historial_de_misiones hm, Voluntario v, Estado_misión e where m.ID_Misión = hm.ID_Misión  and hm.CI_Voluntario = v.CI_Voluntario and e.Cod_Estado = hm.Cod_Estado and e.Significado= '" + estbus.Text + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                conexion.Close();
                if (estbus.Text == "Emergencia")
                {
                  pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
                  pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
                  pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
                  pdfDoc.Add(new Paragraph("Tipo de reporte: Estado de la(s) misión(es) que se encuentran en Emergencia."));
                  pdfDoc.Add(new Paragraph("\n")); // Espacio
                }
                else
                {
                  pdfDoc.Add(new Paragraph("\n")); // Espacio entre secciones
                  pdfDoc.Add(new Paragraph("Usuario: " + Usuario.ToUpper()));
                  pdfDoc.Add(new Paragraph("Fecha de reporte: " + DateTime.Now.ToString("dd/MM/yyyy")));
                  pdfDoc.Add(new Paragraph("Tipo de reporte: Estado de la(s) misión(es) que se encuentran Finalizadas."));
                  pdfDoc.Add(new Paragraph("\n")); // Espacio
                }
              }
            }
          }
        }



        PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count - 1); // Combinamos 2 columnas en una
        pdfTable.WidthPercentage = 100;
        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

        // Ajustar el tamaño de las columnas según el contenido
        float[] widths = new float[dataGridView1.Columns.Count - 1]; // Combinamos 2 columnas, por eso -1
        Font cellFont = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);  // Fuente de las celdas

        for (int i = 0; i < dataGridView1.Columns.Count - 1; i++) // Ajustamos la cantidad de columnas
        {
          string columnName = dataGridView1.Columns[i].HeaderText;

          if (columnName == "ID") // Para la columna numérica, reducimos el ancho según su contenido
          {
            // Ajustamos el ancho al contenido máximo de la columna Bomberos (asumiendo valores como 9999 máximo)
            widths[i] = GetTextWidth("9999", cellFont); // Ajustar a números de 4 dígitos
          }
          else
          {
            // Obtener el valor más largo de la columna, tomando en cuenta el contenido de las filas
            string longestCellValue = GetLongestCellValue(dataGridView1, i);
            widths[i] = Math.Max(GetTextWidth(dataGridView1.Columns[i].HeaderText, cellFont), GetTextWidth(longestCellValue, cellFont));
          }
        }
        pdfTable.SetWidths(widths);

        // Función para obtener el valor más largo en una columna


        // Agregar encabezados de columna
        foreach (DataGridViewColumn column in dataGridView1.Columns)
        {
          if (column.HeaderText != "Ape. Voluntario" && column.HeaderText != "Nombre Voluntario") // Ignoramos estos dos encabezados
          {
            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, cellFont));
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell.HorizontalAlignment = Element.ALIGN_CENTER; // Alinear el texto en el centro
            pdfTable.AddCell(cell);
          }
        }

        // Agregar una columna nueva para "Nombre completo del Líder"
        PdfPCell combinedHeader = new PdfPCell(new Phrase("Voluntario", cellFont));
        combinedHeader.BackgroundColor = BaseColor.LIGHT_GRAY;
        combinedHeader.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfTable.AddCell(combinedHeader);

        // Agregar filas del DataGridView al PDF
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
          if (!row.IsNewRow) // Ignorar la fila nueva vacía si está presente
          {
            foreach (DataGridViewCell cell in row.Cells)
            {
              if (cell.OwningColumn.HeaderText != "Ape. Voluntario" && cell.OwningColumn.HeaderText != "Nombre Voluntario") // Ignoramos estas dos columnas
              {
                PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value != null ? cell.Value.ToString() : "", cellFont));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER; // Alinear el texto en el centro
                pdfTable.AddCell(pdfCell);
              }
            }

            // Agregar la celda combinada con "Ape. del Líder" y "Nombre del Líder"
            string fullName = row.Cells["Ape. Voluntario"].Value.ToString() + " " + row.Cells["Nombre Voluntario"].Value.ToString();
            PdfPCell combinedCell = new PdfPCell(new Phrase(fullName, cellFont));
            combinedCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.AddCell(combinedCell); // Añadimos la celda combinada
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

        // Cerrar documento PDF
        pdfDoc.Close();
        writer.Close();

        // Notificación al usuario
        MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

    }
    private float GetTextWidth(string text, Font font)
    {
      // Cargamos la fuente usada en el documento PDF
      BaseFont baseFont = font.GetCalculatedBaseFont(false);

      // Calculamos el ancho en puntos del texto usando la fuente y el tamaño que le corresponde
      float textWidth = baseFont.GetWidthPoint(text, font.Size);

      return textWidth; // Devolvemos el ancho calculado del texto
    }
    public string GetLongestCellValue(DataGridView gridView, int columnIndex)
    {
      string longestValue = gridView.Columns[columnIndex].HeaderText; // Comenzamos con el valor del encabezado

      foreach (DataGridViewRow row in gridView.Rows)
      {
        if (!row.IsNewRow) // Ignoramos filas nuevas
        {
          string cellValue = row.Cells[columnIndex].Value != null ? row.Cells[columnIndex].Value.ToString() : "";
          if (cellValue.Length > longestValue.Length)
          {
            longestValue = cellValue; // Actualizamos si encontramos una celda más larga
          }
        }
      }
      return longestValue;
    }

    private void fec_par_KeyPress(object sender, KeyPressEventArgs e)
    {
      // Permitir números, '/', y backspace
      if (!char.IsDigit(e.KeyChar) &&
          e.KeyChar != '/' &&
          e.KeyChar != '\b')
      {
        MessageBox.Show(
            "Dato no válido. Use el formato D/M/YYYY o DD/MM/YYYY",
            "Alerta",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation
        );
        e.Handled = true;
        return;
      }

      // Evitar más de 2 '/'
      if (e.KeyChar == '/' && fec_par.Text.Count(c => c == '/') >= 2)
      {
        MessageBox.Show("Formato de fecha no válido", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
      }
    }

        private void fec_par_TextChanged(object sender, EventArgs e)
        {
      string texto = fec_par.Text;

      // Evitar que empiece con '/'
      if (texto.StartsWith("/"))
      {
        MessageBox.Show("Dato no válido", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        fec_par.Clear();
        return;
      }

      string[] partes = texto.Split('/');

      // Día
      if (partes.Length >= 1 && partes[0].Length > 2)
      {
        MessageBox.Show("El día no puede tener más de 2 dígitos", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        fec_par.Text = texto.Remove(texto.Length - 1);
        fec_par.SelectionStart = fec_par.Text.Length;
        return;
      }

      // Mes
      if (partes.Length >= 2 && partes[1].Length > 2)
      {
        MessageBox.Show("El mes no puede tener más de 2 dígitos", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        fec_par.Text = texto.Remove(texto.Length - 1);
        fec_par.SelectionStart = fec_par.Text.Length;
        return;
      }

      // Año
      if (partes.Length == 3 && partes[2].Length > 4)
      {
        MessageBox.Show("El año no puede tener más de 4 dígitos", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        fec_par.Text = texto.Remove(texto.Length - 1);
        fec_par.SelectionStart = fec_par.Text.Length;
        return;
      }
    }
    private bool FechaValida(string fecha)
    {
      DateTime fechaConvertida;

      return DateTime.TryParseExact(
          fecha,
          new[] { "d/M/yyyy", "dd/MM/yyyy" },
          System.Globalization.CultureInfo.InvariantCulture,
          System.Globalization.DateTimeStyles.None,
          out fechaConvertida
      );
    }
    private void fec_par_Leave(object sender, EventArgs e)
        {
      if (string.IsNullOrWhiteSpace(fec_par.Text))
        return;

      if (!FechaValida(fec_par.Text))
      {
        MessageBox.Show(
            "La fecha ingresada no es válida",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
        fec_par.Focus();
      }
    }

        private void fec_ret_KeyPress(object sender, KeyPressEventArgs e)
        {
      // Permitir números, '/', y backspace
      if (!char.IsDigit(e.KeyChar) &&
          e.KeyChar != '/' &&
          e.KeyChar != '\b')
      {
        MessageBox.Show(
            "Dato no válido. Use el formato D/M/YYYY o DD/MM/YYYY",
            "Alerta",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation
        );
        e.Handled = true;
        return;
      }

      // Evitar más de 2 '/'
      if (e.KeyChar == '/' && fec_ret.Text.Count(c => c == '/') >= 2)
      {
        MessageBox.Show("Formato de fecha no válido", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
      }
    }

        private void fec_ret_TextChanged(object sender, EventArgs e)
        {
      string texto = fec_ret.Text;

      // Evitar que empiece con '/'
      if (texto.StartsWith("/"))
      {
        MessageBox.Show("Dato no válido", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        fec_ret.Clear();
        return;
      }

      string[] partes = texto.Split('/');

      // Día
      if (partes.Length >= 1 && partes[0].Length > 2)
      {
        MessageBox.Show("El día no puede tener más de 2 dígitos", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        fec_ret.Text = texto.Remove(texto.Length - 1);
        fec_ret.SelectionStart = fec_ret.Text.Length;
        return;
      }

      // Mes
      if (partes.Length >= 2 && partes[1].Length > 2)
      {
        MessageBox.Show("El mes no puede tener más de 2 dígitos", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        fec_ret.Text = texto.Remove(texto.Length - 1);
        fec_ret.SelectionStart = fec_ret.Text.Length;
        return;
      }

      // Año
      if (partes.Length == 3 && partes[2].Length > 4)
      {
        MessageBox.Show("El año no puede tener más de 4 dígitos", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        fec_ret.Text = texto.Remove(texto.Length - 1);
        fec_ret.SelectionStart = fec_ret.Text.Length;
        return;
      }
    }

        private void fec_ret_Leave(object sender, EventArgs e)
        {
      if (string.IsNullOrWhiteSpace(fec_ret.Text))
        return;

      if (!FechaValida(fec_ret.Text))
      {
        MessageBox.Show(
            "La fecha ingresada no es válida",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
        fec_ret.Focus();
      }
    }
    }
}

