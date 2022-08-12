using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5
{
    public partial class Produto : Form
    {
        produto um = new produto();
        produto dois = new produto();
        public Produto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rdbProduto1.Checked)
            {
                um.nome = txtNome.Text;
                um.quantidade = int.Parse(txtQuantidade.Text);
                um.preco = float.Parse(txtPreco.Text);
            }
            else if (rdbProduto2.Checked)
            {
                dois.nome = txtNome.Text;
                dois.quantidade = int.Parse(txtQuantidade.Text);
                dois.preco = float.Parse(txtPreco.Text);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (rdbProduto1.Checked)
            {
                MessageBox.Show("Produto 1:\n\nNome:" + um.nome + "\nQuantidade:" + um.quantidade + "\nPreço:" + um.preco);
            }
            else if (rdbProduto2.Checked)
            {
                MessageBox.Show("Produto 2:\n\nNome:" + dois.nome + "\nQuantidade:" + dois.quantidade + "\nPreço:" + dois.preco);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            float total1, total2, total;
            total1 = um.quantidade * um.preco;
            total2 = dois.quantidade * dois.preco;
            total = total1 + total2;
            txtTotal.Text = total.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    class produto
    {
        public string nome;
        public int quantidade;
        public float preco;
    }
}
