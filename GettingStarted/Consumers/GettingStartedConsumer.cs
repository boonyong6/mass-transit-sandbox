namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;
    using Microsoft.Extensions.Logging;

    // Message handler (think of it like a controller in MVC).
    public class GettingStartedConsumer :
        IConsumer<HelloMessage>
    {
        private readonly ILogger<GettingStartedConsumer> _logger;

        public GettingStartedConsumer(ILogger<GettingStartedConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<HelloMessage> context)
        {
            _logger.LogInformation("Hello {Name}", context.Message.Name);

            return Task.CompletedTask;
        }
    }
}