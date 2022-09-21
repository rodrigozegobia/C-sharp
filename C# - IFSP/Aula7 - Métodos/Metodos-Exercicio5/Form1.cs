using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Exercicio5
{
    public partial class Form1 : Form
    {
        Funcionario Func1 = new Funcionario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Func1.nome = txtNome.Text;
            Func1.salario = double.Parse(txtSalario.Text);
            txtNovoSalario.Clear();
        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            Func1.aumentaSalario();
            txtNovoSalario.Text = Func1.salario.ToString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Func1.retornaDados());
        }
    }
}
