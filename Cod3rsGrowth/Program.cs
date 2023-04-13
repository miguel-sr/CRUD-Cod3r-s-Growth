using Cod3rsGrowth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ListaDePecas = new List<Peca>
                {
                    new Peca(1, "Parafusos", "Parafuso Sextavado", "Espessura 8mm", 30, DateTime.Now.Date),
                    new Peca(2, "Parafusos", "Parafuso Sextavado", "Espessura 6mm", 15, DateTime.Now.Date),
                    new Peca(3, "Porcas", "Porca Autotravante", "Espessura 8mm", 30, DateTime.Now.Date),
                    new Peca(4, "Porcas", "Porca Autotravante", "Espessura 6mm", 15, DateTime.Now.Date),
                    new Peca(5, "Porcas", "Porca Autotravante", "Espessura 3mm", 0, DateTime.Now.Date)
                };

            Application.Run(new ControleDePecas());

            
        }
        public static List<Peca> ListaDePecas { get; set; }
    }
}
