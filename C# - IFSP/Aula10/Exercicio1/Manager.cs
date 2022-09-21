using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Manager
    {
        public double salary;

        public Manager(double salary)
        {
            if(salary < 0) throw new Exception("Salário inválido");

            this.salary = salary;
        }

        public void IncreaseSalary()
        {
            salary *= 1.1;
        }

        public void IncreaseSalary(double taxInPercent)
        {
            if(taxInPercent < 0) throw new Exception("A taxa é inválida");

            salary += salary * taxInPercent/100;
        }
    }
}
