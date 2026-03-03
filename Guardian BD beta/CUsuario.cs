using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guardian_BD_beta
{
    class CUsuario
    {
        #region "METODOS"

        public bool datosok(ErrorProvider Error, TextBox nom, TextBox con, ComboBox tip, DataGridView dgv)
        {
            bool resp = true;

            if (string.IsNullOrEmpty(nom.Text))
            {
                resp = false;
                Error.SetError(nom, "Campo obligatorio");
                MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Error.SetError(nom, "");

                if (string.IsNullOrEmpty(con.Text))
                {
                    resp = false;
                    Error.SetError(con, "Campo obligatorio");
                    MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Error.SetError(con, "");
                    if (string.IsNullOrEmpty(tip.Text))
                    {
                        resp = false;
                        Error.SetError(tip, "Campo obligatorio");
                        MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Error.SetError(tip, "");

                        for (int v = 0; v < dgv.Rows.Count - 1; v++)
                        {
                            // CORRECCIÓN: Validamos el nombre, pero excluimos la fila que estamos editando (v != dgv.CurrentRow.Index)
                            if (nom.Text == dgv.Rows[v].Cells[0].Value.ToString() && v != dgv.CurrentRow.Index)
                            {
                                resp = false;
                                MessageBox.Show("El nombre de usuario ya se encuentra registrado por otra persona", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Error.SetError(nom, "Nombre de Usuario duplicado");
                                break;
                            }
                            else
                            {
                                Error.SetError(nom, "");
                                Error.SetError(con, ""); // Se quita el error de contraseña porque sí se pueden repetir
                            }


                        }
                    }
                }
            }










            return resp;
        }
    }
}
        #endregion

    
