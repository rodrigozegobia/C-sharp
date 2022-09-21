using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4
{
    public partial class Form1 : Form
    {
        Student studentOne = new Student();
        Student studentTwo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnBtnRegisterStudentClick(object sender, EventArgs e)
        {
            double gradeOne;
            double gradeTwo;

            try
            {
                gradeOne = double.Parse(txtStudentGradeOne.Text);
                gradeTwo = double.Parse(txtStudentGradeTwo.Text);

                if(rdbStandardConstructor.Checked)
                {
                    RegisterStudent(studentOne, txtStudentCode.Text, txtStudentName.Text, 
                        gradeOne, gradeTwo);

                    studentOne.CalculateAverage();
                }
                else
                {
                    studentTwo = new Student(txtStudentCode.Text, txtStudentName.Text,
                        gradeOne, gradeTwo);

                    studentTwo.CalculateAverage();
                }

                DisplayMessage("Aluno cadastrado com sucesso");
            }
            catch(Exception exception)
            {
                DisplayMessage(exception.Message);
            }
        }

        private void RegisterStudent(Student student, string code, string name, 
            double gradeOne, double gradeTwo)
        {
            student.code = code;
            student.name = name;
            student.gradeOne = gradeOne;
            student.gradeTwo = gradeTwo;
        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void OnBtnShowAprovedStudentsClick(object sender, EventArgs e)
        {
            int aprovedStudents = 0;

            try
            {
                if(studentTwo == null) throw new Exception("Cadastre ambos estudantes");

                if(studentOne.StudentStatus() == "Aprovado")
                {
                    DisplayMessage(studentOne.ShowStudentData());

                    aprovedStudents++;
                }

                if(studentTwo.StudentStatus() == "Aprovado")
                {
                    DisplayMessage(studentTwo.ShowStudentData());

                    aprovedStudents++;
                }

                if(aprovedStudents == 0)
                {
                    DisplayMessage("Nenhum aluno foi aprovado");
                }
            }
            catch(Exception exception)
            {
                DisplayMessage(exception.Message);
            }
        }
    }
}
