using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Exercício2
{
    class Bola
    {
        private string cor, material;
        private double circunferencia;

        public string getCor()
        {
            return cor;
        }
        public string getMaterial()
        {
            return material;
        }
        public double getCircunferencia()
        {
            return circunferencia;
        }
        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public void setMaterial(string material)
        {
            this.material = material;
        }
        public void setCircunferencia(double circunferencia)
        {
            this.circunferencia = circunferencia;
        }
    }
}
