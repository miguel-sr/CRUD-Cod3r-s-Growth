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
            SqlConnection conexaoSql = new(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = new($"SELECT Id, Categoria, Nome, Descricao, Estoque, DataDeFabricacao FROM Pecas WHERE Id='{id}';", conexaoSql);

            SqlDataReader respostaDoComando = comandoExecutado.ExecuteReader();

            var peca = null as Peca;

            while (respostaDoComando.Read())
            {
                peca = new Peca
                {
                    Id = Convert.ToInt32(respostaDoComando[0]),
                    Categoria = respostaDoComando[1].ToString(),
                    Nome = respostaDoComando[2].ToString(),
                    Descricao = respostaDoComando[3].ToString(),
                    Estoque = respostaDoComando[4].ToString(),
                    DataDeFabricacao = Convert.ToDateTime(respostaDoComando[5])
                };
            }

            conexaoSql.Close();

            return peca ?? throw new Exception($"Peça não encontrada com id [{id}]");
        }

        public BindingList<Peca> ObterTodas()
        {
            BindingList<Peca> lista = new();

            SqlConnection conexaoSql = new(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = new("SELECT * FROM Pecas;", conexaoSql);

            lista.Clear();

            SqlDataReader respostaDoComando = comandoExecutado.ExecuteReader();

            while (respostaDoComando.Read())
            {
                var peca = new Peca
                {
                    Id = Convert.ToInt32(respostaDoComando[0]),
                    Categoria = respostaDoComando[1].ToString(),
                    Nome = respostaDoComando[2].ToString(),
                    Descricao = respostaDoComando[3].ToString(),
                    Estoque = respostaDoComando[4].ToString(),
                    DataDeFabricacao = Convert.ToDateTime(respostaDoComando[5])
                };

                lista.Add(peca);
            }

            conexaoSql.Close();

            return lista;
        }

        public void Criar(Peca peca)
        {
            SqlConnection conexaoSql = new(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = 
                new($"INSERT INTO Pecas (Categoria, Nome, Descricao, Estoque, DataDeFabricacao) VALUES ('{peca.Categoria}', '{peca.Nome}', '{peca.Descricao}', '{peca.Estoque}', '{peca.DataDeFabricacao}');", conexaoSql);

            comandoExecutado.ExecuteNonQuery();

            conexaoSql.Close();
        }

        public void Atualizar(int id, Peca peca)
        {
            SqlConnection conexaoSql = new(_stringDeConexao);
            conexaoSql.Open();

            SqlCommand comandoExecutado = new($"UPDATE Pecas SET Categoria='{peca.Categoria}', Nome='{peca.Nome}', Descricao='{peca.Descricao}', Estoque='{peca.Estoque}', DataDeFabricacao='{peca.DataDeFabricacao}' WHERE Id='{id}';", conexaoSql);

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
