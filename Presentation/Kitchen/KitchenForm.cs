using RayihaRestaurant.Core.Socket;

namespace Rayiha.Presentation.Kitchen
{
    public partial class KitchenForm : Form
    {
        private readonly SocketClient _socketClient;
        private readonly ClientType _clientType;
        public KitchenForm()
        {
            _socketClient = new SocketClient();
            _clientType = ClientType.Kitchen;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form açıldı" };
            _socketClient.SendMessage(messageModel);

        }

        private void KitchenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = _clientType, message = "form kapandı" };
            _socketClient.SendMessage(messageModel);
        }
    }
}
