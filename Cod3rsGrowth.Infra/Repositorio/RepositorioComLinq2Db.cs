using Cod3rsGrowth.Modelos;
using LinqToDB;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;
using LinqToDB.DataProvider.SqlServer;
using LinqToDB.Data;
using LinqToDB.Tools;
using System.Linq;

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

            var peca = db.GetTable<Peca>().FirstOrDefault(peca => peca.Id == id);

            db.Close();

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

            db.Close();

            return lista;
        }

        public int Criar(Peca peca)
        {
            using var db = ObterConexao();

            var id = db.InsertWithInt32Identity(peca);

            db.Close();

            return id;
        }

        public void Atualizar(int id, Peca peca)
        {
            using var db = ObterConexao();

            db.Update(peca);

            db.Close();
        }

        public void Remover(int id)
        {
            using var db = ObterConexao();

            db.GetTable<Peca>().Where(x => x.Id == id).Delete();
            db.Close();
        }
    }
}
