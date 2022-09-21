using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exercício7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Circulo c1 = new Circulo();

            c1.setRaio(Convert.ToDouble(txtRaio.Text));
            c1.calcularArea();
            txtArea.Text = c1.getArea().ToString();
            c1.calcularPerimetro();
            txtPerimetro.Text = c1.getPerimetro().ToString();
            MessageBox.Show(c1.imprimir());
        }
    }
}
