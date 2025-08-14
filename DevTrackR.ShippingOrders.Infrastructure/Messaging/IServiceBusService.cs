using MongoDB.Bson.IO;

namespace DevTrackR.ShippingOrders.Infrastructure.Messaging
{
    public interface IServiceBusService
    {
        void Publish(object data, string routingKey);
    }
}
