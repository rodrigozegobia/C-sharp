using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Exercicio6
{
    public partial class calculadoraIMC : Form
    {
        Paciente Pac1 = new Paciente();

        public calculadoraIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Pac1.nome = txtNome.Text;
            try
            {
                Pac1.altura = float.Parse(txtAltura.Text);
                Pac1.peso = float.Parse(txtPeso.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro nos valores numéricos!");
            }
            Pac1.calcularIMC();

            txtIMC.Text = Pac1.IMC.ToString();
            txtClassific.Clear();
        }

        private void btnClassificar_Click(object sender, EventArgs e)
        {
            Pac1.classificarIMC();
            txtClassific.Text = Pac1.classificacao;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Pac1.imprimirDados());
        }
    }
}
