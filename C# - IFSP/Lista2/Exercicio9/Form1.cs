using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConceito_Click(object sender, EventArgs e)
        {
            float nota;
            nota = float.Parse(txtNota.Text);
            if (nota < 4.9)
            {
                MessageBox.Show(txtNome.Text + " seu conceito é D");
            }
            else
            {
                if (nota < 6.9)
                {
                    MessageBox.Show(txtNome.Text + " seu conceito é C");
                }
                else
                {
                    if (nota < 8.9)
                    {
                        MessageBox.Show(txtNome.Text + " seu conceito é B");
                    }
                    else
                    {
                        MessageBox.Show(txtNome.Text + " seu conceito é A");
                    }
                }
            }
        }
    }
}
