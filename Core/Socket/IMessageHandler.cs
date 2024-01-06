namespace RayihaRestaurant.Core.Socket
{
    public interface IMessageHandler
    {
        ClientType ClientType { get; }
        void HandleMessageFromSocket(MessageModel message);
    }
}
