using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Student
    {
        public string code;
        public string name;
        public double gradeOne;
        public double gradeTwo;
        double average;

        public Student()
        {
            code = "";
            name = "";
            gradeOne = 0;
            gradeTwo = 0;
            average = 0;
        }

        public Student(string code, string name, double gradeOne, double gradeTwo)
        {
            this.code = code;
            this.name = name;
            this.gradeOne = gradeOne;
            this.gradeTwo = gradeTwo;
            average = 0;
        }

        public void CalculateAverage()
        {
            average = (gradeOne + gradeTwo) / 2;
        }

        public string StudentStatus()
        {
            return average >= 6 ? "Aprovado" : "Reprovado";
        }

        public string ShowStudentData()
        {
            return
                "Código: " + code + "\n" +
                "Nome: " + name + "\n" +
                "Nota 1:" + gradeOne + "\n" +
                "Nota 2: " + gradeTwo + "\n" +
                "Média: " + average + "\n" +
                "Status: " + StudentStatus();
        }

    }
}
