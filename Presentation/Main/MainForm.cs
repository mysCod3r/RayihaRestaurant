using Rayiha.Presentation.Cashier;
using Rayiha.Presentation.Kitchen;
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
            CheckForIllegalCrossThreadCalls = false;
            _socketServer = new SocketServer(12345);
            Thread serverThread = new Thread(() => _socketServer.Start());
            serverThread.Start();
            _socketServer.MessageReceived += _messageReceived;
        }
        private void _messageReceived(object? sender, MessageModel messageModel)
        {
        }

        private void btnWaiter_Click(object sender, EventArgs e) => new WaiterForm().Show();
        private void btnKitchen_Click(object sender, EventArgs e) => new KitchenForm().Show();
        private void btnCashier_Click(object sender, EventArgs e) => new CashierForm().Show();
    }
}
