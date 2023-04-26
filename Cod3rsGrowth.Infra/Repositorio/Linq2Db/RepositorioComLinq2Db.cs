using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Repositorio;
using DataModels;
using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using System.ComponentModel;

namespace Cod3rsGrowth.Infra.Repositorio.Linq2Db
{
    public class RepositorioComLinq2Db : IRepositorio
    {
        public RepositorioComLinq2Db()
        {
            DataConnection.DefaultSettings = new ConexaoLinq2Db();
        }

        public Peca ObterPorId(int id)
        {
            using var db = new Cod3rsGrowthDB();

            var pecaCorrespondente = db.Pecas.FirstOrDefault(peca => peca.Id == id);

            db.Close();

            return new Peca
            {
                Id = pecaCorrespondente.Id,
                Categoria = pecaCorrespondente.Categoria,
                Nome = pecaCorrespondente.Nome,
                Descricao = pecaCorrespondente.Descricao,
                Estoque = pecaCorrespondente.Estoque,
                DataDeFabricacao = pecaCorrespondente.DataDeFabricacao
            };
        }

        public BindingList<Peca> ObterTodas()
        {
            using var db = new Cod3rsGrowthDB();

            BindingList<Peca> lista = new BindingList<Peca>();

            foreach (var peca in db.Pecas)
            {
                var pecaParaAdicionar = new Peca
                {
                    Id = peca.Id,
                    Categoria = peca.Categoria,
                    Nome = peca.Nome,
                    Descricao = peca.Descricao,
                    Estoque = peca.Estoque,
                    DataDeFabricacao = peca.DataDeFabricacao
                };

                lista.Add(pecaParaAdicionar);
            }

            db.Close();

            return lista;
        }

        public void Criar(Peca peca)
        {
            using var db = new Cod3rsGrowthDB();

            var novaPeca = new PecaLinq2Db
            {
                Id = peca.Id,
                Categoria = peca.Categoria,
                Nome = peca.Nome,
                Descricao = peca.Descricao,
                Estoque = peca.Estoque,
                DataDeFabricacao = peca.DataDeFabricacao
            };

            db.Insert(novaPeca);

            db.Close();

        }

        public void Atualizar(int id, Peca novaPeca)
        {
            using var db = new Cod3rsGrowthDB();

            db.Pecas.Where(peca => peca.Id == id)
                .Set(peca => peca.Categoria, novaPeca.Categoria)
                .Set(peca => peca.Nome, novaPeca.Nome)
                .Set(peca => peca.Descricao, novaPeca.Descricao)
                .Set(peca => peca.Estoque, novaPeca.Estoque)
                .Set(peca => peca.DataDeFabricacao, novaPeca.DataDeFabricacao)
                .Update();

            db.Close();
        }

        public void Remover(int id)
        {
            using var db = new Cod3rsGrowthDB();

            db.Pecas.Delete(x => x.Id == id);

            db.Close();
        }
    }

    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }

    public class ConexaoLinq2Db : ILinqToDBSettings
    {
        public IEnumerable<IDataProviderSettings> DataProviders
            => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "SqlServer";
        public string DefaultDataProvider => "SqlServer";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                // note that you can return multiple ConnectionStringSettings instances here
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "Northwind",
                        ProviderName = ProviderName.SqlServer,
                        ConnectionString =
                            @"Server=INVENT003;Database=Cod3rsGrowth;User Id=sa;Password=sap@123;"
                    };
            }
        }
    }
}
