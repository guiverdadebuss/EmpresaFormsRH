using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public abstract class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        protected double SalarioBase { get; set; }
        public Colaborador(int id, string nome, double salarioBase)
        {
            Id = id;
            Nome = nome;
            SalarioBase = salarioBase;
        }
        public abstract double CalcularVencimento();
        public double GetSalarioBase() => SalarioBase;
    }
}
