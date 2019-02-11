using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTouch_Click(object sender, EventArgs e)
        {
            var identificacion = txtID.Text;
            using (WSPersonas.WSPersonasClient client = new WSPersonas.WSPersonasClient())
            {
                var persona = client.obtenerPersona(identificacion);
                var nombre = persona.Nombre;
            }
        }
    }
}
