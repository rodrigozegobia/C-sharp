using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        Manager manager = null; 

        public Form1()
        {
            InitializeComponent();
        }

        private void OnBtnRegisterManagerClick(object sender, EventArgs e)
        {
            double salary;

            try
            {
                salary = double.Parse(txtSalary.Text);

                manager = new Manager(salary);

                DisplayMessage("Gerente cadastrado com sucesso");
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

        private void OnBtnIncreaseSalaryClick(object sender, EventArgs e)
        {
            double tax;

            try
            {     
                if(manager == null) throw new Exception("Cadastre um gerente");

                if(IsTextboxEmpty(txtTax))
                {
                    manager.IncreaseSalary();
                    DisplayMessage("Salário aumentado em 10%");
                }
                else
                {
                    tax = double.Parse(txtTax.Text);

                    manager.IncreaseSalary(tax);

                    DisplayMessage("Salário aumentado em " + tax.ToString() + "%");
                }
            }
            catch(Exception exception)
            {
                DisplayMessage(exception.Message);
            }
        }

        private bool IsTextboxEmpty(TextBox textBox)
        {
            return textBox.Text == "";
        }

        private void OnBtnManagerInfoClick(object sender, EventArgs e)
        {
            DisplayMessage("Salário: " + manager.salary);
        }
    }
}
