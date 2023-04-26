using LinqToDB;
using LinqToDB.Mapping;

namespace Cod3rsGrowth.Infra.Repositorio.Linq2Db
{
    public partial class Cod3rsGrowthDB : LinqToDB.Data.DataConnection
	{
		public ITable<PecaLinq2Db> Pecas { get { return this.GetTable<PecaLinq2Db>(); } }

		public Cod3rsGrowthDB() { } 
	}

	[Table(Schema="dbo", Name="Pecas")]
	public partial class PecaLinq2Db
	{
		[PrimaryKey, Identity] public int      Id               { get; set; } 
		[Column,     NotNull ] public string   Categoria        { get; set; } 
		[Column,     NotNull ] public string   Nome             { get; set; } 
		[Column,     NotNull ] public string   Descricao        { get; set; }
		[Column,     NotNull ] public int      Estoque          { get; set; } 
		[Column,     NotNull ] public DateTime DataDeFabricacao { get; set; }
	}
}
