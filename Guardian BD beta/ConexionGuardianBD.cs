using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Guardian_BD_beta.Properties;
using System.Configuration;

namespace Guardian_BD_beta
{
    public class ConexionGuardianBD
    {
        public static string obtstring()
        {
            return Settings.Default.Guardian_beta2ConnectionString;
        }
        public static SqlConnection ObtConexion()
        {
            SqlConnection conn = new SqlConnection(obtstring());
            return conn;
        }
    }
}
