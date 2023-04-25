using LinqToDB.Configuration;
using LinqToDB;

namespace Cod3rsGrowth.Infra.Configuracoes
{
    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }

    public class ConexaoLinq2Db : ILinqToDBSettings
    {
        public IEnumerable<IDataProviderSettings> DataProviders
            => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "SqlServer";
        public string DefaultDataProvider => "SqlServer";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                // note that you can return multiple ConnectionStringSettings instances here
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "Northwind",
                        ProviderName = ProviderName.SqlServer,
                        ConnectionString =
                            @"Server=INVENT003;Database=Cod3rsGrowth;User Id=sa;Password=sap@123;"
                    };
            }
        }
    }
}
