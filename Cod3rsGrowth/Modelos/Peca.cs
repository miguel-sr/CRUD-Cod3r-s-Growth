﻿using System;

namespace Cod3rsGrowth.Modelos
{
    public class Peca
    {
        public Peca(int Id, string Categoria, string Nome, string Descricao, int Estoque, DateTime DataDeFabricacao) 
        {
            this.Id = Id;
            this.Categoria = Categoria;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.Estoque = Estoque;
            this.DataDeFabricacao = DataDeFabricacao;
        }

        public int Id { get; set; }

        public string Categoria { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Estoque { get; set; }

        public DateTime DataDeFabricacao { get; set; }
    }
}