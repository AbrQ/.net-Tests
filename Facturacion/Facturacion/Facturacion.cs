using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Facturacion
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios Where id_usuario= " + Login.Codigo;
            DataSet ds;
            ds = Utilidades.Ejecutar(cmd);
            lblLeAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == false)
                {
                    string cmd = string.Format("Select Nom_cli From cliente where id_clientes = '{0}'", txtCodigo.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    txtCliente.Text = ds.Tables[0].Rows[0]["Nom_cli"].ToString().Trim();

                    txtCodigoPro.Focus();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha detectado un error: "+error);
            }
        }
    }
}
