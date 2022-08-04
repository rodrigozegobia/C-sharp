using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo2
{
    public partial class frmExemplo2 : Form
    {
        public frmExemplo2()
        {
            InitializeComponent();
        }

        private void frmExemplo2_Load(object sender, EventArgs e)
        {

        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            string Ling="";

            if(ckbLingC.Checked)
            {
                Ling = Ling + "C/C++\n";
            }
            if (ckbCSharp.Checked)
            {
                Ling = Ling + "C#\n";
            }
            if (ckbJava.Checked)
            {
                Ling = Ling + "Java\n";
            }
            if (ckbPython.Checked)
            {
                Ling = Ling + "Python\n";
            }

            MessageBox.Show("Linguagens selecionadas: " + Ling );
        }
    }
}
