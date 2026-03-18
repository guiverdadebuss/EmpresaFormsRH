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
    public partial class FormRegisto : Form
    {
        public FormRegisto()
        {
            InitializeComponent();
            panelEfetivo.Visible = false;
            panelFreelancer.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isEfetivo = comboBoxTipoEmpregado.SelectedIndex == 0;
            bool isFreelancer = comboBoxTipoEmpregado.SelectedIndex == 1;

            panelEfetivo.Visible = isEfetivo;
            panelFreelancer.Visible = isFreelancer;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Verificar se algum tipo de contrato foi selecionado
            if (comboBoxTipoEmpregado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o tipo de empregado antes de guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Criar variáveis para validar os campos comuns
            string nome = "";
            double salario = 0;

            // 3. Validação específica por painel
            if (comboBoxTipoEmpregado.SelectedIndex == 0) // Efetivo
            {
                nome = txtNomeEfetivo.Text.Trim();
                salario = (double)numSalarioEfetivo.Value;

                if (string.IsNullOrEmpty(nome))
                {
                    MessageBox.Show("O nome do funcionário efetivo é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeEfetivo.Focus();
                    return;
                }

                if (salario <= 0)
                {
                    MessageBox.Show("O salário base deve ser superior a zero.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Se passar nas validações, cria o objeto
                int novoId = EmpresaContext.ListaColaboradores.Count + 1;
                // Nota: Assumi um valor de subsídio padrão já que não vi o campo no teu print, 
                // mas podes usar um numSubsidio.Value se o tiveres.
                Efetivo novo = new Efetivo(novoId, nome, salario, 150.00);
                EmpresaContext.ListaColaboradores.Add(novo);
            }
            else // Freelancer
            {
                nome = txtNomeFree.Text.Trim();
                salario = (double)numSalarioFree.Value;
                int horas = (int)numHorasExtras.Value;
                double valorH = (double)numValorHora.Value;

                if (string.IsNullOrEmpty(nome))
                {
                    MessageBox.Show("O nome do freelancer é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeFree.Focus();
                    return;
                }

                if (valorH <= 0)
                {
                    MessageBox.Show("O valor por hora deve ser preenchido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int novoId = EmpresaContext.ListaColaboradores.Count + 1;
                Freelancer novo = new Freelancer(novoId, nome, salario, horas, valorH);
                EmpresaContext.ListaColaboradores.Add(novo);
            }

            MessageBox.Show("Colaborador registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
