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
            try
            {
                return BancoDeDados.Instancia().ListaDePecas.First(x => x.Id == id);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao obter peça.");
            }
        }

        public BindingList<Peca> ObterTodas()
        {
            try
            {
                return BancoDeDados.Instancia().ListaDePecas;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao obter lista de peças.");
            }
        }

        public void Criar(Peca novaPeca)
        {
            try
            {
                BancoDeDados.Instancia().ListaDePecas.Add(novaPeca);

            }
            catch (Exception)
            {
                throw new Exception("Erro ao criar peça.");
            }
        }

        public void Atualizar(int id, Peca pecaAtualizada)
        {
            try
            {
                var peca = ObterPorId(id);
                var index = BancoDeDados.Instancia().ListaDePecas.IndexOf(peca);
                BancoDeDados.Instancia().ListaDePecas[index] = pecaAtualizada;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao atualizar peça.");
            }
        }

        public void Remover(int id)
        {
            try
            {
                var pecaParaSerRemovida = ObterPorId(id);
                BancoDeDados.Instancia().ListaDePecas.Remove(pecaParaSerRemovida);
            } 
            catch (Exception)
            {
                throw new Exception("Erro ao remover peça.");
            }
        }
    }
}
