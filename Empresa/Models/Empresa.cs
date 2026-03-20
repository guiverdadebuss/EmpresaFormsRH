using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Empresa.Models
{
    public static class EmpresaInfo
    {
        public static List<Colaborador> ListaColaboradores = new List<Colaborador>();

        public static void CarregarDadosDaBaseDeDados()
        {
            string? connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Erro: ConnectionString não configurada!");
                return;
            }

            // Limpa a lista para evitar duplicados se o método for chamado mais de uma vez
            ListaColaboradores.Clear();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    // Query que traz dados do Colaborador e tenta "juntar" com Efetivo ou Freelancer
                    string query = @"
                        SELECT C.Id, C.Nome, C.SalarioBase, 
                                E.SubsidioAlimentacao, 
                                F.HorasExtra, F.ValorHora
                        FROM Colaborador C
                        LEFT JOIN Efetivo E ON C.Id = E.ColaboradorId
                        LEFT JOIN Freelancer F ON C.Id = F.ColaboradorId";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nome = reader.GetString(1);
                                // Conversão de decimal (DB) para double (C#)
                                double salarioBase = Convert.ToDouble(reader.GetDecimal(2));

                                // Se a coluna 3 (Subsidio) não for nula, é um Efetivo
                                if (!reader.IsDBNull(3))
                                {
                                    double subsidio = Convert.ToDouble(reader.GetDecimal(3));
                                    ListaColaboradores.Add(new Efetivo(id, nome, salarioBase, subsidio));
                                }
                                // Se a coluna 4 (HorasExtra) não for nula, é um Freelancer
                                else if (!reader.IsDBNull(4))
                                {
                                    int horas = reader.GetInt32(4);
                                    double valorHora = Convert.ToDouble(reader.GetDecimal(5));
                                    ListaColaboradores.Add(new Freelancer(id, nome, salarioBase, horas, valorHora));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar da Base de Dados: " + ex.Message);
            }
        }
    }
}
