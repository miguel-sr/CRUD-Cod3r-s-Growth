using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Models
{
    public class Peca
    {
        public Peca(string categoria, string nome, string descricao, int estoque) 
        {
            this.Categoria = categoria;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Estoque = estoque;
        }

        public string Id { get; set; }

        public string Categoria { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Estoque { get; set; }

        public DateTime DataDeFabricacao { get; set; }
    }
}
