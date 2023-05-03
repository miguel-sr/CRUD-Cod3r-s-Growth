using Cod3rsGrowth.Modelos;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;

namespace Cod3rsGrowth.Infra.Repositorio
{
    public class RepositorioComBancoSql : IRepositorio
    {
        private readonly string _stringDeConexao = ConfigurationManager.ConnectionStrings["Cod3rsGrowth"].ConnectionString;
        public Peca ObterPorId(int id)
        {
            SqlConnection conexaoSql = new SqlConnection(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = new SqlCommand($"SELECT Id, Categoria, Nome, Descricao, Estoque, DataDeFabricacao FROM Pecas WHERE Id='{id}';", conexaoSql);

            SqlDataReader dr = comandoExecutado.ExecuteReader();

            var peca = null as Peca;

            while (dr.Read())
            {
                peca = new Peca
                {
                    Id = Convert.ToInt32(dr[0]),
                    Categoria = dr[1].ToString(),
                    Nome = dr[2].ToString(),
                    Descricao = dr[3].ToString(),
                    Estoque = Convert.ToInt32(dr[4]),
                    DataDeFabricacao = Convert.ToDateTime(dr[5])
                };

            }

            conexaoSql.Close();

            return peca;

        }

        public BindingList<Peca> ObterTodas()
        {
            BindingList<Peca> lista = new();

            SqlConnection conexaoSql = new(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = new("SELECT * FROM Pecas;", conexaoSql);

            lista.Clear();

            SqlDataReader dr = comandoExecutado.ExecuteReader();

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

        public int Criar(Peca novaPeca)
        {
            SqlConnection conexaoSql = new(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = 
                new($"INSERT INTO Pecas (Categoria, Nome, Descricao, Estoque, DataDeFabricacao) VALUES ('{novaPeca.Categoria}', '{novaPeca.Nome}', '{novaPeca.Descricao}', '{novaPeca.Estoque}', '{novaPeca.DataDeFabricacao}');", conexaoSql);

            SqlDataReader dr = comandoExecutado.ExecuteReader();

            int id = 0;

            while (dr.Read())
            {
                id = Convert.ToInt32(dr[0]);
            }

            conexaoSql.Close();

            return id;
        }

        public void Atualizar(int id, Peca pecaAtualizada)
        {
            SqlConnection conexaoSql = new(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = new($"UPDATE Pecas SET Categoria='{pecaAtualizada.Categoria}', Nome='{pecaAtualizada.Nome}', Descricao='{pecaAtualizada.Descricao}', Estoque='{pecaAtualizada.Estoque}', DataDeFabricacao='{pecaAtualizada.DataDeFabricacao}' WHERE Id='{id}';", conexaoSql);

            comandoExecutado.ExecuteNonQuery();

            conexaoSql.Close();
        }

        public void Remover(int id)
        {
            SqlConnection conexaoSql = new(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = new($"DELETE FROM Pecas WHERE Id='{id}';", conexaoSql);

            comandoExecutado.ExecuteNonQuery();

            conexaoSql.Close();
        }
    }
}
