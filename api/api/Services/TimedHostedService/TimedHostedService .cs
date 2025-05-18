using api.DataContext;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;

namespace api.Services
{
    public class TimedHostedService : IHostedService, IDisposable
    {
        private int executionCount = 0;
        private readonly ILogger<TimedHostedService> _logger;
        private Timer? _timer = null;

        private readonly ILotBackgroundService _lotBackgroundService;

        public TimedHostedService(ILogger<TimedHostedService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(10));

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            var count = Interlocked.Increment(ref executionCount);

            _logger.LogInformation(
                "Timed Hosted Service is working. Count: {Count}", count);
            Task.Run(async () => 
            {
                string appsettingsJson = null;

                using (StreamReader sr = new StreamReader("appsettings.json"))
                {
                    appsettingsJson = sr.ReadToEnd();
                }

                AppSettings settings = JsonConvert.DeserializeObject<AppSettings>(appsettingsJson);

                string connectionString = settings.ConnectionStrings.ConnectionString;

                DbContextOptionsBuilder<Context> contextBuilder = new DbContextOptionsBuilder<Context>();
                contextBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                Context context = new Context(contextBuilder.Options);
                ILotBackgroundService lotBackgroundService = new LotBackgroundService(context);

                await lotBackgroundService.CloseLotBackgroundAsync();
            });
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
