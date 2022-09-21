using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Exercicio2
{
    class Quadrado
    {
        public float lado, perimetro, area;

        public void calcularArea()
        {
            area = lado * lado;
        }

        public void calcularPerimetro()
        {
            perimetro = 4 * lado;
        }
    }
}
