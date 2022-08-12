using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Cadastro_cliente : Form
    {
        public Cadastro_cliente()
        {
            InitializeComponent();
        }

        Cliente c = new Cliente();

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            c.nome = txtNomeIn.Text;
            c.codigo = int.Parse(txtCodigoIn.Text);
            c.salario = Convert.ToDouble(TxtSalarioIn.Text);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtNomeOut.Text = c.nome;
            txtCodigoOut.Text = c.codigo.ToString();
            txtSalarioOut.Text = c.salario.ToString();
        }
    }
    class Cliente
    {
        public string nome;
        public int codigo;
        public double salario;
    }
}
