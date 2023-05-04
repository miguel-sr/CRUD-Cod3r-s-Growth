using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Servicos;
using System;
using System.ComponentModel;
using System.Linq;

namespace Cod3rsGrowth.Infra.Repositorio
{
    public class ListaEmMemoria : IRepositorio
    {
        public Peca ObterPorId(int id)
        {
            return Singleton.Instancia().ListaDePecas.First(x => x.Id == id);
        }

        public BindingList<Peca> ObterTodas()
        {
            return Singleton.Instancia().ListaDePecas;
        }

        public void Criar(Peca peca)
        {
            Singleton.Instancia().ListaDePecas.Add(peca);
        }

        public void Atualizar(int id, Peca peca)
        {
            var pecaASerAtualizada = ObterPorId(id);
            var index = Singleton.Instancia().ListaDePecas.IndexOf(pecaASerAtualizada);
            Singleton.Instancia().ListaDePecas[index] = peca;
        }

        public void Remover(int id)
        {
            var pecaParaSerRemovida = ObterPorId(id);
            Singleton.Instancia().ListaDePecas.Remove(pecaParaSerRemovida);
        }
    }
}
