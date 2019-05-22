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
    public partial class VentanaUser : FormBase
    {
        public VentanaUser()
        {
            InitializeComponent();
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuario WHERE id_usuario = " + Login.Codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            lblNom.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUs.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblCod.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            string urlFoto = DS.Tables[0].Rows[0]["Foto"].ToString();
            pictureUser.Image = Image.FromFile(urlFoto);
        }
    }
}
