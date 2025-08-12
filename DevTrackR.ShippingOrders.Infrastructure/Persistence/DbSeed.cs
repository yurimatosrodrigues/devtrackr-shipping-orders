using DevTrackR.ShippingOrders.Core.Entities;
using MongoDB.Driver;

namespace DevTrackR.ShippingOrders.Infrastructure.Persistence
{
    public class DbSeed
    {
        private readonly IMongoCollection<ShippingService> _collection;

        private List<ShippingService> _shippingServices = new List<ShippingService>()
        {
            new ShippingService("Envio estadual", 7.75m, 12),
            new ShippingService("Envio internacional", 5.725m, 15),
            new ShippingService("Caixa tamanho P", 0, 12)
        };

        public DbSeed(IMongoDatabase database)
        {
            _collection = database.GetCollection<ShippingService>("shipping-services");
        }

        public void Populate()
        {
            if(_collection.CountDocuments(c => true) == 0)
            {
                _collection.InsertMany(_shippingServices);
            }
        }
        
    }
}
