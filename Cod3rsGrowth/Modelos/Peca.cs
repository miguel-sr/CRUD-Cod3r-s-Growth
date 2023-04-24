﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cod3rsGrowth.Modelos
{
    public class Peca
    {
        public int Id { get; set; }

        public string Categoria { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Estoque { get; set; }

        public DateTime DataDeFabricacao { get; set; }
    }
}
