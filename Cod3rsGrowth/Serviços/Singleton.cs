using Cod3rsGrowth.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Serviços
{
    public class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;
        public BindingList<Peca> ListaDePecas { get; private set; }

        public static Singleton Instance()
        {
            lock (typeof(Singleton))
                if (_instance == null)
                {
                    _instance = new Singleton();
                    _instance.ListaDePecas = new BindingList<Peca>();
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
