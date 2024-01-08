using Rayiha.Presentation.Waiter;
using RayihaRestaurant.Core.Socket;

namespace RayihaRestaurant
{
    public partial class MainForm : Form
    {
        private SocketServer _socketServer;

        public MainForm()
        {
            InitializeComponent();
            _socketServer = new SocketServer(12345);
            Thread serverThread = new Thread(() => _socketServer.Start());
            serverThread.Start();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm(_socketServer, this).Show();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => _socketServer.Dispose();
    }
}
