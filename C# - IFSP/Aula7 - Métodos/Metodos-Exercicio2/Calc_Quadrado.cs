using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Exercicio2
{
    public partial class Calc_Quadrado : Form
    {
        Quadrado quad1 = new Quadrado();
        public Calc_Quadrado()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                quad1.lado = float.Parse(txtLado.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro no valor númerico!");
            }
            quad1.calcularArea();
            quad1.calcularPerimetro();
            txtPerimetro.Text = quad1.perimetro.ToString();
            txtArea.Text = quad1.area.ToString();
        }
    }
}
