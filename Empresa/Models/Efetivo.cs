using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public class Efetivo : Colaborador
    {
        public double SubsidioAlimentacao { get; set; }

        public Efetivo(int id, string nome, double salarioBase, double subsidio)
            : base(id, nome, salarioBase)
        {
            SubsidioAlimentacao = subsidio;
        }

        public override double CalcularVencimento()
        {
            // Aplicando a regra: Base + Subsídio - Descontos (ex: 11% Segurança Social)
            double impostos = GetSalarioBase() * 0.11;
            return GetSalarioBase() + SubsidioAlimentacao - impostos;
        }
    }
}

