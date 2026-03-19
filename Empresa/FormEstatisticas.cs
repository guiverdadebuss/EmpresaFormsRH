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
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            CalcularEstatisticas();
        }
        private void CalcularEstatisticas()
        {
            var lista = EmpresaContext.ListaColaboradores;

            // 1. Verificação de segurança: se não houver dados, não calculamos
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Não existem colaboradores registados para gerar estatísticas.", "Informação");
                return;
            }

            // 2. Número de colaboradores
            lblNumColaboradores.Text = lista.Count.ToString();

            // 3. Valor Total Gasto Mensal (Polimorfismo em ação)
            double totalGasto = lista.Sum(c => c.CalcularVencimento());
            lbl23.Text = totalGasto.ToString("C2");

            // 4. Média Salário Base (Encapsulamento: usa o GetSalarioBase)
            double mediaBase = lista.Average(c => c.GetSalarioBase());
            lblMediaSalarioBase.Text = mediaBase.ToString("C2");

            // 5. Impostos a Pagar (Apenas 11% sobre o salário base dos Efetivos)
            // Filtramos apenas os Efetivos na lista antes de somar
            double impostos = lista.OfType<Efetivo>()
                                   .Sum(ef => ef.GetSalarioBase() * 0.11);
            lblImpostosPagar.Text = impostos.ToString("C2");

            // 6. Empregado mais bem pago
            // Ordenamos a lista pelo vencimento final de forma decrescente e pegamos o primeiro
            var topEmployee = lista.OrderByDescending(c => c.CalcularVencimento()).First();
            lblMaisBemPago.Text = $"{topEmployee.Nome} ({topEmployee.CalcularVencimento():C2})";

            // 7. Estimativa de gasto anual
            double gastoAnual = totalGasto * 12;
            lblGastoAnual.Text = gastoAnual.ToString("C2");
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
