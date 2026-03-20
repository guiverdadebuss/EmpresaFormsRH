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
            reg.StartPosition = FormStartPosition.CenterScreen; // abrir a janela no centro da tela
            this.Hide();
            reg.ShowDialog();
            this.Show();
        }

        private void btnAbrirDetalhes_Click(object sender, EventArgs e)
        {
            FormDetalhes det = new FormDetalhes();
            det.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            det.ShowDialog();
            this.Show();
        }

        private void btnAbrirEstatisticas_Click(object sender, EventArgs e)
        {
            FormEstatisticas est = new FormEstatisticas();
            est.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            est.ShowDialog();
            this.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}