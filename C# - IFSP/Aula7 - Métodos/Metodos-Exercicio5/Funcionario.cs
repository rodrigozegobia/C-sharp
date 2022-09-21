using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Exercicio5
{
    internal class Funcionario
    {
        public string nome;
        public double salario;

        public void aumentaSalario()
        {
            if(salario <= 1500)
            {
                salario = salario + (salario * 0.25);
            }
            else
            {
                if (salario <= 4000)
                {
                    salario = salario + (salario * 0.20);
                }
                else
                {
                    salario = salario + (salario * 0.15);
                }
            }
        }

        public string retornaDados()
        {
            return "Nome: " + nome + "\nSálario: " + salario;
        }
    }
}
