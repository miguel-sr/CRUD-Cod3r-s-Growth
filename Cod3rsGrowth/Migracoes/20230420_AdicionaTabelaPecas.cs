using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cod3rsGrowth.Migracoes
{
    [Migration(20230420111700)]
    public class AdicionaTabelaPecas : Migration
    {
        public override void Up()
        {
            Create.Table("Pecas")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
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
