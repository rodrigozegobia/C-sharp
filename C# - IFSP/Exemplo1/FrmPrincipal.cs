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
    public partial class frmExemplo1 : Form
    {
        public frmExemplo1()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            FrmCadastro formulario1 = new FrmCadastro();
            formulario1.ShowDialog();
        }

        private void formulário1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro formulario1 = new FrmCadastro();
            formulario1.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formulário2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario formulario2 = new FrmCadastroUsuario();
            formulario2.ShowDialog();
        }
    }
}
