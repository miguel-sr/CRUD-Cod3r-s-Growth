using Cod3rsGrowth.Infra.Migracoes;
using Cod3rsGrowth.Infra.Repositorio;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

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
            var builder = CriaHostBuilder();
            var servicesProvider = builder.Build().Services;
            var repositorio = servicesProvider.GetService<IRepositorio>();

            using (var scope = servicesProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControleDePecas(repositorio));
        }

        private static IHostBuilder CriaHostBuilder()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Cod3rsGrowth"].ConnectionString;

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<IRepositorio, RepositorioComLinq2Db>();
                    services.AddFluentMigratorCore()
                    .ConfigureRunner(rb => rb
                        .AddSqlServer()
                        .WithGlobalConnectionString(connectionString)
                        .ScanIn(typeof(AdicionaTabelaPecas).Assembly).For.Migrations())
                    .AddLogging(lb => lb.AddFluentMigratorConsole())
                    .BuildServiceProvider(false);
                });
        }
        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            runner.MigrateUp();
        }
    }
}
