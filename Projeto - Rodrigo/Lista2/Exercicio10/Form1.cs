using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
            {
                MessageBox.Show("Dados do funcionário: \nNome: " + txtNome.Text + "\nDependentes: Sim\n" + "Sexo: " + cmbSexo.SelectedItem);
            }
            else
            {
                MessageBox.Show("Dados do funcionário: \nNome: " + txtNome.Text + "\nDependentes: Não\n" + "Sexo: " + cmbSexo.SelectedItem);
            }
        }
    }
}
