using Cod3rsGrowth.Modelos;
using System.ComponentModel;

namespace Cod3rsGrowth.Serviços
{
    public class BancoDeDados
    {
        private BancoDeDados() { }

        private static BancoDeDados _instance;
        public BindingList<Peca> ListaDePecas { get; private set; }

        public static BancoDeDados Instance()
        {
            lock (typeof(BancoDeDados))
                if (_instance == null)
                {
                    _instance = new BancoDeDados
                    {
                        ListaDePecas = new BindingList<Peca>()
                    };
                };

            return _instance;
        }

        static int contadorDeId = 0;
        public static int GerarIdParaPeca()
        {
            return ++contadorDeId;
        }
    }
}
