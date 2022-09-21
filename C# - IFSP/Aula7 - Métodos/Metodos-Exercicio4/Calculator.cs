using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Exercicio4
{
    internal class Calculator
    {
        public float soma, multiplicacao, subtracao, divisao, valor1, valor2;

        public void somar()
        {
            soma = valor1 + valor2;
        }

        public void multiplicar()
        {
            multiplicacao = valor1 * valor2;
        }

        public void dividir()
        {
            divisao = valor1 / valor2;
        }

        public void subtrair()
        {
            subtracao = valor1 - valor2;
        }
    }
}
