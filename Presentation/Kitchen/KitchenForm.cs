using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Presentation.Waiter.Components;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Rayiha.Presentation.Kitchen
{

    public partial class KitchenForm : Form
    {
        public int tableId { get; set; }
        private List<Order>? _orders;
        private readonly KitchenService _service;
        private readonly SocketClient _socketClient;
        private readonly ClientType _clientType;

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
        public KitchenForm()
        {
            _socketClient = new SocketClient();
            _clientType = ClientType.Kitchen;
            _service = new KitchenService(new DatabaseContext());
            _orders = _service.GetOrders();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            CheckForIllegalCrossThreadCalls = false;
            Open();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        public void Open()
        {
            _orders = _service.GetOrders();
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
            _writeCart();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
