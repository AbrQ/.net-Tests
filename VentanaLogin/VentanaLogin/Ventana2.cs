using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaLogin
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void btnCompar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string seleccion = "";

            if (checkPHP.Checked == true)
            {
                cont++;
            }
            if (checkJava.Checked == true) 
            {
                cont++;
            }
            if (rdbtnTarjetaCredito.Checked == true){
                seleccion = "Tarjeta de crédito";
            }
            if (rdbtnEfectivo.Checked == true){
                seleccion = "Efectivo";
            }

            MessageBox.Show("You have been selecting: " +cont+ " courses with payment type: " +seleccion);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ventanaInicial = new Form1();
            ventanaInicial.Show();
        }
    }
}
