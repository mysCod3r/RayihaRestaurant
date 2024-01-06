using Rayiha.Presentation.Kitchen;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Presentation.Module.Views;

namespace RayihaRestaurant
{
    public partial class MainForm : Form
    {
        private SocketServer _socketServer;
        private KitchenForm _kitchenForm;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _socketServer = new SocketServer(12345);
            _kitchenForm = new KitchenForm();
            _socketServer.AddMessageHandler(_kitchenForm);
            Thread serverThread = new Thread(() => _socketServer.Start());
            serverThread.Start();
        }

        private void btnWaiter_Click(object sender, EventArgs e) => new TablesForm(socketServer: _socketServer, clientType: ClientType.Waiter).Show();
        private void btnKitchen_Click(object sender, EventArgs e) => _kitchenForm.Open();
        private void btnCashier_Click(object sender, EventArgs e) => new TablesForm(socketServer: _socketServer, clientType: ClientType.Cashier).Show();

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _socketServer.Dispose();
        }
    }
}
