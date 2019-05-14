using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herramientas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/Abraham/Desktop/"+listBox1.Text+".jpg";

        }
    }
}
