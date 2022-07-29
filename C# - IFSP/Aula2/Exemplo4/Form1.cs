using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo4
{
    public partial class frmQuatro : Form
    {
        public frmQuatro()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = int.Parse(txtNumero1.Text);
            num2 = int.Parse(txtNumero2.Text);
            resultado = num1 + num2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
            txtNumero1.Focus();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = int.Parse(txtNumero1.Text);
            num2 = int.Parse(txtNumero2.Text);
            resultado = num1 - num2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = int.Parse(txtNumero1.Text);
            num2 = int.Parse(txtNumero2.Text);
            resultado = num1 * num2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = int.Parse(txtNumero1.Text);
            num2 = int.Parse(txtNumero2.Text);
            resultado = num1 / num2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
