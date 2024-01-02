using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;


namespace Rayiha.Presentation.Kitchen
{

    public partial class KitchenForm : Form
    {
        private readonly KitchenService _service;
        private readonly SocketClient _socketClient;
        private readonly ClientType _clientType;
        public KitchenForm()
        {
            _socketClient = new SocketClient();
            _clientType = ClientType.Kitchen;
            _service = new KitchenService(new DatabaseContext());
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form açıldı" };
            _socketClient.SendMessage(messageModel);
            _service.GetOrder(3);

        }

        private void KitchenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form kapandı" };
            _socketClient.SendMessage(messageModel);
        }
    }
}
