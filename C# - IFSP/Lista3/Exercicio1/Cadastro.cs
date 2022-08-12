using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        Cadastro c = new Cadastro();

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            c.nome = txtNomeIn.Text;
            c.idade = int.Parse(txtIdadeIn.Text);

            txtNomeOut.Text = c.nome;
            txtIdadeOut.Text = c.idade.ToString();
        }
    }
    class Cadastro
    {
        public string nome;
        public int idade;
    }
}
