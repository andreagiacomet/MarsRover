using MarsRover.Handler;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarsRover.Prog
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;
        private readonly Manager manager;

        public Worker(ILogger<Worker> logger, IConfiguration configuration,Manager manager)
        {
            _logger = logger;
            _configuration = configuration;
            this.manager = manager;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                manager.Setup(Convert.ToInt32(_configuration["MapDimension"]));
                manager.Execute(_configuration["FileComandi"]);
                await Task.Delay(30000, stoppingToken);
            }
        }
    }
}
