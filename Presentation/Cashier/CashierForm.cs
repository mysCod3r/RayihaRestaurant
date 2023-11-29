using RayihaRestaurant.Core.Socket;


namespace Rayiha.Presentation.Cashier
{
    public partial class CashierForm : Form
    {
        private readonly SocketClient _socketClient;
        private readonly ClientType _clientType;
        public CashierForm()
        {
            _socketClient = new SocketClient();
            _clientType = ClientType.Cashier;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form açıldı" };
            _socketClient.SendMessage(messageModel);
        }

        private void CashierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form kapandı" };
            _socketClient.SendMessage(messageModel);
        }
    }
}
