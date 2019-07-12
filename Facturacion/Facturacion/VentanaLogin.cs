using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;


namespace Facturacion
{
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }

        public static String Codigo = "";

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account = '{0}' AND password = '{1}'", txtBoxAccount.Text.Trim(), txtBoxPassword.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();
                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtBoxAccount.Text.Trim() && contra == txtBoxPassword.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        VentanaAdmin venAd = new VentanaAdmin();
                        this.Hide();
                        venAd.Show();
                    }
                    else
                    {
                        VentanaUser venUs = new VentanaUser();
                        this.Hide();
                        venUs.Show();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al intentar conectar a la base de datos: " + error.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
