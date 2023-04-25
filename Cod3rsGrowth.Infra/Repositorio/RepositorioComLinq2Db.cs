using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Repositorio;
using DataModels;
using LinqToDB;
using LinqToDB.Data;
using System.ComponentModel;
using System.Configuration;

namespace Cod3rsGrowth.Infra.Repositorio
{
    public class RepositorioComLinq2Db : IRepositorio
    {
        public Modelos.Peca ObterPorId(int id)
        {
            using var db = new Cod3rsGrowthDB();

            var pecaCorrespondente = db.Pecas.FirstOrDefault(peca => peca.Id == id);

            return new Modelos.Peca
            {
                Id = pecaCorrespondente.Id,
                Categoria = pecaCorrespondente.Categoria,
                Nome = pecaCorrespondente.Nome,
                Descricao = pecaCorrespondente.Descricao,
                Estoque = pecaCorrespondente.Estoque,
                DataDeFabricacao = pecaCorrespondente.DataDeFabricacao
            };
        }

        public BindingList<Modelos.Peca> ObterTodas()
        {
            using var db = new Cod3rsGrowthDB();

            BindingList<Modelos.Peca> lista = new BindingList<Modelos.Peca>();

            foreach (var peca in db.Pecas)
            {
                var pecaParaAdicionar = new Modelos.Peca
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

        public void Criar(Modelos.Peca peca)
        {
            using var db = new Cod3rsGrowthDB();

            var novaPeca = new DataModels.Peca
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

        public void Atualizar(int id, Modelos.Peca novaPeca)
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
}
