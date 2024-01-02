using System.Net.Sockets;
using System.Net;
using System.Text;
using RayihaRestaurant.Core.Helper;

namespace RayihaRestaurant.Core.Socket
{
    public class SocketServer : IDisposable
    {
        public SocketServer(int port)
        {
            _tcpListener = new TcpListener(IPAddress.Any, port);
            _tcpListener.Start();
        }
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private TcpListener _tcpListener;
        private NetworkStream? stream;
        private TcpClient? tcpClient;
        public event EventHandler<MessageModel>? MessageReceived;
        private bool _isRunning = true;

        public void Start()
        {
            try
            {
                while (_isRunning)
                {
                    TcpClient tcpClient = _tcpListener.AcceptTcpClient();
                    Task.Run(() => HandleClient(tcpClient), _cancellationTokenSource.Token);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SocketException: {ex}");
            }
        }

        private void HandleClient(TcpClient tcpClient)
        {
            try
            {
                using (NetworkStream stream = tcpClient.GetStream())
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        OnMessageReceived(buffer, bytesRead);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in HandleClient: {ex}");
            }
        }

        protected virtual void OnMessageReceived(byte[] data, int bytesRead)
        {
            string jsonString = Encoding.UTF8.GetString(data, 0, bytesRead);
            MessageModel? message = JsonHelper.DeserializeObject<MessageModel>(jsonString);
            if (message == null) return;
            MessageReceived?.Invoke(this, message);
        }

        public void Dispose()
        {
            _isRunning = false;
            stream?.Dispose();
            _tcpListener?.Dispose();
            _cancellationTokenSource.Cancel();
        }
    }
}
