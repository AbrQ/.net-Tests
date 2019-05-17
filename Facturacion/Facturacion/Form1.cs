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
using System.Data;

namespace Facturacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Usuario WHERE account = '{0}' AND password = '{1}'", txtBoxAccount.Text.Trim(), txtBoxPassword.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtBoxAccount.Text.Trim() && contra == txtBoxPassword.Text.Trim())
                {
                    MessageBox.Show("Ha iniciado");
                }
                else
                {
                    MessageBox.Show("Usuario o Password Incorrecto");
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
    }
}
