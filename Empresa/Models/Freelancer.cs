using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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



        public void InserirBaseDeDados()    // BASE DE DADOS
        {
            string? connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            if (string.IsNullOrEmpty(connectionString)) return;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string queryColaborador = @"INSERT INTO Colaborador (Nome, SalarioBase) 
                                           VALUES (@Nome, @SalarioBase);
                                           SELECT SCOPE_IDENTITY();";
                using (SqlCommand sqlCommand = new SqlCommand(queryColaborador, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Nome", Nome);
                    sqlCommand.Parameters.AddWithValue("@SalarioBase", SalarioBase);
                    int idGerado = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    this.Id = idGerado;
                }


                string queryFreelancer = @"INSERT INTO Freelancer (ColaboradorId, HorasExtra, ValorHora) 
                                           VALUES (@ColaboradorId, @HorasExtra, @ValorHora);";

                using (SqlCommand sqlCommand = new SqlCommand(queryFreelancer, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@ColaboradorId", this.Id);
                    sqlCommand.Parameters.AddWithValue("@HorasExtra", this.HorasExtra);
                    sqlCommand.Parameters.AddWithValue("@ValorHora", this.ValorHora);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public override double CalcularVencimento()
        {
            return SalarioBase + (HorasExtra * ValorHora);
        }
    }
}
