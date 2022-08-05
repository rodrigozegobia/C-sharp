using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class FrmEx1 : Form
    {
        int numero, resultado;
        public FrmEx1()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if(rbmDobrar.Checked == true)
            {
                numero = int.Parse(txtNumero.Text);
                resultado = (numero * 2);
            }
            else
            {
                numero = int.Parse(txtNumero.Text);
                resultado = (numero * 3);
            }
            txtResultado.Text = resultado.ToString();
        }
    }
}
