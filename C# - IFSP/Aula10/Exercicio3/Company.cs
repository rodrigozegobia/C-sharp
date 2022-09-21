using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Company
    {
        public string name;
        public string address;
        public string city;
        public string state;
        public double equityValue;
        public int employeeQuantity;

        public Company()
        {
            name = "";
            address = "";
            city = "";
            state = "";
            equityValue = 0;
            employeeQuantity = 0;
        }

        public Company(string name, string address, string city, string state,
            double equityValue, int employeeQuantity)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.equityValue = equityValue;
            this.employeeQuantity = employeeQuantity;
        }

        public string Print()
        {
            return 
                "Nome da empresa: " + name + "\n" +
                "Endereço: " + address + "\n" +
                "Cidade: " + city + "\n" +
                "Estado: " + state + "\n" +
                "Valor patrimonial: " + equityValue + "\n" +
                "Quantidade de funcionários: " + employeeQuantity + "\n";
        }

    }
}
