using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;

            foreach (Control Item in Objeto.Controls)
            {
                if (Item is ErrorTxtBox)
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;

                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "No puedo estar vacio");
                            HayErrores = true;
                        }
                    }
                    if (Obj.SoloNumeros == true)
                    {
                        int contador = 0, LetrasEncontradas = 0;
                        foreach (char letra in Obj.Text.Trim())
                        {
                            if (char.IsLetter(Obj.Text.Trim(), contador))
                            {
                                LetrasEncontradas++;
                            }
                            contador++;
                        }
                        if (LetrasEncontradas != 0)
                        {
                            HayErrores = true;
                            ErrorProvider.SetError(Obj, "Solo números");
                        }
                    }
                }
            }
            return HayErrores;
        }
    }
}
