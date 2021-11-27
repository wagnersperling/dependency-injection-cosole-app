using DI.Classes;
using DI.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DI
{
    class Program
    {
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var operacaoService = serviceProvider.GetService<OperacaoService>();

            Console.WriteLine("Scoped " + operacaoService.Scoped.OperacaoId);
            Console.WriteLine("Singleton " + operacaoService.Singleton.OperacaoId);
            Console.WriteLine("Transient " + operacaoService.Transient.OperacaoId);

            Console.WriteLine("----------------------------------------------");

            var operacaoService2 = serviceProvider.GetService<OperacaoService>();

            Console.WriteLine("Scoped " + operacaoService2.Scoped.OperacaoId);
            Console.WriteLine("Singleton " + operacaoService2.Singleton.OperacaoId);
            Console.WriteLine("Transient " + operacaoService2.Transient.OperacaoId);

            Console.WriteLine("----------------------------------------------");

            Main();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IOperacaoScoped, Operacao>().
                AddTransient<OperacaoService>().
                AddSingleton<IOperacaoSingleton, Operacao>().
                AddTransient<IOperacaoTransient, Operacao>();
        }

    }
}
