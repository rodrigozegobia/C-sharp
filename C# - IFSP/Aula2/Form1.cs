using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class frmUm : Form
    {
        public frmUm()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boa noite " + txtNome.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
