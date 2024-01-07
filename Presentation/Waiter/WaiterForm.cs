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
        public override Size WindowSize => new Size(1024, 768);
        public override string WindowPanelName => "Waiter";
        public int tableId { get; set; }
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
            customButtonMenu1.BackColor = ColorTranslator.FromHtml("#00932c");
            customButtonMenu1.ForeColor = Color.White;
            string? tableWhite = PicturesEnumExtension.PictureConverter((int)Pictures.Table_white);
            customButtonMenu1.Image = Image.FromFile(tableWhite ?? "");
            customButtonMenu1.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void customButtonMenu1_MouseLeave(object sender, EventArgs e)
        {
            customButtonMenu1.BackColor = Color.White;
            customButtonMenu1.ForeColor = Color.Black;
            string? table = PicturesEnumExtension.PictureConverter((int)Pictures.Table);
            customButtonMenu1.Image = Image.FromFile(table ?? "");
            customButtonMenu1.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void customButtonMenu2_MouseEnter(object sender, EventArgs e)
        {
            customButtonMenu2.BackColor = ColorTranslator.FromHtml("#00932c");
            customButtonMenu2.ForeColor = Color.White;
            string? img = PicturesEnumExtension.PictureConverter((int)Pictures.Logout_white);
            customButtonMenu2.Image = Image.FromFile(img ?? "");
            customButtonMenu1.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void customButtonMenu2_MouseLeave(object sender, EventArgs e)
        {
            customButtonMenu2.BackColor = Color.White;
            customButtonMenu2.ForeColor = Color.Black;
            string? img = PicturesEnumExtension.PictureConverter((int)Pictures.Logout);
            customButtonMenu2.Image = Image.FromFile(img ?? "");
            customButtonMenu2.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void GetCategoryPanel(Category category)
        {
            CategoryPanelMenu menu = new CategoryPanelMenu(category, customPanel_Click);
            flowLayoutCategoryPanel.Controls.Add(menu);
        }


        private void CopyProductPanel(Product product)
        {

            ProductPanelMenu productPanelMenu = new ProductPanelMenu(product, flowLayoutPanelCart);
            flowLayoutProductPanel.Controls.Add(productPanelMenu);
        }

        private void customPanel_Click(object? sender, EventArgs e)
        {
            flowLayoutProductPanel.Controls.Clear();

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
            foreach (CartItem item in flowLayoutPanelCart.Controls)
            {
                orderItems.Add(item.orderItem);
            }
            _service.AddNewOrder(tableId, orderItems);
            MessageModel msg = new MessageModel { sender = ClientType, message = "Sipariş mutfağa iletildi" };
            _socketClient.SendMessage(msg);
            //MessageBox.Show(msg.message);
        }
        
        private void _tablesButton(object sender, EventArgs e) => Hide();

        public void Open()
        {
            flowLayoutProductPanel.Controls.Clear();
            flowLayoutPanelCart.Controls.Clear();
            lblTableNo.Text = "Table No: " + tableId.ToString();
            Visible = true;
        }

        public void HandleMessageFromSocket(MessageModel message) { }
    }
}
