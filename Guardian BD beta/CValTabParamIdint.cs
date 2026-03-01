using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Guardian_BD_beta
{
    class CValTabParamIdint
    {
        #region "METODOS"

        public bool datosok(ErrorProvider Error, TextBox nom)
        {
            bool resp = true;
            if (string.IsNullOrEmpty(nom.Text))
            {
                resp = false;
                Error.SetError(nom, "Campo obligatorio");
            }
            else
            {
                Error.SetError(nom, "");
            }
            return resp;
        }
        #endregion
    }
}
