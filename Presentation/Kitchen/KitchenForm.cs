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
                KitchenOrderCard kitchenOrderCard = new KitchenOrderCard(order, onClick: () => _onClick(order: order));
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

        private void _onClick(Order order)
        {
            _socketClient.SendMessage(new MessageModel { message = "Sipariş durumu güncellendi", sender = ClientType});
            _service.UpdateOrderStatus(order);
        }

        public override void SetTable(int tableId) { }
    }
}
