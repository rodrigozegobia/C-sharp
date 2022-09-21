using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Triangle
    {
        double triangleBase;
        double triangleHeight;

        public Triangle(double triangleBase, double triangleHeight)
        {
            if(triangleBase < 0) throw new Exception("A base do triângulo deve ser maior que zero");
            if(triangleHeight < 0) throw new Exception("A altura do triângulo deve ser maior que zero");

            this.triangleBase = triangleBase;
            this.triangleHeight = triangleHeight;
        }

        public double Area()
        {
            return triangleBase * triangleHeight / 2;
        }
    }
}
