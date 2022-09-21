using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exercício2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Bola b1 = new Bola();

            b1.setCor(txtCor.Text);
            b1.setMaterial(txtMaterial.Text);
            b1.setCircunferencia(Convert.ToDouble(txtCircunferencia.Text));

            MessageBox.Show("Cor: " + b1.getCor() + "\nMaterial: " + b1.getMaterial() + "\nCircunferência: " + b1.getCircunferencia());
        }
    }
}
