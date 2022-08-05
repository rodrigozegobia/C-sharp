using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            float num1, num2, num3, num4, media;
            num1 = float.Parse(txtNumero1.Text);
            num2 = float.Parse(txtNumero2.Text);
            num3 = float.Parse(txtNumero3.Text);
            num4 = float.Parse(txtNumero4.Text);
            media = (num1 + num2 + num3 + num4) / 4;

            txtMedia.Text = media.ToString();
        }
    }
}
