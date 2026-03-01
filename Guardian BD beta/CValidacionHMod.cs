using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Guardian_BD_beta
{
    class CValidacionHMod
    {
        #region "METODOS"

        public bool datosok(ErrorProvider Error, ComboBox min, ComboBox vol, ComboBox est, TextBox fecpar, TextBox fecret)
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

          if (Convert.ToDateTime(fecpar.Text).Date < Convert.ToDateTime("01/01/2024").Date
    || Convert.ToDateTime(fecpar.Text).Date > Convert.ToDateTime("01/01/2028").Date)
                    //No se aceptan fechas anteriores al 2024
                    //Tambien no se aceptan fechas posteriores 2028
                    {
                        resp = false;
                        Error.SetError(fecpar, "Fecha fuera de rango");
                        MessageBox.Show("Fecha fuera de rango", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        Error.SetError(fecpar, "");
                        if (Convert.ToDateTime(fecret.Text).Date < Convert.ToDateTime(fecpar.Text).Date
             || Convert.ToDateTime(fecret.Text).Date > Convert.ToDateTime("01/01/2028").Date)
                        //No se aceptan fechas menores a la fecha de patida
                        //Tambien no se aceptan fechas posteriores 2028
                        {
                            resp = false;
                            Error.SetError(fecret, "La fecha de retorno debe tener la misma o una fecha posterior a la de partida");
                            MessageBox.Show("La fecha de retorno debe tener la misma o una fecha posterior a la de partida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            Error.SetError(fecret, "");

                            if (string.IsNullOrEmpty(est.Text))
                            {
                                resp = false;
                                Error.SetError(est, "Campo obligatorio");
                                MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                Error.SetError(est, "");


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
