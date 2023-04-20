using Cod3rsGrowth.Modelos;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Cod3rsGrowth.Repositorio
{
    public class SQLServer : IRepositorio
    {
        private readonly string _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["Cod3rsGrowth"].ConnectionString;
        BindingList<Peca> lista = new BindingList<Peca>();
        public Peca ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public BindingList<Peca> ObterTodas()
        {
            SqlConnection conexaoSql = new SqlConnection(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = new SqlCommand("SELECT * FROM Pecas;", conexaoSql);

            SqlDataReader dr = comandoExecutado.ExecuteReader();

            lista.Clear();

            while (dr.Read())
            {
                var peca = new Peca
                {
                    Id = Convert.ToInt32(dr[0]),
                    Categoria = dr[1].ToString(),
                    Nome = dr[2].ToString(),
                    Descricao = dr[3].ToString(),
                    Estoque = Convert.ToInt32(dr[4]),
                    DataDeFabricacao = Convert.ToDateTime(dr[5])
                };

                lista.Add(peca);
            }

            conexaoSql.Close();

            return lista;
        }

        public void Criar(Peca novaPeca)
        {
            SqlConnection conexaoSql = new SqlConnection(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = 
                new SqlCommand($"INSERT INTO Pecas (Id, Categoria, Nome, Descricao, Estoque, DataDeFabricacao) VALUES ('{novaPeca.Id}', '{novaPeca.Categoria}', '{novaPeca.Nome}', '{novaPeca.Descricao}', '{novaPeca.Estoque}', '{novaPeca.DataDeFabricacao}');", conexaoSql);

            comandoExecutado.ExecuteNonQuery();

            ObterTodas();
            
            conexaoSql.Close();
        }

        public void Atualizar(int id, Peca pecaAtualizada)
        {
            throw new System.NotImplementedException();
        }

        public void Remover(int id)
        {
            SqlConnection conexaoSql = new SqlConnection(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = new SqlCommand("DELETE FROM Pecas;", conexaoSql);

            comandoExecutado.ExecuteNonQuery();

            ObterTodas();

            conexaoSql.Close();
        }
    }
}
