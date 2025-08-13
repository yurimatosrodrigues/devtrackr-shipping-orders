using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DevTrackR.ShippingOrders.Core.Entities
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        [BsonId]
        [BsonGuidRepresentation(GuidRepresentation.Standard)]
        public Guid Id { get; private set; }
    }
}
