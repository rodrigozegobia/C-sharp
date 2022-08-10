using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula7
{
    public partial class frmExer11 : Form
    {
        public frmExer11()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int a, b, c, t;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            c = int.Parse(txtC.Text);

            if (a > b)
            {
                t = a;
                a = b;
                b = t;
            }
            if (a > c)
            {
                t = a;
                a = c;
                c = t;
            }
            if (c < b)
            {
                t = c;
                c = b;
                b = t;
            }

            txtUm.Text = a.ToString();
            txtDois.Text = b.ToString();
            txtTres.Text = c.ToString();
        }
    }
}
