using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public void InserirBaseDeDados()    // BASE DE DADOS
        {
            string? connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            if (string.IsNullOrEmpty(connectionString)) return;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();


                string queryColaborador = "INSERT INTO Colaborador (Nome, SalarioBase)" +
                                          "VALUES (@Nome, @SalarioBase);" +
                                          "SELECT SCOPE_IDENTITY();";
                using (SqlCommand sqlCommand = new SqlCommand(queryColaborador, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Nome", Nome);
                    sqlCommand.Parameters.AddWithValue("@SalarioBase", SalarioBase);

                    int idGerado = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    this.Id = idGerado;
                }


                string queryEfetivo = "INSERT INTO Efetivo (ColaboradorId, SubsidioAlimentacao)" +
                                      "VALUES (@ColaboradorId, @Subsidio);" +
                                      "SELECT SCOPE_IDENTITY();";
                using (SqlCommand sqlCommand = new SqlCommand(queryEfetivo, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@ColaboradorId", this.Id);
                    sqlCommand.Parameters.AddWithValue("@Subsidio", SubsidioAlimentacao);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            
        }


        public override double CalcularVencimento()
        {
            double impostos = GetSalarioBase() * 0.11;
            return GetSalarioBase() + SubsidioAlimentacao - impostos;
        }
    }
}

