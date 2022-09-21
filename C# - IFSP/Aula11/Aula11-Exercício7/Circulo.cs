using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Exercício7
{
    internal class Circulo
    {
        private double raio, area, perimetro;

        public void setRaio(double raio)
        {
            this.raio = raio;
        }
        public double getRaio()
        {
            return raio;
        }
        public void calcularArea()
        {
            area = 3.141516 * raio * raio;
        }
        public double getArea()
        {
            return area;
        }
        public void calcularPerimetro()
        {
            perimetro = 2 * 3.141516 * raio;
        }
        public double getPerimetro()
        {
            return perimetro;
        }
        public string imprimir()
        {
            return "Raio: " + raio + "\nÁrea: " + area + "\nPerímetro: " + perimetro;
        }
    }
}
