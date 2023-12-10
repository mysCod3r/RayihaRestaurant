using RayihaRestaurant.Core.Helper;
using System.Net.Sockets;
using System.Text;

namespace RayihaRestaurant.Core.Socket
{
    
    public class SocketClient
    {
        private TcpClient tcpClient;
        private NetworkStream stream;


        public void SendMessage(MessageModel messageModel)
        {
            tcpClient = new TcpClient("127.0.0.1", 12345);
            stream = tcpClient.GetStream();
            string serializedMessage = JsonHelper.SerializeObject(messageModel);
            byte[] data = Encoding.UTF8.GetBytes(serializedMessage);
            stream.Write(data, 0, data.Length);
            stream.Close();
            tcpClient.Close();
        }
    }
}
