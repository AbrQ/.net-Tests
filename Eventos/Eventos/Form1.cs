using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Over(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/Abraham/Pictures/halo.jpg";
        }

        private void Leave(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/Abraham/Pictures/wallpaper1.png";
        }
    }
}
