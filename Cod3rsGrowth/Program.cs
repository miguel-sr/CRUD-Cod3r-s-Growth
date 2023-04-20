using Cod3rsGrowth.Migracoes;
using Cod3rsGrowth.Repositorio;
using Cod3rsGrowth.Servicos;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

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
            using (var provedorServico = CriaServicos())
            using (var escopo = provedorServico.CreateScope())
            {
                AtualizarBancoDeDados(escopo.ServiceProvider);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControleDePecas());
        }

        static readonly string stringDeConexao = 
            System.Configuration.ConfigurationManager.ConnectionStrings["Cod3rsGrowth"].ConnectionString;

        private static ServiceProvider CriaServicos()
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer2016()
                    .WithGlobalConnectionString(stringDeConexao)
                    .ScanIn(typeof(AdicionaTabelaPecas).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void AtualizarBancoDeDados(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            runner.MigrateUp();
        }
    }
}
