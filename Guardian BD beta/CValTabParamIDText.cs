using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Guardian_BD_beta
{
    class CValTabParamIDText
    {
        #region "METODOS"

        public bool datosok(ErrorProvider Error, TextBox idtext, RichTextBox nombre)
        {
            bool resp = true;
            if (string.IsNullOrEmpty(idtext.Text))
            {
                resp = false;
                Error.SetError(idtext, "Campo obligatorio");
            }
            else
            {
                Error.SetError(idtext, "");
                if (string.IsNullOrEmpty(nombre.Text))
                {
                    resp = false;
                    Error.SetError(nombre, "Campo obligatorio");
                }
                else
                {
                    Error.SetError(nombre, "");
                    
            }
                }
            return resp;
            #endregion
        }
    }
}