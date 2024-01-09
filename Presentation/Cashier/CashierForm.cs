using RayihaRestaurant.Core.Base;
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Presentation.Cashier.Components;


namespace Rayiha.Presentation.Cashier
{
    public partial class CashierForm : BaseForm, IMessageHandler
    {
        public override Size WindowSize => new Size(700, 580);
        public override string WindowPanelName => "Cashier";
        public ClientType ClientType => ClientType.Cashier;
        private int _tableId;
        private List<Order> _orders = new List<Order>();
        private readonly SocketClient _socketClient;
        private readonly CashierService _service;
        public CashierForm()
        {
            _socketClient = new SocketClient();
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _service = new CashierService(new DatabaseContext());
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //if (_orders.Count == 0) return;
            _service.Checkout(_tableId);
            MessageBox.Show("Ödeme Alındı.");
            _socketClient.SendMessage(new MessageModel { message = "Ödeme alındı.", sender = ClientType});
            Hide();
        }

        public override void Open()
        {
            flowLayoutPanel1.Controls.Clear();
            _init();
            Visible = true;
        }

        public override void SetTable(int tableId) => _tableId = tableId;

        private void _init()
        {
            _getOrders();
            _writeCart();
            _writeTotalAmount();
        }
        
        private void _writeCart()
        {
            foreach (Order order in _orders)
            {
                foreach (OrderDetail detail in order.OrderDetails)
                {
                    CashierOrderCartItem cashierOrderCartItem = new CashierOrderCartItem(detail);
                    flowLayoutPanel1.Controls.Add(cashierOrderCartItem);
                }
            }
        }

        private void _writeTotalAmount()
        {
            double totalAmount = 0;
            foreach (Order order in _orders)
            {
                totalAmount += (order?.TotalPrice ?? 0);
            }
            lblTotalAmount.Text = "Total Amount: " + totalAmount.ToString();
        }

        private void _reInit()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(_reInit));
                return;
            }

            flowLayoutPanel1.Controls.Clear();
            _init();
        }

        public void HandleMessageFromSocket(MessageModel message)
        {
            _reInit();
        }
        private void _getOrders() => _orders = _service.GetOrders(_tableId);

    }
}
