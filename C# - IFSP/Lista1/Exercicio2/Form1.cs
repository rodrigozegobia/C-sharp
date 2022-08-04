namespace teste
{
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            btnClique.Enabled = false;
            btnClique.Text = "Estou desabilitado!";
        }
    }
}