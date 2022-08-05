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
    public partial class FrmExemplo3 : Form
    {
        public FrmExemplo3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmExemplo3_Load(object sender, EventArgs e)
        {
            cmbEstacao.Items.Add("Outono");
            cmbEstacao.Items.Add("Inverno");
            cmbEstacao.Items.Add("Primavera");
            cmbEstacao.Items.Add("Verão");
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolaridade: " + cmbEscolaridade.SelectedItem.ToString() + 
                            "\nEstação: " + cmbEstacao.SelectedItem.ToString());
        }
    }
}
