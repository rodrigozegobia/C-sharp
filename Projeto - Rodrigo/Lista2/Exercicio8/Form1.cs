using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float num1, num2, resultado;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            if (rdbSoma.Checked)
            {
                resultado = num1 + num2;
            }
            else
            {
                if (rdbSubtrai.Checked)
                {
                    resultado = num1 - num2;
                }
                else
                {
                    if (rdbDivide.Checked)
                    {
                        resultado = num1 / num2;                    }
                    else
                    {
                        resultado = num1 * num2;
                    }
                }
            }
            txtResultado.Text = resultado.ToString();
        }
    }
}
