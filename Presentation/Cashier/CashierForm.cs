using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;


namespace Rayiha.Presentation.Cashier
{
    public partial class CashierForm : Form
    {
        private readonly SocketClient _socketClient;
        private readonly ClientType _clientType;
        private readonly CashierService _service;
        public CashierForm()
        {
            _socketClient = new SocketClient();
            _clientType = ClientType.Cashier;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _service = new CashierService(new DatabaseContext());
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form açıldı" };
            _socketClient.SendMessage(messageModel);
            _service.GetOrder(1);
        }

        private void CashierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form kapandı" };
            _socketClient.SendMessage(messageModel);
        }
    }
}
