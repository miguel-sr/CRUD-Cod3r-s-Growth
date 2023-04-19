using Cod3rsGrowth.Modelos;
using System.ComponentModel;

namespace Cod3rsGrowth.Servicos
{
    public class BancoDeDados
    {
        private BancoDeDados() { }

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

        static int contadorDeId = 0;
        public static int GerarIdParaPeca()
        {
            return ++contadorDeId;
        }
    }
}
