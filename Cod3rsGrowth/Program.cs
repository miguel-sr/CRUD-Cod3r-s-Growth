﻿using Cod3rsGrowth.Modelos;
using System;
using System.Collections.Generic;
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
                    new Peca(GerarIdParaPeca(), "Parafusos", "Parafuso Sextavado", "Espessura 8mm", 30, DateTime.Now.Date),
                    new Peca(GerarIdParaPeca(), "Parafusos", "Parafuso Sextavado", "Espessura 6mm", 15, DateTime.Now.Date),
                    new Peca(GerarIdParaPeca(), "Porcas", "Porca Autotravante", "Espessura 8mm", 30, DateTime.Now.Date),
                    new Peca(GerarIdParaPeca(), "Porcas", "Porca Autotravante", "Espessura 6mm", 15, DateTime.Now.Date),
                    new Peca(GerarIdParaPeca(), "Porcas", "Porca Autotravante", "Espessura 3mm", 0, DateTime.Now.Date)
                };

            ControleDePecas = new ControleDePecas();
            Application.Run(ControleDePecas);
        }

        public static ControleDePecas ControleDePecas { get; set; }
        public static List<Peca> ListaDePecas { get; set; }

        static int contadorDeId = 0;
        public static int GerarIdParaPeca()
        {
            return contadorDeId++;
        }
    }
}
