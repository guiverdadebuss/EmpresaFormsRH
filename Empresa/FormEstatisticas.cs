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
            var lista = EmpresaInfo.ListaColaboradores;

            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Não existem colaboradores registados para gerar estatísticas.", "Informação");
                return;
            }

            //Número de colaboradores
            lblNumColaboradores.Text = lista.Count.ToString();

            //Valor Total Gasto Mensal - Polimorfismo   -- C2 usado por razões monetarias CASH MONEY MASCADA
            double totalGasto = lista.Sum(c => c.CalcularVencimento());
            lblValorGasto.Text = totalGasto.ToString("C2");

            //Média Salário Base (Encapsulamento: usa o GetSalarioBase)
            double mediaBase = lista.Average(c => c.GetSalarioBase());
            lblMediaSalarioBase.Text = mediaBase.ToString("C2");

            //Impostos (Apenas 11% sobre o salário base dos Efetivos)
            //Filtro apenas os Efetivos na lista antes de somar
            double impostos = lista.OfType<Efetivo>().Sum(ef => ef.GetSalarioBase() * 0.11);
            lblImpostosPagar.Text = impostos.ToString("C2");

            //Empregado mais bem pago
            //Ordenar a lista pelo vencimento final de forma decrescente e pega o primeiro
            var topEmployee = lista.OrderByDescending(c => c.CalcularVencimento()).First();
            lblMaisBemPago.Text = $"{topEmployee.Nome} ({topEmployee.CalcularVencimento():C2})";

            //Estimativa de gasto anual
            double gastoAnual = totalGasto * 12;
            lblGastoAnual.Text = gastoAnual.ToString("C2");
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
