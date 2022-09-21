using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Exercício3
{
    class Quadrado
    {
        private double lado, area;

        public double getLado()
        {
            return lado;
        }

        public void setLado(double lado)
        {
            this.lado = lado;
        }

        public double calcularArea()
        {
            this.area = this.lado * this.lado;
            return area;
        }
    }
}
