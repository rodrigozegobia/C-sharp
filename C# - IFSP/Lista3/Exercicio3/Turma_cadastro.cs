using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class Turma_cadastro : Form
    {
        public Turma_cadastro()
        {
            InitializeComponent();
        }

        Turma a = new Turma();
        Turma b = new Turma();
        char turma1 = 'a';
        char turma2 = 'b';
        int contador = 1;
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (contador == 1)
            {
                a.periodo = txtPeriodo.Text;
                a.serie = int.Parse(txtSerie.Text);
                a.sigla = txtSigla.Text;
                a.ensino = txtEnsino.Text;
                contador++;
                txtTurma.Text = turma2.ToString();
                txtPeriodo.Clear();
                txtSerie.Clear();
                txtSigla.Clear();
                txtEnsino.Clear();
            }
            else if (contador ==2)
            {
                b.periodo = txtPeriodo.Text;
                b.serie = int.Parse(txtSerie.Text);
                b.sigla = txtSigla.Text;
                b.ensino = txtEnsino.Text;
                contador++;
                txtPeriodo.Clear();
                txtSerie.Clear();
                txtSigla.Clear();
                txtEnsino.Clear(); btnMostrar.Enabled = true;
                btnGravar.Enabled = false;
                MessageBox.Show("Turmas cadastradas!");
            }
            else
            {
                MessageBox.Show("Turmas já foram cadastradas!");
            }
        }

        private void Turma_cadastro_Load(object sender, EventArgs e)
        {
            txtTurma.Text = turma1.ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turma a:\nPeríodo:" + a.periodo + "\nSérie:" + a.serie + "\nSigla:" + a.sigla + "\nEnsino:" + a.ensino + "\n\nTurma b:\nPeríodo:" + b.periodo + "\nSérie:" + b.serie + "\nSigla:" + b.serie + "\nEnsino:" + a.ensino);
        }
    }
    class Turma
    {
        public string periodo;
        public int serie;
        public string sigla;
        public string ensino;
    }
}
