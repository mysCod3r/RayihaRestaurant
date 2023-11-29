using System.Net.Sockets;
using System.Net;
using System.Text;
using RayihaRestaurant.Core.Helper;

namespace RayihaRestaurant.Core.Socket
{
    public class SocketServer
    {
        public SocketServer(int port)
        {
            _tcpListener = new TcpListener(IPAddress.Any, port);
        }
        private TcpListener _tcpListener;
        private NetworkStream? stream;
        private TcpClient? tcpClient;
        public event EventHandler<MessageModel>? MessageReceived;

        public void Start()
        {
            _tcpListener.Start();
            while (true)
            {
                tcpClient = _tcpListener.AcceptTcpClient();
                stream = tcpClient.GetStream();
                var socketThread = new Thread(() => { 
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    OnMessageReceived(buffer, bytesRead);
                    stream.Close();
                    tcpClient.Close();
                });
                socketThread.Start();
            }
        }

        protected virtual void OnMessageReceived(byte[] data, int bytesRead)
        {
            string jsonString = Encoding.UTF8.GetString(data, 0, bytesRead);
            MessageModel? message = JsonHelper.DeserializeObject<MessageModel>(jsonString);
            if (message == null) return;
            MessageReceived?.Invoke(this, message);
        }
    }
}
