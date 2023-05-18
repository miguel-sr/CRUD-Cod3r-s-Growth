using Cod3rsGrowth.Modelos;
using LinqToDB;
using System.ComponentModel;
using System.Configuration;
using LinqToDB.DataProvider.SqlServer;
using LinqToDB.Data;

namespace Cod3rsGrowth.Infra.Repositorio
{
    public class RepositorioComLinq2Db : IRepositorio
    {
        public static DataConnection ObterConexao()
        {
            var stringDeConexao = ConfigurationManager.ConnectionStrings["Cod3rsGrowth"].ConnectionString;

            return SqlServerTools.CreateDataConnection(stringDeConexao);
        }

        public Peca ObterPorId(int id)
        {
            using var db = ObterConexao();

            var peca = db.GetTable<Peca>().First(peca => peca.Id == id);

            return peca;
        }

        public BindingList<Peca> ObterTodas()
        {
            using var db = ObterConexao();

            BindingList<Peca> lista = new();

            foreach (var peca in db.GetTable<Peca>())
            {
                lista.Add(peca);
            }

            return lista;
        }

        public void Criar(Peca peca)
        {
            using var db = ObterConexao();

            peca.Id = db.InsertWithInt32Identity(peca);
        }

        public void Atualizar(int id, Peca peca)
        {
            using var db = ObterConexao();

            var registroAtualizado = db.Update(peca) != 0;

            if (!registroAtualizado) throw new Exception($"Peça com ID {id} não encontrada.");
        }

        public void Remover(int id)
        {
            using var db = ObterConexao();

            var registroDeletado = db.GetTable<Peca>().Where(x => x.Id == id).Delete() != 0;

            if (!registroDeletado) throw new Exception($"Peça com ID {id} não encontrada.");
        }
    }
}
