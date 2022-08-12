using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4
{
    public partial class DadosAluno : Form
    {
        Aluno a = new Aluno();
        Aluno b = new Aluno();
        int contador = 0;

        public DadosAluno()
        {
            InitializeComponent();
        }


        private void DadosAluno_Load(object sender, EventArgs e)
        {
            txtAluno.Text = "1";
            btnImprimir.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(contador == 0)
            {
                a.nome = txtNome.Text;
                a.media = float.Parse(txtMedia.Text);
                a.nasc = Convert.ToDateTime(txtNasc.Text);
                contador++;
                txtAluno.Text = "2";
                txtNome.Clear();
                txtMedia.Clear();
                txtNasc.Clear();
            }
            else if(contador == 1)
            {
                b.nome = txtNome.Text;
                b.media = float.Parse(txtMedia.Text);
                b.nasc = Convert.ToDateTime(txtNasc.Text);
                MessageBox.Show("Cadastros realizados!");
                btnCadastrar.Enabled = false;
                btnImprimir.Enabled = true;
                txtNome.Clear();
                txtMedia.Clear();
                txtNasc.Clear();
                txtNome.Enabled = false;
                txtMedia.Enabled = false;
                txtNasc.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cadastros já foram realizados!");
            }
        }

        class Aluno
        {
            public string nome;
            public float media;
            public DateTime nasc;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(a.media == b.media)
            {
                MessageBox.Show("Aluno 1:\nNome:" + a.nome + "\nMédia:" + a.media + "\nNasc.:" + a.nasc + "\n\nAluno 2:\nNome:" + b.nome + "\nMédia:" + b.media + "\nNasc.:" + b.nasc + "\n\n Os alunos tiveram a mesma média.");
            }
            else
            {
                if(a.media > b.media)
                {
                    MessageBox.Show("Aluno 1:\nNome:" + a.nome + "\nMédia:" + a.media + "\nNasc.:" + a.nasc + "\n\nAluno 2:\nNome:" + b.nome + "\nMédia:" + b.media + "\nNasc.:" + b.nasc + "\n\n Aluno com a maior média:"+ a.nome);
                }
                else
                {
                    MessageBox.Show("Aluno 1:\nNome:" + a.nome + "\nMédia:" + a.media + "\nNasc.:" + a.nasc + "\n\nAluno 2:\nNome:" + b.nome + "\nMédia:" + b.media + "\nNasc.:" + b.nasc + "\n\n Aluno com a maior média:" + b.nome);
                }
            }
        }
    }
}
