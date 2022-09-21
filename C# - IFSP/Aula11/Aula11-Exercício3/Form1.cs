using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exercício3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            Quadrado q1 = new Quadrado();

        private void btnGravar_Click(object sender, EventArgs e)
        {

            q1.setLado(Convert.ToDouble(txtLado.Text));

            MessageBox.Show("Lado: " + q1.getLado());
        }

        private void btnCalculaArea_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área: " + q1.calcularArea());
        }
    }
}
