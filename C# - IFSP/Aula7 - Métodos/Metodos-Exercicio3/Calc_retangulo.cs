using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Exercicio3
{
    public partial class Calc_retangulo : Form
    {
        Retangulo Retan1 = new Retangulo();

        public Calc_retangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Retan1.altura = float.Parse(txtAltura.Text);
                Retan1.baseRet = float.Parse(txtBase.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro com os valores numéricos!");
            }
            Retan1.calcularArea();
            Retan1.calcularPerimetro();
            MessageBox.Show(Retan1.retornaBaseAltura());
            txtArea.Text = Retan1.area.ToString();
            txtPerimetro.Text = Retan1.perimetro.ToString();
        }
    }
}
