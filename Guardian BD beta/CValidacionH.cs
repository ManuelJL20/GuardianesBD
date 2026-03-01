using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Guardian_BD_beta
{
    class CValidacionH
    {
        #region "METODOS"

        public bool datosok(ErrorProvider Error, ComboBox min, ComboBox vol, ComboBox nom, ComboBox est, TextBox fecpar, DataGridView dgv)
        {
            bool resp = true;

            if (string.IsNullOrEmpty(min.Text))
            {
                resp = false;
                Error.SetError(min, "Campo obligatorio");
                MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Error.SetError(min, "");

                if (string.IsNullOrEmpty(vol.Text))
                {
                    resp = false;
                    Error.SetError(vol, "Campo obligatorio");
                    MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Error.SetError(vol, "");
                    if (string.IsNullOrEmpty(nom.Text))
                    {
                        resp = false;
                        Error.SetError(nom, "Campo obligatorio");
                        MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Error.SetError(nom, "");
                        if (Convert.ToDateTime(fecpar.Text).Date < Convert.ToDateTime("01/01/2024").Date
              || Convert.ToDateTime(fecpar.Text).Date > Convert.ToDateTime("01/01/2030").Date)
                        //No se aceptan fechas anteriores al 2024
                        //Tambien no se aceptan fechas posteriores 2030
                        {
                            resp = false;
                            Error.SetError(fecpar, "Fecha fuera de rango");
                            MessageBox.Show("Fecha fuera de rango", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            Error.SetError(fecpar, "");

                            if (string.IsNullOrEmpty(est.Text))
                            {
                                resp = false;
                                Error.SetError(est, "Campo obligatorio");
                                MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                Error.SetError(est, "");



                                for (int v = 0; v < dgv.Rows.Count - 1; v++)
                                {
                                    if (vol.Text == dgv.Rows[v].Cells[2].Value.ToString() && nom.Text == dgv.Rows[v].Cells[3].Value.ToString() && est.Text == dgv.Rows[v].Cells[6].Value.ToString())
                                    {
                                        resp = false;
                                        MessageBox.Show("El voluntario está registrado en una misión en estado de emergencia, no se permite un nuevo registro suyo hasta que retorne", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        Error.SetError(vol, "Voluntario no válido");
                                    }
                                    else
                                    {
                                        Error.SetError(vol, "");
                                    }


                                }

                            }

                        }
                    }
                } }
            
            
                return resp;
        }
            #endregion
        
    }
}
