using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exercício4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Aluno alu1 = new Aluno();

        private void btnCalculaMedia_Click(object sender, EventArgs e)
        {
            try
            {
                alu1.setMatricula(Convert.ToInt32(txtMatricula.Text));
                alu1.setNota1(float.Parse(txtNota1.Text));
                alu1.setNota2(float.Parse(txtNota2.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro nos valores numéricos!");
            }

            txtMedia.Text = alu1.calculaMedia().ToString();
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matrícula: " + alu1.getMatricula() + "\nNota 1: " + alu1.getNota1() + "\nNota 2: " + alu1.getNota2() + "\nMédia: "+ alu1.calculaMedia());
        }
    }
}
