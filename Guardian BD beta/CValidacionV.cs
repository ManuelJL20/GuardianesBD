using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guardian_BD_beta
{
    class CValidacionV
    {
        #region "METODOS"
        public bool datosok(ErrorProvider Error, DateTimePicker fec, ComboBox grado, ComboBox cargo, ComboBox sangre, TextBox ci, TextBox celu, TextBox num, TextBox nombre, TextBox apellidos, TextBox correo, DataGridView dataGridView1, DataGridView dgv2)
        {
            bool resp = true;

            //TOCA ANALIZAR EL SIGUIENTE DATO
            if (string.IsNullOrEmpty(ci.Text))
            {
                resp = false;
                Error.SetError(ci, "Campo obligatorio");
                MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                Error.SetError(ci, "");

                for (int i = 0; i < ci.TextLength; i++)
                {
                    if (ci.Text[i] != '1' && ci.Text[i] != '2' && ci.Text[i] != '3' && ci.Text[i] != '4' && ci.Text[i] != '5' && ci.Text[i] != '6' && ci.Text[i] != '7' && ci.Text[i] != '8' && ci.Text[i] != '9' && ci.Text[i] != '0')
                    {
                        resp = false;
                        Error.SetError(ci, "Datos no válidos: Ingrese números en este campo");
                        MessageBox.Show("Datos no válidos: Ingrese números en este campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {

                        Error.SetError(ci, "");


                    }
                }
                for (int i = 0; i < ci.TextLength; i++)
                {
                    if (ci.Text[i] == ' ')
                    {
                        resp = false;
                        Error.SetError(ci, "No se permiten espacios vacíos en este campo");
                        MessageBox.Show("No se permiten espacios vacíos en este campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {

                        Error.SetError(ci, "");

                    }
                }
                if (ci.Text.Length < 7 || ci.Text.Length > 8)
                {
                    resp = false;
                    Error.SetError(ci, "El ci tiene entre 7 y 8 digitos ");
                    MessageBox.Show("El ci tiene entre 7 y 8 digitos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Error.SetError(ci, "");

                    if (string.IsNullOrEmpty(grado.Text))
                    {
                        resp = false;
                        Error.SetError(grado, "Campo obligatorio");
                        MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        Error.SetError(grado, "");
                        if (string.IsNullOrEmpty(nombre.Text))
                        {
                            resp = false;
                            Error.SetError(nombre, "Campo obligatorio");
                            MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            Error.SetError(nombre, "");

                            // Usamos un bucle for para recorrer la cadena desde la posición 0 hasta el último carácter
                            for (int i = 0; i < nombre.TextLength; i++)
                            {
                                if (nombre.Text[i] == '1' || nombre.Text[i] == '2' || nombre.Text[i] == '3' || nombre.Text[i] == '4' || nombre.Text[i] == '5' || nombre.Text[i] == '6' || nombre.Text[i] == '7' || nombre.Text[i] == '8' || nombre.Text[i] == '9' || nombre.Text[i] == '0')
                                {
                                    resp = false;
                                    Error.SetError(nombre, "Datos no válidos: Ingrese caracteres de texto en este campo");
                                    MessageBox.Show("Datos no válidos: Ingrese caracteres de texto en este campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }
                                else
                                {
                                    Error.SetError(nombre, "");

                                }
                            }
                            if (string.IsNullOrEmpty(apellidos.Text))
                            {
                                resp = false;
                                Error.SetError(apellidos, "Campo obligatorio");
                                MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else
                            {
                                Error.SetError(apellidos, "");
                                for (int i = 0; i < apellidos.TextLength; i++)
                                {
                                    if (apellidos.Text[i] == '1' || apellidos.Text[i] == '2' || apellidos.Text[i] == '3' || apellidos.Text[i] == '4' || apellidos.Text[i] == '5' || apellidos.Text[i] == '6' || apellidos.Text[i] == '7' || apellidos.Text[i] == '8' || apellidos.Text[i] == '9' || apellidos.Text[i] == '0')
                                    {
                                        resp = false;
                                        Error.SetError(apellidos, "Datos no válidos: Ingrese caracteres de texto en este campo");
                                        MessageBox.Show("Datos no válidos: Ingrese caracteres de texto en este campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    }
                                    else
                                    {
                                        Error.SetError(apellidos, "");

                                    }
                                }
                                if (fec.Value < Convert.ToDateTime("01/01/1950")
                || fec.Value > Convert.ToDateTime("01/01/2014"))
                                //No se aceptan fechas anteriores al 1950
                                //Tambien no se aceptan fechas posteriores 2010
                                {
                                    resp = false;
                                    Error.SetError(fec, "FECHA FUERA DE RANGO");
                                    MessageBox.Show("Fecha fuera de rango", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }
                                else
                                {
                                    Error.SetError(fec, "");
                                    if (string.IsNullOrEmpty(sangre.Text))
                                    {
                                        resp = false;
                                        Error.SetError(sangre, "Campo obligatorio");
                                        MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    }
                                    else
                                    {
                                        Error.SetError(sangre, "");

                                        if (string.IsNullOrEmpty(celu.Text))
                                        {
                                            resp = false;
                                            Error.SetError(celu, "Ingrese un número de celular");
                                            MessageBox.Show("Ingrese un número de celular", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                        }
                                        else
                                        {
                                            Error.SetError(celu, "");
                                            if (celu.Text.Length < 7 || celu.Text.Length < 8)
                                            {
                                                resp = false;
                                                Error.SetError(celu, "El celular tiene entre 7 y 8 dígitos");
                                                MessageBox.Show("El celular tiene entre 7 y 8 dígitos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                            }
                                            else
                                            {
                                                Error.SetError(celu, "");
                                                for (int i = 0; i < celu.TextLength; i++)
                                                {
                                                    if ((celu.Text[i] != '1' && celu.Text[i] != '2' && celu.Text[i] != '3' && celu.Text[i] != '4' && celu.Text[i] != '5' && celu.Text[i] != '6' && celu.Text[i] != '7' && celu.Text[i] != '8' && celu.Text[i] != '9' && celu.Text[i] != '0') || (celu.Text[0] != '6' && celu.Text[0] != '7' && celu.Text[0] != '3'))
                                                    {
                                                        resp = false;
                                                        Error.SetError(celu, "Datos no válidos: Ingrese caracteres de texto en este campo");
                                                        MessageBox.Show("Datos no válidos: Ingrese caracteres de texto en este campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                                    }
                                                    else
                                                    {

                                                        Error.SetError(celu, "");
                                                    }
                                                }
                                                for (int i = 0; i < celu.TextLength; i++)
                                                {
                                                    if (celu.Text[i] == ' ')
                                                    {
                                                        resp = false;
                                                        Error.SetError(celu, "No se permiten espacios en este campo");
                                                        MessageBox.Show("No se permiten espacios en este campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                                    }
                                                    else
                                                    {

                                                        Error.SetError(celu, "");
                                                    }
                                                }
                                                //Siguiente dato

                                                for (int i = 0; i < correo.TextLength; i++)
                                                {
                                                    if ((correo.Text[i] != '@' && correo.Text[i] == 'g' && correo.Text[i] == 'm' && correo.Text[i] == 'a' && correo.Text[i] == 'i' && correo.Text[i] == 'l' && correo.Text[i] == '.' && correo.Text[i] == 'c' && correo.Text[i] == 'o' && correo.Text[i] == 'm') ||
                                                          (correo.Text[i] != '@' && correo.Text[i] == 'h' && correo.Text[i] == 'o' && correo.Text[i] == 't' && correo.Text[i] == 'm' && correo.Text[i] == 'a' && correo.Text[i] == 'i' && correo.Text[i] == 'l' && correo.Text[i] == '.' && correo.Text[i] == 'c' && correo.Text[i] == 'o' && correo.Text[i] == 'm') || (correo.Text[i] == ' '))
                                                    {
                                                        resp = false;
                                                        Error.SetError(correo, "Ingresa el correo electrónico correctamente");
                                                        MessageBox.Show("Ingresa el correo electrónico correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                                    }
                                                    else
                                                    {
                                                        Error.SetError(correo, "");

                                                    }
                                                }
                                                if (string.IsNullOrEmpty(num.Text))
                                                {
                                                    resp = false;
                                                    Error.SetError(num, "Ingrese un número de celular");
                                                    MessageBox.Show("Ingrese un número de celular", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                                }
                                                else
                                                {
                                                    Error.SetError(num, "");
                                                    if (num.Text.Length < 8)
                                                    {
                                                        resp = false;
                                                        Error.SetError(num, "El número tiene entre 7 y 8 dígitos");
                                                        MessageBox.Show("El número tiene entre 7 y 8 dígitos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                                    }
                                                    else
                                                    {
                                                        Error.SetError(num, "");
                                                        for (int i = 0; i < num.TextLength; i++)
                                                        {
                                                            if ((num.Text[i] != '1' && num.Text[i] != '2' && num.Text[i] != '3' && num.Text[i] != '4' && num.Text[i] != '5' && num.Text[i] != '6' && num.Text[i] != '7' && num.Text[i] != '8' && num.Text[i] != '9' && num.Text[i] != '0') || (num.Text[0] != '6' && num.Text[0] != '7' && celu.Text[0] != '3'))
                                                            {
                                                                resp = false;
                                                                Error.SetError(num, "Datos no válidos: Ingrese caracteres de texto en este campo");
                                                                MessageBox.Show("Datos no válidos: Ingrese caracteres de texto en este campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                                            }
                                                            else
                                                            {

                                                                Error.SetError(num, "");
                                                            }
                                                        }
                                                        for (int i = 0; i < num.TextLength; i++)
                                                        {
                                                            if (num.Text[i] == ' ')
                                                            {
                                                                resp = false;
                                                                Error.SetError(num, "No se permiten espacios en este campo");
                                                                MessageBox.Show("No se permiten espacios en este campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                                            }
                                                            else
                                                            {

                                                                Error.SetError(num, "");
                                                            }
                                                        }
                                                        //Siguiente dato
                                                        if (string.IsNullOrEmpty(cargo.Text))
                                                        {
                                                            resp = false;
                                                            Error.SetError(cargo, "Campo obligatorio");
                                                            MessageBox.Show("Campo obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                                        }
                                                        else
                                                        {
                                                            Error.SetError(cargo, "");

                                                            for (int v = 0; v < dgv2.Rows.Count - 1; v++)
                                                            {
                                                                if (apellidos.Text == dgv2.Rows[v].Cells[2].Value.ToString() && nombre.Text == dgv2.Rows[v].Cells[3].Value.ToString()  && dgv2.Rows[v].Cells[6].Value.ToString() == "Emergencia")
                                                                {
                                                                    resp = false;
                                                                    MessageBox.Show("El voluntario se encuentra en una misión, no está permitido cambiar sus datos hasta que retorne.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                    Error.SetError(apellidos, "Voluntario en misión");
                                                                }
                                                                else
                                                                {
                                                                    Error.SetError(apellidos, "");
                                                                }


                                                            }


                                                        }

                                                    }

                                                }
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
        }
        #endregion
    }
}
