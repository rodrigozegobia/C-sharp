using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo3
{
    public partial class frmTres : Form
    {
        public frmTres()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOriginal_TextChanged(object sender, EventArgs e)
        {
            txtCopia.Text = txtOriginal.Text;
        }

        private void txtOriginal_Click(object sender, EventArgs e)
        {
            txtOriginal.Clear();
        }
    }
}
