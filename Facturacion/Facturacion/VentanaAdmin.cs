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
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuario WHERE id_usuario = " + Login.Codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            lblAd.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUs.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblCod.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            string urlFoto = DS.Tables[0].Rows[0]["Foto"].ToString();
            pictureAdmin.Image = Image.FromFile(urlFoto);
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
