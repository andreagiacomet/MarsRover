using MarsRover.Handler;
using MarsRover.Reader;
using MarsRover.Writer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MarsRover.Prog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<CreateOstacolo>();
                    services.AddSingleton<InitialRover>();
                    services.AddSingleton<CreateInitialMap>();
                    services.AddSingleton<MoveBackward>();
                    services.AddSingleton<MoveForward>();
                    services.AddSingleton<RotatorToRight>();
                    services.AddSingleton<RotatorToLeft>();
                    services.AddSingleton<Mover>();
                    services.AddSingleton<PopulatorMap>();
                    services.AddSingleton<IReader, FileReaderComandi>();
                    services.AddSingleton<IWriter, ConsoleWriter>();
                    services.AddSingleton<Manager>();
                    services.AddHostedService<Worker>();
                });
    }
}
