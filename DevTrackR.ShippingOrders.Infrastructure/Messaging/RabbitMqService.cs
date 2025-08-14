using RabbitMQ.Client;

namespace DevTrackR.ShippingOrders.Infrastructure.Messaging
{
    public class RabbitMqService : IServiceBusService
    {
        private IConnection _connection;
        private IChannel _channel;
        private const string _exchange = "trackings-service";


        async Task InitializeAsync()
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            _connection = await connectionFactory.CreateConnectionAsync("trackings-service-publisher");
            _channel = await _connection.CreateChannelAsync();
        }

        public RabbitMqService()
        {
           
        }

        public void Publish(object data, string routingKey)
        {
            throw new NotImplementedException();
        }
    }
}
