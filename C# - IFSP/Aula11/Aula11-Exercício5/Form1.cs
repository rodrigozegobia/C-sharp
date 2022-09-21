using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exercício5
{
    public partial class Form1 : Form
    {
        Funcionario func1 = new Funcionario();
        Funcionario func2 = new Funcionario();
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtFuncionario.Text = "1";
            btnImprime.Enabled = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(contador == 0)
            {
                func1.setSalario(Convert.ToDouble(txtSalario.Text));
                func1.setIdade(Convert.ToInt32(txtIdade.Text));
                func1.setAnosservico(Convert.ToInt32(txtAnosServico.Text));
                MessageBox.Show(func1.podeAposentar());
                contador++;
                txtFuncionario.Text = "2";
                txtSalario.Clear();
                txtIdade.Clear();
                txtAnosServico.Clear();
            }
            else if (contador == 1)
            {
                func2.setSalario(Convert.ToDouble(txtSalario.Text));
                func2.setIdade(Convert.ToInt32(txtIdade.Text));
                func2.setAnosservico(Convert.ToInt32(txtAnosServico.Text));
                MessageBox.Show(func2.podeAposentar());
                btnGravar.Enabled = false;
                btnImprime.Enabled = true;
                txtSalario.Clear();
                txtIdade.Clear();
                txtAnosServico.Clear();
                txtAnosServico.Enabled = false;
                txtSalario.Enabled = false;
                txtIdade.Enabled = false;
            }
            else
            {
                MessageBox.Show("Funcionários já gravados!");
            }
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionário 1:\nSalário: " + func1.getSalario() + "\nIdade: " + func1.getIdade() + "\nAnos em serviço: " + func1.getAnosServico() + "\n" + func1.podeAposentar() +
                "\n\nFuncionário 2:\nSalário: " + func2.getSalario() + "\nIdade: " + func2.getIdade() + "\nAnos em serviço: " + func2.getAnosServico() + "\n" + func2.podeAposentar());
        }
    }
}
