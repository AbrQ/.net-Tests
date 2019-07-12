using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection conexion = new SqlConnection("Data Source=desktop-3ip2h5v;Initial Catalog=Administration;Integrated Security=True");
            conexion.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, conexion);
            DP.Fill(DS);
            conexion.Close();

            return DS;
        }
    }
}
