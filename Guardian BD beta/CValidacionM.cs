using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Guardian_BD_beta
{
    class CValidacionM
    {
        #region "METODOS"

        public bool datosok(ErrorProvider Error, ComboBox provincia, DateTimePicker fec, ComboBox jefe, ComboBox nom, ComboBox tipomision, RichTextBox mun, RichTextBox acerca, DataGridView dgv2)
        {
            bool resp = true;
            if (string.IsNullOrEmpty(provincia.Text))
            {
                resp = false;
                Error.SetError(provincia, "Campo obligatorio");
        MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
            else
            {
                Error.SetError(provincia, "");
                if (string.IsNullOrEmpty(jefe.Text))
                {
                    resp = false;
                    Error.SetError(jefe, "Campo obligatorio");
          MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
                else
                {
                    Error.SetError(jefe, "");
                    if (string.IsNullOrEmpty(nom.Text))
                    {
                        resp = false;
                        Error.SetError(nom, "Campo obligatorio");
                        MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Error.SetError(nom, "");
                        if (string.IsNullOrEmpty(mun.Text))
                    {
                        resp = false;
                        Error.SetError(mun, "Campo obligatorio");
              MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                    else
                    {
                        Error.SetError(mun, "");
                            if (fec.Value < Convert.ToDateTime("01/01/2023")
                    || fec.Value > Convert.ToDateTime("01/01/2035"))
                            //No se aceptan fechas anteriores al 2023
                            //Tambien no se aceptan fechas posteriores 2035
                            {
                                resp = false;
                                Error.SetError(fec, "Fecha inválida");
                                MessageBox.Show("Fecha inválida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else
                            {
                                Error.SetError(fec, "");
                                if (string.IsNullOrEmpty(tipomision.Text))
                                {
                                    resp = false;
                                    Error.SetError(tipomision, "Campo obligatorio");
                  MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                                else
                                {
                                    Error.SetError(tipomision, "");
                                    if (string.IsNullOrEmpty(acerca.Text))
                                    {
                                        resp = false;
                                        Error.SetError(acerca, "Campo obligatorio");
                    MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  }
                                    else
                                    {
                                        Error.SetError(acerca, "");
                                        for (int v = 0; v < dgv2.Rows.Count - 1; v++)
                                        {
                                            if (jefe.Text == dgv2.Rows[v].Cells[2].Value.ToString() && nom.Text == dgv2.Rows[v].Cells[3].Value.ToString() && dgv2.Rows[v].Cells[6].Value.ToString() == "Emergencia")
                                            {
                                                resp = false;
                                                MessageBox.Show("El voluntario se encuentra en una misión, no puede asumir el mando de otra patrulla hasta retornar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                Error.SetError(jefe, "Voluntario en misión");
                                            }
                                            else
                                            {
                                                Error.SetError(jefe, "");
                                            }


                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            return resp;
            #endregion
        }

    }
}


