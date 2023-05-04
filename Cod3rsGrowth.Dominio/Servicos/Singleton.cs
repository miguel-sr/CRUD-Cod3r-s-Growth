using Cod3rsGrowth.Modelos;
using System.ComponentModel;

namespace Cod3rsGrowth.Servicos
{
    public sealed class Singleton
    {
        private Singleton() { }

        static int _contadorDeId = 0;
        private static Singleton _instancia;
        public BindingList<Peca> ListaDePecas { get; private set; }

        public static Singleton Instancia()
        {
            lock (typeof(Singleton))
                if (_instancia == null)
                {
                    _instancia = new Singleton
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
