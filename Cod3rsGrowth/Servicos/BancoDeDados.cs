using Cod3rsGrowth.Modelos;
using System.ComponentModel;

namespace Cod3rsGrowth.Servicos
{
    public class BancoDeDados
    {
        private BancoDeDados() { }

        static int _contadorDeId = 0;
        private static BancoDeDados _instancia;
        public BindingList<Peca> ListaDePecas { get; private set; }

        public static BancoDeDados Instancia()
        {
            lock (typeof(BancoDeDados))
                if (_instancia == null)
                {
                    _instancia = new BancoDeDados
                    {
                        ListaDePecas = new BindingList<Peca>()
                    };
                };

            return _instancia;
        }

        public static int GerarIdParaPeca()
        {
            return ++_contadorDeId;
        }
    }
}
