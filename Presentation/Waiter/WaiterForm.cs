
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Data;

namespace Rayiha.Presentation.Waiter
{
    public partial class WaiterForm : Form
    {
        private readonly SocketClient _socketClient;
        private readonly ClientType _clientType;
        private readonly WaiterService _service;
        public WaiterForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _socketClient = new SocketClient();
            _clientType = ClientType.Waiter;
            _service = new WaiterService(new DatabaseContext());
        }

        private void WaiterForm_Load(object sender, EventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form açıldı" };
            _socketClient.SendMessage(messageModel);
            _service.GetTables();
            _service.GetProducts();
            _service.GetCategories();
        }

        private void WaiterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form kapandı" };
            _socketClient.SendMessage(messageModel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "deneme" };
            _socketClient.SendMessage(messageModel);
        }
    }
}
