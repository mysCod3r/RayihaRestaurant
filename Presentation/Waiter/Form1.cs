using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Extensions;
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Data;
using RayihaRestaurant.Data.Service;
using RayihaRestaurant.Presentation.Module.Views;
using RayihaRestaurant.Presentation.Waiter.Components;
using System.Data;
using System.Runtime.InteropServices;

namespace RayihaRestaurant.Presentation.Waiter
{
    public partial class Form1 : Form

    {
        private readonly WaiterService _service;
        private List<Category> _categories;
        private List<Product> _products;

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
        public Form1()
        {
            _service = new WaiterService(new DatabaseContext());
            _categories = _service.GetCategories();
            _products = _service.GetProducts();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //CountControl();
            flowLayoutPanelCart.ControlAdded += FlowLayoutPanel_ControlAdded;
            flowLayoutPanelCart.ControlRemoved += FlowLayoutPanel_ControlRemoved;

            foreach (Category category in _categories)
            {
                GetCategoryPanel(category);
            }
        }

        private void FlowLayoutPanel_ControlAdded(object? sender, ControlEventArgs e)
        {
            // TOTAL PRICE YÖNET
            MessageBox.Show($"Öğe eklendi: {e.Control?.Name}");
        }

        private void FlowLayoutPanel_ControlRemoved(object? sender, ControlEventArgs e)
        {
            // TOTAL PRICE YÖNET
            MessageBox.Show($"Öğe kaldırıldı: {e.Control?.Name}");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void GetCategoryPanel(Category category)
        {
            CategoryPanelMenu menu = new CategoryPanelMenu(category, customPanel_Click);
            flowLayoutPanel1.Controls.Add(menu);
        }


        private void CopyProductPanel(Product product)
        {

            ProductPanelMenu productPanelMenu = new ProductPanelMenu(product, flowLayoutPanelCart);
            flowLayoutPanel2.Controls.Add(productPanelMenu);
        }

        private void customPanel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();

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

        private void customButtonMenu1_Click(object sender, EventArgs e)
        {
            TablesForm tablesForm = new TablesForm();
            this.Hide();

            tablesForm.Show();
        }  

        private void customButtonMenu3_Click(object sender, EventArgs e)
        {
            panel5.Controls.Add(flowLayoutPanelCart);
        }
    }
}
