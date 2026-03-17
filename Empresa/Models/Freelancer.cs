using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public class Freelancer : Colaborador
    {
        public int HorasExtra { get; set; }
        public double ValorHora { get; set; }

        public Freelancer(int id, string nome, double baseSal, int hrs, double vlr)
            : base(id, nome, baseSal)
        {
            HorasExtra = hrs;
            ValorHora = vlr;
        }

        public override double CalcularVencimento()
        {
            return SalarioBase + (HorasExtra * ValorHora);
        }
    }
}
