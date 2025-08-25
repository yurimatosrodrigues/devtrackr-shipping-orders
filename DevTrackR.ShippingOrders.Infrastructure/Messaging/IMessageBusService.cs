using MongoDB.Bson.IO;

namespace DevTrackR.ShippingOrders.Infrastructure.Messaging
{
    public interface IMessageBusService
    {
        Task PublishAsync(object data, string routingKey);
    }
}
