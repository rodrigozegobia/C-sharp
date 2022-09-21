namespace Metodos_Exercicio4
{
    public partial class Calculadora : Form
    {
        Calculator Calc1 = new Calculator();

        public Calculadora()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                Calc1.valor1 = float.Parse(txtValor1.Text);
                Calc1.valor2 = float.Parse(txtValor2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro com os valores numéricos!");
            }

            if (rdbSoma.Checked)
            {
                Calc1.somar();
                txtResultado.Text = Calc1.soma.ToString();
            }
            else
            {
                if (rdbDivide.Checked)
                {
                    Calc1.dividir();
                    txtResultado.Text = Calc1.divisao.ToString();
                }
                else
                {
                    if (rdbMultiplica.Checked)
                    {
                        Calc1.multiplicar();
                        txtResultado.Text = Calc1.multiplicacao.ToString();
                    }
                    else
                    {
                        Calc1.subtrair();
                        txtResultado.Text = Calc1.subtracao.ToString();
                    }
                }
            }
        }
    }
}