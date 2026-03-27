using Empresa.Models;

namespace Empresa
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            // Tenta carregar os dados assim que o menu abre
            try
            {
                Empresa.Models.EmpresaInfo.CarregarDadosDaBaseDeDados();   // EmpresaInfo nome da classe onde guardo a lista de colaboradores
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os dados da base de dados: " + ex.Message,
                                "Erro de Ligação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrirRegisto_Click(object sender, EventArgs e)
        {
            FormRegisto reg = new FormRegisto();
            reg.StartPosition = FormStartPosition.CenterScreen; // abrir a janela no centro da tela
            this.Hide();
            reg.ShowDialog();
            EmpresaInfo.CarregarDadosDaBaseDeDados(); //recarrega a bd para garantir que esta atualizado
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