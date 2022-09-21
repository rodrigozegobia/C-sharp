using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exercício8
{
    public partial class Form1 : Form
    {
        Televisao t1 = new Televisao();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            t1.setMarca(txtMarca.Text);
            t1.setModelo(txtModelo.Text);
            t1.setData(DateTime.Parse(txtData.Text));
            t1.setPreco(Convert.ToDecimal(txtPreco.Text));
            t1.setLCD(Convert.ToBoolean(txtLCD.Text));
            t1.setPolegadas(Convert.ToDecimal(txtPolegadas.Text));

            MessageBox.Show("Marca: " + t1.getMarca() + "\nModelo: " + t1.getModelo() + "\nData: " + t1.getData() + "\nPreço: " +
                t1.getPreco() +"\nPreço+10%: "+t1.getPrecoPlus()+ "\nLCD: " + t1.getLCD() + "\nPolegadas: " + t1.getPolegadas());
        }
    }
}
