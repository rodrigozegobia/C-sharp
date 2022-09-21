using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exercício6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Modelo mod1 = new Modelo();

            mod1.setNome(txtNome.Text);
            mod1.setSobrenome(txtSobrenome.Text);
            mod1.setIdade(Convert.ToInt32(txtIdade.Text));
            mod1.setSexo(Convert.ToChar(txtSexo.Text));
            mod1.setTitulacao(txtTitulacao.Text);
            mod1.setNaturalidade(txtNaturalidade.Text);
            mod1.setEndereco(txtEndereco.Text);
            mod1.setCidade(txtCidade.Text);
            mod1.setEstado(txtEstado.Text);

            MessageBox.Show(mod1.retornaFrase());
        }
    }
}
