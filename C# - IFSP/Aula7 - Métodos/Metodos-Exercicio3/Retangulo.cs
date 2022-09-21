using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Exercicio3
{
    class Retangulo
    {
        public float altura, baseRet, perimetro, area;

        public void calcularArea()
        {
            area = baseRet * altura;
        }

        public void calcularPerimetro()
        {
            perimetro = (2 * baseRet) + (2 * altura);
        }

        public string retornaBaseAltura()
        {
            return "\nBase: " + baseRet + "\nAltura: " + altura;
        }
    }
}
