namespace WhatsAppMessageScheduler.Interfaces;

public interface IHostedService
{
    Task StarAsync(CancellationToken cancellationToken);
    Task StopAsync(CancellationToken cancellationToken);
}
