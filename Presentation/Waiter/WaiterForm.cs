using RayihaRestaurant.Core.Base;
using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Extensions;
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Core.Socket;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Presentation.Waiter.Components;
using System.Data;

namespace RayihaRestaurant.Presentation.Waiter
{
    public partial class WaiterForm : BaseForm, IMessageHandler
    {
        public ClientType ClientType => ClientType.Waiter;
        public override Size WindowSize => new Size(1100, 700);
        public override string WindowPanelName => "Waiter";
        private int _tableId;
        private readonly WaiterService _service;
        private List<Category> _categories;
        private List<Product> _products;
        private readonly SocketClient _socketClient;
       
        public WaiterForm()
        {
            _socketClient = new SocketClient();
            _service = new WaiterService(new DatabaseContext());
            _categories = _service.GetCategories();
            _products = _service.GetProducts();
            InitializeComponent();

            foreach (Category category in _categories)
            {
                GetCategoryPanel(category);
            }
        }

        private void customButtonMenu1_MouseEnter(object sender, EventArgs e)
        {
            btnTables.BackColor = ColorTranslator.FromHtml("#00932c");
            btnTables.ForeColor = Color.White;
            Bitmap? tableWhite = PicturesEnumExtension.PictureConverter((int)Pictures.Table_white);
            btnTables.Image = tableWhite;
            btnTables.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void customButtonMenu1_MouseLeave(object sender, EventArgs e)
        {
            btnTables.BackColor = Color.White;
            btnTables.ForeColor = Color.Black;
            Bitmap? table = PicturesEnumExtension.PictureConverter((int)Pictures.Table);
            btnTables.Image = table;
            btnTables.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void _btnLogoutMouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = ColorTranslator.FromHtml("#00932c");
            btnLogout.ForeColor = Color.White;
            Bitmap? img = PicturesEnumExtension.PictureConverter((int)Pictures.Logout_white);
            btnLogout.Image = img;
            btnTables.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void _btnLogoutMouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.White;
            btnLogout.ForeColor = Color.Black;
            Bitmap? img = PicturesEnumExtension.PictureConverter((int)Pictures.Logout);
            btnLogout.Image = img;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void GetCategoryPanel(Category category)
        {
            CategoryPanelMenu menu = new CategoryPanelMenu(category, customPanel_Click);
            flpCategories.Controls.Add(menu);
        }


        private void CopyProductPanel(Product product)
        {

            ProductPanelMenu productPanelMenu = new ProductPanelMenu(product, flpCart);
            flpProducts.Controls.Add(productPanelMenu);
        }

        private void customPanel_Click(object? sender, EventArgs e)
        {
            flpProducts.Controls.Clear();

            if (sender is CategoryPanelMenu clickedPanel)
            {
                Category category = clickedPanel.category;

                IEnumerable<Product> productsInCategory = _products.Where(product => product.Category == category);
                foreach (Product item in productsInCategory)
                {
                    CopyProductPanel(item);
                }
            }
        }

        private void customButtonMenu3_Click(object sender, EventArgs e)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (CartItem item in flpCart.Controls)
            {
                orderItems.Add(item.orderItem);
            }
            _service.AddNewOrder(_tableId, orderItems);
            _service.UpdateTableStatusToUnavailable(_tableId);
            MessageModel msg = new MessageModel { sender = ClientType, message = "Sipariş mutfağa iletildi" };
            _socketClient.SendMessage(msg);
            MessageBox.Show(msg.message);
        }
        
        private void _tablesButton(object sender, EventArgs e) => Hide();

        public override void Open()
        {
            flpProducts.Controls.Clear();
            flpCart.Controls.Clear();
            lblTableNo.Text = "Table No: " + _tableId.ToString();
            Visible = true;
        }
        
        public override void SetTable(int tableId) => _tableId = tableId;

        public void HandleMessageFromSocket(MessageModel message) { }
    }
}
