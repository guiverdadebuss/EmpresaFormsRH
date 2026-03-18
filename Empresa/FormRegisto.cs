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
            if (comboBoxTipoEmpregado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o tipo de empregado antes de guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nome = "";
            double salario = 0;
            double subsidio = 0;
            if (comboBoxTipoEmpregado.SelectedIndex == 0) // Efetivo
            {
                nome = txtNomeEfetivo.Text.Trim();
                salario = (double)numSalarioEfetivo.Value;
                subsidio = (double)numSubsidio.Value;

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
                if (subsidio <= 0)
                {
                    MessageBox.Show("O subsidio deve ser superior a zero.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int novoId = EmpresaContext.ListaColaboradores.Count + 1;
                Efetivo novo = new Efetivo(novoId, nome, salario, subsidio);
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
                if (salario < 0)
                {
                    MessageBox.Show("O valor do salario não pode ser negativo.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (horas < 0)
                {
                    MessageBox.Show("A quantidade de horas não pode ser negativo.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
