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
        Triangle triangle;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnBtnSaveClick(object sender, EventArgs e)
        {
            double triangBase, triangHeight;

            try
            {
                triangBase = double.Parse(txtArea.Text);
                triangHeight = double.Parse(txtHeight.Text);

                triangle = new Triangle(triangBase, triangHeight);

                DisplayMessage("Triângulo salvo com sucesso");
            }
            catch(Exception exception)
            {
                DisplayMessage(exception.Message);
            }
        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void OnBtnCalculateAreaClick(object sender, EventArgs e)
        {
            try
            {

                if(triangle == null)
                {
                    throw new Exception("Não há nenhum triângulo salvo");
                }

                DisplayMessage("A área do triângulo equivale a: " + triangle.Area());
            }
            catch(Exception exception)
            {
                DisplayMessage(exception.Message);
            }
        }

    }
}
