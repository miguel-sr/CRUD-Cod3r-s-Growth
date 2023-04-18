using System;

namespace Cod3rsGrowth.Modelos
{
    public class Peca
    {
        public Peca(int id, string categoria, string nome, string descricao, DateTime dataDeFabricacao) {
            Id = id;
            Categoria = categoria;
            Nome = nome;
            Descricao = descricao;
            DataDeFabricacao = dataDeFabricacao;
        }
        public int Id { get; set; }

        public string Categoria { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Estoque { get; set; }

        public DateTime DataDeFabricacao { get; set; }
    }
}
