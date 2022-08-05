using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            if (ckbCinema.Checked)
            {
                mensagem = mensagem + ckbCinema.Text;
            }
            if (ckbDormir.Checked)
            {
                mensagem = mensagem + "\n" + ckbDormir.Text;
            }
            if (ckbComer.Checked)
            {
                mensagem = mensagem + "\n" + ckbComer.Text;
            }
            if (ckbLerlivro.Checked)
            {
                mensagem = mensagem + "\n" + ckbLerlivro.Text;
            }
            if (ckbEstudar.Checked)
            {
                mensagem = mensagem + "\n" + ckbEstudar.Text;
            }
            MessageBox.Show("" + mensagem);
        }
    }
}
