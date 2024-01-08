using RayihaRestaurant.Core.Base;
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Presentation.Kitchen.Components;

namespace Rayiha.Presentation.Kitchen
{

    public partial class KitchenForm : BaseForm, IMessageHandler
    {
        public override Size WindowSize => new Size(1100, 700);
        public override string WindowPanelName => "Kitchen";
        private List<Order>? _orders;
        public ClientType ClientType => ClientType.Kitchen;
        private readonly KitchenService _service;
        private readonly SocketClient _socketClient;
        public KitchenForm()
        {
            _socketClient = new SocketClient();
            _service = new KitchenService(new DatabaseContext());
            _orders = _service.GetOrders();
            InitializeComponent();
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = ClientType, message = "form açıldı" };
            _socketClient.SendMessage(messageModel);
        }

        private void KitchenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageModel messageModel = new MessageModel { sender = ClientType, message = "form kapandı" };
            //_socketClient.SendMessage(messageModel);
        }

        private void btnClose_Click(object sender, EventArgs e) => Hide();

        public override void Open()
        {
            _init();
            Visible = true;
        }
        private void _writeCart()
        {
            if (_orders == null) return;
            foreach (Order order in _orders)
            {
                KitchenOrderCard kitchenOrderCard = new KitchenOrderCard(order);
                flpOrders.Controls.Add(kitchenOrderCard);    
            }
        }
        private void _init()
        {
            _orders = _getOrders();
            _writeCart();
        }

        private void _reInit()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(_reInit));
                return;
            }

            flpOrders.Controls.Clear();
            _init();
        }

        private List<Order> _getOrders() => _service.GetOrders();


        public void HandleMessageFromSocket(MessageModel message)
        {
            _reInit();
        }

        public override void SetTable(int tableId) { }
    }
}
