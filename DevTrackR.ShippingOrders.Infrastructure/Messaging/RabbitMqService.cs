using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace DevTrackR.ShippingOrders.Infrastructure.Messaging
{
    public class RabbitMqService : IMessageBusService
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

        public async Task StartAsync()
        {
            await InitializeAsync();
        }

        public async Task PublishAsync(object data, string routingKey)
        {
            var type = data.GetType();

            var payload = JsonConvert.SerializeObject(data);
            var byteArray = Encoding.UTF8.GetBytes(payload);

            Console.WriteLine($"{type.Name} Published");

            await _channel.BasicPublishAsync(_exchange, routingKey, byteArray);
        }
    }
}
