using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Exercício4
{
    class Aluno
    {
        private int matricula;
        private float nota1, nota2, media;

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public void setNota1(float nota1)
        {
            this.nota1 = nota1;
        }
        public void setNota2(float nota2)
        {
            this.nota2 = nota2;
        }

        public int getMatricula()
        {
            return matricula;
        }
        public float getNota1()
        {
            return nota1;
        }
        public float getNota2()
        {
            return nota2;
        }
        
        public float calculaMedia()
        {
            media = (this.nota1 + this.nota2) / 2;
            return media;
        }
    }
}
