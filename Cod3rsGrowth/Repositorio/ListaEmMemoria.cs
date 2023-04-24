using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Servicos;
using System;
using System.ComponentModel;
using System.Linq;

namespace Cod3rsGrowth.Repositorio
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

        public void Criar(Peca novaPeca)
        {
            Singleton.Instancia().ListaDePecas.Add(novaPeca);
        }

        public void Atualizar(int id, Peca pecaAtualizada)
        {
            var peca = ObterPorId(id);
            var index = Singleton.Instancia().ListaDePecas.IndexOf(peca);
            Singleton.Instancia().ListaDePecas[index] = pecaAtualizada;
        }

        public void Remover(int id)
        {
            var pecaParaSerRemovida = ObterPorId(id);
            Singleton.Instancia().ListaDePecas.Remove(pecaParaSerRemovida);
        }
    }
}
