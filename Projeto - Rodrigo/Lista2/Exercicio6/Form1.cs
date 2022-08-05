using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            int numero, fatorial=1;
            numero = int.Parse(txtNumero.Text);
            for (int i = 1; i <= numero; i++)
            {
                fatorial = fatorial * i;
            }
            txtFatorial.Text = fatorial.ToString();
        }
    }
}
