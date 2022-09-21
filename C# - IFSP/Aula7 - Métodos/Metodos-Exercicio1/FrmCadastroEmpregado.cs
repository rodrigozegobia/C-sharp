using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Exercicio1
{
    public partial class frmExercicio1 : Form
    {
        Empregado emp1 = new Empregado();

        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            emp1.nome = txtNome.Text;
            emp1.departamento = txtDepartamento.Text;

            try //digiar try e apertar tab 2 vezes
            {
                emp1.horasTrabalhadasNoMes = Convert.ToDouble(txtHoras.Text); //pode usar parse também
                emp1.salarioPorHora = Double.Parse(txtValorHora.Text);//pode usar convert também
            }
            catch (Exception) //pode ser (Exception x) com Messagebox.Show(x.Message);
            {
                MessageBox.Show("Ocorreu algum erro nos valores numéricos!");
            }
            //finally
            //{
            //  Messagebox.Show("Está mensagem sempre aparecerá!");
            //}
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(emp1.mostraDados());
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sálario mensal: " + emp1.calculaSalarioMensal());
        }
    }
}
