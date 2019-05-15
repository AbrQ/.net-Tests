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

namespace Facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
                conexion.Open();
                MessageBox.Show("La conexión se realizó con éxito");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al conectarse a la base de datos: " +error.Message);
            }
        }
    }
}
