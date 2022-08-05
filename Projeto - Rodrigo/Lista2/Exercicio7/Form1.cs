using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(txtNumero.Text);

            if (rdbAntecessor.Checked)
            {
                numero--;
            }
            else
            {
                numero++;
            }
            txtNumero.Text = numero.ToString();
        }
    }
}
