using Cod3rsGrowth.Modelos;
using System.ComponentModel;

namespace Cod3rsGrowth.Repositorio
{
    public interface IRepositorio
    {
        BindingList<Peca> ObterTodas();

        Peca ObterPorId(int id);

        void Criar(Peca novaPeca);

        void Atualizar(int id, Peca pecaAtualizada);

        void Remover(int id);
    }
}
