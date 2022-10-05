/*namespace OrderAPI.Services
{
    public class OrderService : BackgroundService
    {
        public OrderService(IOrderDataAccess orderDataAccess)
        {

        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _messageWriter.Write($"Worker running at: {DateTimeOffset.Now}");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
*/