using Cod3rsGrowth.Modelos;
using System.ComponentModel;

namespace Cod3rsGrowth.Infra.Repositorio
{
    public interface IRepositorio
    {
        BindingList<Peca> ObterTodas();

        Peca ObterPorId(int id);

        void Criar(Peca peca);

        void Atualizar(int id, Peca peca);

        void Remover(int id);
    }
}
