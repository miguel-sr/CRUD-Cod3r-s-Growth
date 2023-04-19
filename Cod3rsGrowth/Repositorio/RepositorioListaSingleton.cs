using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Servicos;
using System;
using System.ComponentModel;
using System.Linq;

namespace Cod3rsGrowth.Repositorio
{
    public class RepositorioListaSingleton : IRepositorio
    {
        public Peca ObterPorId(int id)
        {
            return BancoDeDados.Instancia().ListaDePecas.First(x => x.Id == id);
        }

        public BindingList<Peca> ObterTodas()
        {
            return BancoDeDados.Instancia().ListaDePecas;
        }

        public void Criar(Peca novaPeca)
        {
            BancoDeDados.Instancia().ListaDePecas.Add(novaPeca);
        }

        public void Atualizar(int id, Peca pecaAtualizada)
        {
            var peca = ObterPorId(id);
            var index = BancoDeDados.Instancia().ListaDePecas.IndexOf(peca);
            BancoDeDados.Instancia().ListaDePecas[index] = pecaAtualizada;
        }

        public void Remover(int id)
        {
            var pecaParaSerRemovida = ObterPorId(id);
            BancoDeDados.Instancia().ListaDePecas.Remove(pecaParaSerRemovida);
        }
    }
}
