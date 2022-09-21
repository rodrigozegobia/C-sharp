using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Exercicio1
{
    class Empregado
    {
        public string nome, departamento;
        public double horasTrabalhadasNoMes, salarioPorHora;

        public string mostraDados()
        {
            return "Nome: " + nome + "\nDepartamento: " + departamento + "\nHoras trabalhadas: " + horasTrabalhadasNoMes + "\nSálario por hora: " + salarioPorHora;
        }

        public double calculaSalarioMensal()
        {
            return horasTrabalhadasNoMes * salarioPorHora;
        }
    }
}
