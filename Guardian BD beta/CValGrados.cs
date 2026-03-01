using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Guardian_BD_beta
{
    class CValGrados
    {
        #region "METODOS"

        public bool datosok(ErrorProvider Error, TextBox id, TextBox grado, TextBox cate)
        {
            bool resp = true;
            if (string.IsNullOrEmpty(id.Text))
            {
                resp = false;
                Error.SetError(id, "Campo obligatorio");
            }
            else
            {
                Error.SetError(id, "");
                if (string.IsNullOrEmpty(grado.Text))
                {
                    resp = false;
                    Error.SetError(grado, "Campo obligatorio");
                }
                else
                {
                    Error.SetError(grado, "");
                    if (string.IsNullOrEmpty(cate.Text))
                    {
                        resp = false;
                        Error.SetError(cate, "Campo obligatorio");
                    }
                    else
                    {
                        Error.SetError(cate, "");
                        

                            }
                        
                    
                }

            }
            return resp;
            #endregion
        }

    }
}
