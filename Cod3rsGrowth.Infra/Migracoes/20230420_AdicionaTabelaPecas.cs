using FluentMigrator;
using FluentMigrator.SqlServer;

namespace Cod3rsGrowth.Infra.Migracoes
{
    [Migration(20230424101800)]
    public class AdicionaTabelaPecas : Migration
    {
        public override void Up()
        {
            Create.Table("Pecas")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity(1, 1)
                .WithColumn("Categoria").AsString()
                .WithColumn("Nome").AsString()
                .WithColumn("Descricao").AsString()
                .WithColumn("Estoque").AsInt32()
                .WithColumn("DataDeFabricacao").AsDateTime();
        }

        public override void Down()
        {
            Delete.Table("Pecas");
        }
    }
}
