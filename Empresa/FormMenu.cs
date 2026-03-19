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
            FormRegisto reg = new FormRegisto();
            reg.ShowDialog();

        }

        private void btnAbrirDetalhes_Click(object sender, EventArgs e)
        {
            FormDetalhes det = new FormDetalhes();
            det.ShowDialog();

        }

        private void btnAbrirEstatisticas_Click(object sender, EventArgs e)
        {
            FormEstatisticas est = new FormEstatisticas();
            est.ShowDialog();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}