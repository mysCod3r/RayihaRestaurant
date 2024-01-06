using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Presentation.Main;
using RayihaRestaurant.Presentation.Waiter.Components;
using System.Runtime.InteropServices;


namespace Rayiha.Presentation.Cashier
{
    public partial class CashierForm : Form
    {
        public int tableId { get; set; }
        private List<Order>? _orders;
        private readonly SocketClient _socketClient;
        private readonly ClientType _clientType;
        private readonly CashierService _service;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public CashierForm()
        {
            _socketClient = new SocketClient();
            _clientType = ClientType.Cashier;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _service = new CashierService(new DatabaseContext());
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnClose_Click(object sender, EventArgs e) => _close();

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            _service.Checkout(_orders);
            MessageBox.Show("Ödeme Alındı.");
            _close();
        }

        public void Open()
        {
            flowLayoutPanel1.Controls.Clear();
            _orders = _service.GetOrders(tableId);
            _init();
            Visible = true;
        }
        private void _init()
        {
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

        private void _close() => Hide();
    }
}
