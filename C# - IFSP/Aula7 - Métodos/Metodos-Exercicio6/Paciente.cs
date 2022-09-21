using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Exercicio6
{
    internal class Paciente
    {
        public string nome, classificacao;
        public float peso, altura, IMC;

        public void calcularIMC()
        {
            IMC = peso / (altura * altura);
        }

        public void classificarIMC()
        {
            if(IMC < 18.5)
            {
                classificacao = "Abaixo do peso.";
            }
            else
            {
                if (IMC < 24.9)
                {
                    classificacao = "Peso ideal, parabéns!";
                }
                else
                {
                    if (IMC < 29.9)
                    {
                        classificacao = "Levemente acima do peso.";
                    }
                    else
                    {
                        if (IMC < 34.9)
                        {
                            classificacao = "Obesidade grau I";
                        }
                        else
                        {
                            if (IMC < 39.9)
                            {
                                classificacao = "Obesidade grau II (severa)";
                            }
                            else
                            {
                                classificacao = "Obesidade III (mórbida)";
                            }
                        }
                    }
                }
            }
        }

        public string imprimirDados()
        {
            return "Nome: " + nome + "\nPeso: " + peso + "\nAltura: " + altura + "\nIMC: " + IMC + "\nClassificação: " + classificacao;
        }
    }
}
