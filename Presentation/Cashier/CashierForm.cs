using RayihaRestaurant.Core.Base;
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Presentation.Cashier.Components;
using System.Runtime.InteropServices;


namespace Rayiha.Presentation.Cashier
{
    public partial class CashierForm : BaseForm, IMessageHandler
    {
        public override Size WindowSize => new Size(700, 580);
        public override string WindowPanelName => "Cashier";
        public ClientType ClientType => ClientType.Cashier;
        public int tableId { get; set; }
        private List<Order>? _orders;
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
            _service.Checkout(_orders);
            MessageBox.Show("Ödeme Alındı.");
            Hide();
        }

        public void Open()
        {
            flowLayoutPanel1.Controls.Clear();
            _init();
            Visible = true;
        }
        private void _init()
        {
            _orders = _getOrders();
            _writeCart();
            _writeTotalAmount();
        }
        
        private void _writeCart()
        {
            if (_orders == null) return;
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
            if (_orders == null) return;
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
        private List<Order> _getOrders() => _service.GetOrders(tableId);

    }
}
