using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto___Rodrigo
{
    public partial class frmUm : Form
    {
        public frmUm()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo!");
        }

        private void frmUm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Carregando..");
        }
    }
}
