namespace DevTrackR.ShippingOrders.Core.ValueObjects
{
    public record DeliveryAdress(string Street, string Number, string ZipCode, string City, string State, string Country)
    {
    }
}
