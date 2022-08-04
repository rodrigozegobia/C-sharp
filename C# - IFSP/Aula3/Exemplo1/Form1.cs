using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo1
{
    public partial class FrmExemplo1 : Form
    {
        string genero; //variável global
        public FrmExemplo1()
        {
            InitializeComponent();
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Masculino";
            lblMensagem.Text = genero;
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Feminino";
            lblMensagem.Text = genero;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(rdbFeminino.Checked == true)
            {
                MessageBox.Show("Feminino selecionado", "Verificação");
            }
            else
            {
                MessageBox.Show("Masculino selecionado", "Verificação");
            }
        }
    }
}
