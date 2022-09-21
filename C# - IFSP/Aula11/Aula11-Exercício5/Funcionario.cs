using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exercício5
{
    internal class Funcionario
    {
        private int idade, anosServico;
        private double salario;

        public int getIdade()
        {
            return idade;
        }
        public int getAnosServico()
        {
            return anosServico;
        }
        public double getSalario()
        {
            return salario;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public void setAnosservico(int anosServico)
        {
            this.anosServico = anosServico;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public string podeAposentar()
        {
            if(this.anosServico >=35 && this.idade > 60)
            {
                return "Já pode se aposentar!";
            }
            else
            {
                return "Não pode se aposentar ainda!";
            }
        }
    }
}
