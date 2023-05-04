using LinqToDB.Mapping;

namespace Cod3rsGrowth.Modelos
{
    [Table(Schema = "dbo", Name = "Pecas")]
    public class Peca
    {
        [PrimaryKey, Identity] public int? Id { get; set; }

        [Column, NotNull] public string Categoria { get; set; }

        [Column, NotNull] public string Nome { get; set; }

        [Column, NotNull] public string Descricao { get; set; }

        [Column, NotNull] public int Estoque { get; set; }

        [Column, NotNull] public DateTime DataDeFabricacao { get; set; }
    }
}
