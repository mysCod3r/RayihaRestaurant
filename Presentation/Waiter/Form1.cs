using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Extensions;
using RayihaRestaurant.Presentation.Main;
using RayihaRestaurant.Presentation.Module.Views;
using RayihaRestaurant.Presentation.Waiter.Components;
using RayihaRestaurant.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayihaRestaurant.Presentation.Waiter
{
    public partial class Form1 : Form

    {
        private List<string> orders = new List<string>(); // Siparişleri saklamak için bir liste

        private string tableName;
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
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //CountControl();


            foreach (Category category in DummyData.categories)
            {
                CopyCategoryPanel(category);
            }
        }
        private void WaiterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetProductCounts(); // Form kapatıldığında ürün sayılarını sıfırla
        }
        private void ResetProductCounts()
        {
            foreach (var product in DummyData.products)
            {
                product.Count = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void CountControl(Product product, Label label, Label label1, CustomButtonMenu cbmMinus, CustomButtonMenu cbmPlus)
        {
            UpdateTotalPrice();
            if (product.Count > 0)
            {
                label.Text = product.Count.ToString();
                label.Show();
                cbmPlus.Show();
                cbmMinus.Show();
                label1.Hide();
                AddToListSelected(product);
            }
            else
            {
                AddToListSelected(product);
                cbmMinus.Hide();
                cbmPlus.Hide();
                label.Hide();
                label1.Show();
            }
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

        private void CopyCategoryPanel(Category category)
        {
            CustomPanelMenu customPanel = new CustomPanelMenu();
            Label lblItems = new Label();
            Label lblName = new Label();
            PictureBox pictureBox = new PictureBox();

            customPanel.BackColor = Color.White;
            customPanel.BorderRadius = 50;
            customPanel.Controls.Add(lblItems);
            customPanel.Controls.Add(lblName);
            customPanel.ForeColor = Color.White;
            customPanel.Location = new Point(3, 3);
            customPanel.Name = "customPanel";
            customPanel.Size = new Size(109, 110);
            customPanel.TabIndex = 4;
            customPanel.Margin = new Padding(0, 0, 25, 0);
            customPanel.Click += customPanel_Click;

            lblItems.AutoSize = true;
            lblItems.BackColor = Color.Transparent;
            lblItems.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItems.ForeColor = Color.Black;
            lblItems.Location = new Point(18, 83);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(42, 20);
            lblItems.TabIndex = 2;
            lblItems.Text = DummyData.GetProductCountByCategory(category.name, DummyData.products).ToString();


            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(18, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(35, 25);
            lblName.TabIndex = 1;
            lblName.Text = category.name;
            lblName.Click += customPanel_Click;
            flowLayoutPanel1.Controls.Add(customPanel);
        }

        private void CopyProductPanel(Product product)
        {

            CustomPanelMenu customPanel = new CustomPanelMenu();
            Label lblFoodName = new Label();
            Label lblPrice = new Label();
            CustomPanelMenu addToDishPanel = new CustomPanelMenu();
            Label lblAddToDish = new Label();
            CustomButtonMenu cbmPlus = new CustomButtonMenu();
            CustomButtonMenu cbmMinus = new CustomButtonMenu();
            Label lblCount = new Label();

            // 
            // customPanelMenu1
            // 
            customPanel.AutoSize = false;
            customPanel.BackColor = Color.White;
            customPanel.BackgroundImageLayout = ImageLayout.Stretch;
            customPanel.BorderRadius = 50;
            //customPanel.Controls.Add(pictureBox4);
            customPanel.Controls.Add(addToDishPanel);
            customPanel.Controls.Add(lblPrice);
            customPanel.Controls.Add(lblFoodName);
            customPanel.ForeColor = Color.Turquoise;
            customPanel.Location = new Point(3, 3);
            customPanel.Name = "customPanel";
            customPanel.Size = new Size(280, 245);
            customPanel.TabIndex = 5;
            customPanel.Paint += customPanelMenu1_Paint;

            // 
            // label3
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.BackColor = Color.Transparent;
            lblFoodName.CausesValidation = false;
            lblFoodName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodName.ForeColor = Color.Black;
            lblFoodName.Location = new Point(18, 156);
            lblFoodName.Name = "lblFoodName" + product.name;
            lblFoodName.Size = new Size(109, 25);
            lblFoodName.TabIndex = 0;
            lblFoodName.Text = product.name;


            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(0, 147, 44);
            lblPrice.Location = new Point(19, 181);
            lblPrice.Name = "lblPrice" + product.name;
            lblPrice.Size = new Size(25, 19);
            lblPrice.TabIndex = 1;
            lblPrice.Text = product.price.ToString();

            // 
            // customPanelMenu3
            // 
            addToDishPanel.BackColor = Color.FromArgb(204, 233, 213);
            addToDishPanel.BorderRadius = 18;
            addToDishPanel.Controls.Add(lblCount);
            addToDishPanel.Controls.Add(cbmPlus);
            addToDishPanel.Controls.Add(lblAddToDish);
            addToDishPanel.Controls.Add(cbmMinus);
            addToDishPanel.ForeColor = Color.White;
            addToDishPanel.Location = new Point(19, 209);
            addToDishPanel.Name = "addToDishPanel";
            addToDishPanel.Size = new Size(258, 33);
            addToDishPanel.TabIndex = 2;
            addToDishPanel.Click += (sender, e) =>
            {
                CountControl(product, lblCount, lblAddToDish, cbmMinus, cbmPlus);
                if (product.Count > 0)
                {
                    lblAddToDish.Hide();
                    lblCount.Show();
                    cbmMinus.Show();
                    cbmPlus.Show();

                }
                else
                {

                    product.Count = 1;
                    lblCount.Text = product.Count.ToString();

                }


            };
            addToDishPanel.MouseEnter += customButtonMenu1_MouseLeave;

            // 
            // lblAddToDish
            // 
            lblAddToDish.AutoSize = true;
            lblAddToDish.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblAddToDish.ForeColor = Color.Black;
            lblAddToDish.Location = new Point(73, 8);
            lblAddToDish.Name = "lblAddToDish";
            lblAddToDish.Size = new Size(87, 19);
            lblAddToDish.TabIndex = 0;
            lblAddToDish.Text = "Add to Dish";
            lblAddToDish.TextAlign = ContentAlignment.MiddleRight;

            // 
            // cbmPlus
            // 
            cbmPlus.BackColor = Color.Transparent;
            cbmPlus.BackgroundColor = Color.Transparent;
            string? imgPlus = PicturesEnumExtension.PictureConverter((int)Pictures.Plus);
            cbmPlus.BackgroundImage = Image.FromFile(imgPlus ?? "");
            cbmPlus.BackgroundImageLayout = ImageLayout.Center;
            cbmPlus.BorderColor = Color.PaleVioletRed;
            cbmPlus.BorderRadius = 20;
            cbmPlus.BorderSize = 0;
            cbmPlus.FlatAppearance.BorderSize = 0;
            cbmPlus.FlatStyle = FlatStyle.Flat;
            cbmPlus.ForeColor = Color.White;
            cbmPlus.Location = new Point(166, -11);
            cbmPlus.Name = "cbmPlus" + product.id;
            cbmPlus.Size = new Size(53, 57);
            cbmPlus.TabIndex = 3;
            cbmPlus.Text = "+";
            cbmPlus.TextColor = Color.White;
            cbmPlus.UseVisualStyleBackColor = false;
            cbmPlus.Click += (sender, e) =>
            {
                product.Count++;
                lblCount.Text = product.Count.ToString();
                CountControl(product, lblCount, lblAddToDish, cbmMinus, cbmPlus);
                AddToListSelected(product);

            };


            // 
            // cbmMinus
            // 
            cbmMinus.BackColor = Color.Transparent;
            cbmMinus.BackgroundColor = Color.Transparent;
            string? imgMinus = PicturesEnumExtension.PictureConverter((int)Pictures.Minus);
            cbmMinus.BackgroundImage = Image.FromFile(imgMinus ?? "");
            cbmMinus.BackgroundImageLayout = ImageLayout.Center;
            cbmMinus.BorderColor = Color.PaleVioletRed;
            cbmMinus.BorderRadius = 20;
            cbmMinus.BorderSize = 0;
            cbmMinus.FlatAppearance.BorderSize = 0;
            cbmMinus.FlatStyle = FlatStyle.Flat;
            cbmMinus.ForeColor = Color.White;
            cbmMinus.Location = new Point(3, -13);
            cbmMinus.Name = "cbmMinus" + product.id;
            cbmMinus.Size = new Size(54, 53);
            cbmMinus.TabIndex = 3;
            cbmMinus.TextColor = Color.White;
            cbmMinus.UseVisualStyleBackColor = false;
            cbmMinus.Click += (sender, e) =>
            {

                if (product.Count > 0)
                {
                    product.Count--;
                    lblCount.Text = product.Count.ToString();

                    CountControl(product, lblCount, lblAddToDish, cbmMinus, cbmPlus);
                }

            };
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.ForeColor = Color.Black;
            lblCount.Location = new Point(112, 5);
            lblCount.Name = "lblCount" + product.id;
            lblCount.Text = product.Count.ToString();
            lblCount.Size = new Size(20, 23);
            lblCount.TabIndex = 4;

            CountControl(product, lblCount, lblAddToDish, cbmMinus, cbmPlus);
            flowLayoutPanel2.Controls.Add(customPanel);
        }


        private void AddToListSelected(Product product)
        {
            CustomPanelMenu existingPanel = flowLayoutPanel3.Controls
                .OfType<CustomPanelMenu>()
                .FirstOrDefault(panel => panel.Controls
                    .OfType<Label>()
                    .Any(lbl => lbl.Text == product.name));

            if (existingPanel != null)
            {
                Label countLabel = existingPanel.Controls
                    .OfType<Label>()
                    .FirstOrDefault(lbl => lbl.Name == "lblCount" + product.name);

                Label totalLabel = existingPanel.Controls
                    .OfType<Label>()
                    .FirstOrDefault(lbl => lbl.Name == "lblTotal"); // Adjust this to match your lblTotal label name

                if (countLabel != null)
                {
                    countLabel.Text = product.Count.ToString();

                    if (totalLabel != null)
                    {
                        int total = product.price * product.Count;
                        totalLabel.Text = total.ToString();
                    }

                    if (product.Count == 0)
                    {
                        flowLayoutPanel3.Controls.Remove(existingPanel);
                    }
                }
            }
            else
            {
                if (product.Count > 0)
                {

                    CustomPanelMenu customPanelMenu = new CustomPanelMenu();
                    Label lblProductName = new Label();
                    Label lblPrice = new Label();
                    Label lblAmount = new Label();
                    Label lblTotal = new Label();
                    // 
                    // customPanelMenu
                    // 
                    customPanelMenu.BackColor = Color.Transparent;
                    customPanelMenu.BorderRadius = 50;
                    //customPanelMenu.Controls.Add(pictureBox3);
                    customPanelMenu.Controls.Add(lblPrice);
                    customPanelMenu.Controls.Add(lblAmount);
                    customPanelMenu.Controls.Add(lblTotal);
                    customPanelMenu.Controls.Add(lblProductName);
                    customPanelMenu.ForeColor = Color.White;
                    customPanelMenu.Location = new Point(3, 3);
                    customPanelMenu.Name = "customPanelMenu";
                    customPanelMenu.Size = new Size(467, 86);
                    customPanelMenu.TabIndex = 1;
                    customPanelMenu.BorderStyle = BorderStyle.FixedSingle;
                    customPanelMenu.Padding = new Padding(10, 0, 0, 0);


                    // 
                    // lblPrice
                    // 
                    lblPrice.AutoSize = true;
                    lblPrice.BackColor = Color.Transparent;
                    lblPrice.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                    lblPrice.ForeColor = Color.FromArgb(0, 147, 44);
                    lblPrice.Location = new Point(130, 45);
                    lblPrice.Name = "label11";
                    lblPrice.Size = new Size(43, 19);
                    lblPrice.TabIndex = 6;
                    lblPrice.Text = product.price.ToString();

                    // 
                    // lblTotal
                    // 
                    lblTotal.AutoSize = true;
                    lblTotal.BackColor = Color.Transparent;
                    lblTotal.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                    lblTotal.ForeColor = Color.FromArgb(0, 147, 44);
                    lblTotal.Location = new Point(385, 49);
                    lblTotal.Name = "lblTotal";
                    lblTotal.Size = new Size(42, 19);
                    lblTotal.TabIndex = 2;
                    int total = product.price * product.Count;
                    lblTotal.Text = total.ToString();

                    // 
                    // lblAmount
                    // 
                    lblAmount.AutoSize = true;
                    lblAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    lblAmount.ForeColor = Color.Gray;
                    lblAmount.Location = new Point(175, 42);
                    lblAmount.Name = "lblCount" + product.name;
                    lblAmount.Size = new Size(20, 23);
                    lblAmount.TabIndex = 5;
                    lblAmount.Text = product.Count.ToString();

                    // 
                    // lblProductName
                    // 
                    lblProductName.AutoSize = true;
                    lblProductName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    lblProductName.ForeColor = Color.Black;
                    lblProductName.Location = new Point(127, 20);
                    lblProductName.Name = product.name;
                    lblProductName.Size = new Size(109, 25);
                    lblProductName.TabIndex = 0;
                    lblProductName.Text = product.name;
                    lblTotal.Text = total.ToString(); // Update the lblTotal text here

                    flowLayoutPanel3.Controls.Add(customPanelMenu);

                }
                UpdateTotalPrice();
            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void customPanel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();

            if (sender is CustomPanelMenu clickedPanel)
            {
                string categoryName = clickedPanel.Controls
                    .OfType<Label>()
                    .FirstOrDefault(lbl => lbl.Name == "lblName")?.Text;

                if (!string.IsNullOrEmpty(categoryName))
                {
                    IEnumerable<Product> productsInCategory = DummyData.products.Where(product => product.category.name == categoryName);

                    foreach (Product item in productsInCategory)
                    {
                        CopyProductPanel(item);
                    }
                }
            }
        }

        private void customPanelMenu1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateTotalPrice()
        {
            int totalPrice = 0;

            foreach (var product in DummyData.products)
            {
                totalPrice += product.price * product.Count;
            }

            // totalPrice'i toplam tutar etiketine ata
            lblTotalAmount.Text = "Toplam Tutar: " + totalPrice.ToString();
        }

        private void customButtonMenu1_Click(object sender, EventArgs e)
        {
            TablesForm tablesForm = new TablesForm();
            this.Hide();

            tablesForm.Show();
        }  // Sipariş ekleme işlemi

        private void customButtonMenu3_Click(object sender, EventArgs e)
        {
            panel5.Controls.Add(flowLayoutPanel3);
        }
    }
}
