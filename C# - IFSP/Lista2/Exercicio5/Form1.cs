using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5
{
    public partial class frmExercicio5 : Form
    {
        int contagem;
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            contagem++;
            txtContagem.Text = contagem.ToString();
        }
    }
}
