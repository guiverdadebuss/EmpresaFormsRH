using Empresa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class FormDetalhes : Form
    {
        public FormDetalhes()
        {
            InitializeComponent();
        }
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            // O NumericUpDown para garantir que é um número, mas validamos se a lista tem dados
            if (EmpresaContext.ListaColaboradores.Count == 0)
            {
                MessageBox.Show("Não existem colaboradores registados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBusca = (int)numIdProcura.Value; //procura o ID

            var colab = EmpresaContext.ListaColaboradores.FirstOrDefault(c => c.Id == idBusca);

            if (colab != null)
            {
                lblNome.Text = "Nome: " + colab.Nome;
                lblSalarioBase.Text = "Salário Base: " + colab.GetSalarioBase().ToString("C2");
                lblVencimento.Text = "Vencimento Final: " + colab.CalcularVencimento().ToString("C2");

                //Polimorfismo
                if (colab is Efetivo ef)
                {
                    lblTipoContrato.Text = "Tipo: Efetivo";
                    lblExtra.Text = "Subsídio Alimentação: " + ef.SubsidioAlimentacao.ToString("C2");
                }
                else if (colab is Freelancer fr)
                {
                    lblTipoContrato.Text = "Tipo: Freelancer";
                    lblExtra.Text = $"Horas: {fr.HorasExtra} | Valor/Hora: {fr.ValorHora:C2}";
                }
            }
            else
            {
                MessageBox.Show("Colaborador com ID " + idBusca + " não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }
        }
        private void LimparCampos()
        {
            lblNome.Text = "---";
            lblSalarioBase.Text = "---";
            lblVencimento.Text = "---";
            lblTipoContrato.Text = "---";
            lblExtra.Text = "---";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
