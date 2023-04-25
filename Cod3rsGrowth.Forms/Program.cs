using Cod3rsGrowth.Infra.Configuracoes;
using Cod3rsGrowth.Infra.Repositorio;
using Cod3rsGrowth.Repositorio;
using LinqToDB.Data;
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
            DataConnection.DefaultSettings = new ConexaoLinq2Db();

            var builder = CriaHostBuilder();
            var servicesProvider = builder.Build().Services;
            var repositorio = servicesProvider.GetService<IRepositorio>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControleDePecas(repositorio));
        }

        private static IHostBuilder CriaHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<IRepositorio, RepositorioComLinq2Db>();
                });
        }
    }
}
