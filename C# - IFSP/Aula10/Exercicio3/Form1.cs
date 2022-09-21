using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class Form1 : Form
    {
        Company companyOne = new Company();
        Company companyTwo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnBtnRegisterCompanyClick(object sender, EventArgs e)
        {
            double equityValue; 
            int employeeQty;

            try
            {
                equityValue = double.Parse(txtCompanyEquityValue.Text);
                employeeQty = int.Parse(txtlCompanyEmployeeQty.Text);

                if(rdbStandardConstructor.Checked)
                {
                    SetupCompany(companyOne, txtCompanyName.Text, txtCompanyAddress.Text, txtCompanyCity.Text, 
                        txtCompanyState.Text, equityValue, employeeQty);
                }
                else
                {
                    companyTwo = new Company(txtCompanyName.Text, txtCompanyAddress.Text, txtCompanyCity.Text,
                        txtCompanyState.Text, equityValue, employeeQty);
                }

                DisplayMessage("Empresa salva com sucesso");
            }
            catch(Exception exception)
            {
                DisplayMessage(exception.Message);
            }
        }

        private void SetupCompany(Company company, string name, string address, string city, string state,
            double equityValue, int employeeQty)
        {
            company.name = name;
            company.address = address;
            company.city = city;
            company.state = state;
            company.equityValue = equityValue;
            company.employeeQuantity = employeeQty;
        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void OnBtnShowHighestEquityValueClick(object sender, EventArgs e)
        {
            Company highestEquityValueCompany;

            try
            {
                highestEquityValueCompany = HighestEquityValue(companyOne, companyTwo);

                DisplayMessage(highestEquityValueCompany.Print());
            }
            catch(Exception exception)
            {
                DisplayMessage(exception.Message);
            }
        }

        private Company HighestEquityValue(Company companyOne, Company companyTwo)
        {
            if(companyOne == null || companyTwo == null) throw new Exception("Cadastre as duas empresas (construtor padrão e customizado)");

            return companyOne.equityValue >= companyTwo.equityValue ? companyOne : companyTwo;
        }
    }
}
