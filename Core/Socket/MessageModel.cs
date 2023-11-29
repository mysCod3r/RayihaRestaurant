namespace RayihaRestaurant.Core.Socket
{
    public enum ClientType
    {
        Cashier,
        Kitchen,
        Waiter,
    }

    public class MessageModel : EventArgs
    {
     
        public required ClientType sender { get; init; }
        public required string message { get; init; }
    }
}
