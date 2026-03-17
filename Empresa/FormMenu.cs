namespace Empresa
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnAbrirRegisto_Click(object sender, EventArgs e)
        {
            Registo reg = new Registo();
            reg.ShowDialog();
          
        }

        private void btnAbrirDetalhes_Click(object sender, EventArgs e)
        {
            Detalhes det = new Detalhes();
            det.ShowDialog();

        }

        private void btnAbrirEstatisticas_Click(object sender, EventArgs e)
        {
            Estatisticas est = new Estatisticas();
            est.ShowDialog();

        }
    }
}