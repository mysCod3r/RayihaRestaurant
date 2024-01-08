
using RayihaRestaurant.Presentation.Components;

namespace RayihaRestaurant.Presentation.Waiter
{
    partial class WaiterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterForm));
            pnlLeft = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new CustomButton();
            btnTables = new CustomButton();
            pnlRight = new Panel();
            cbAddOrder = new CustomButton();
            flpCart = new FlowLayoutPanel();
            flpProducts = new FlowLayoutPanel();
            lblTableNo = new Label();
            flpCategories = new FlowLayoutPanel();
            pnlCenter = new Panel();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRight.SuspendLayout();
            pnlCenter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(pictureBox1);
            pnlLeft.Controls.Add(btnLogout);
            pnlLeft.Controls.Add(btnTables);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 40);
            pnlLeft.Margin = new Padding(3, 2, 3, 2);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size((int)(Width * 0.15), Height - 40);
            pnlLeft.TabIndex = 0;
            // 
            // pnlCenter
            // 
            pnlCenter.Controls.Add(flpProducts);
            pnlCenter.Controls.Add(flpCategories);
            pnlCenter.Location = new Point(pnlLeft.Width, 40);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size((int)(Width * 0.55), Height - 40);
            pnlCenter.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(cbAddOrder);
            pnlRight.Controls.Add(flpCart);
            pnlRight.Controls.Add(lblTableNo);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(pnlLeft.Width + pnlCenter.Width, 40);
            pnlRight.Margin = new Padding(3, 2, 3, 2);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size((int)(Width * 0.3), Height - 40);
            pnlRight.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 50);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(pnlLeft.Width-32, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // customButtonMenu2
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackgroundColor = Color.Transparent;
            btnLogout.BorderColor = Color.PaleVioletRed;
            btnLogout.BorderRadius = 20;
            btnLogout.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 147, 44);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Image = (Image)resources.GetObject("customButtonMenu2.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(22, pnlLeft.Height - 64);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "customButtonMenu2";
            btnLogout.Padding = new Padding(9, 2, 2, 2);
            btnLogout.Size = new Size(141, 38);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.TextColor = Color.Black;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.MouseEnter += _btnLogoutMouseEnter;
            btnLogout.MouseLeave += _btnLogoutMouseLeave;
            // 
            // customButtonMenu1
            // 
            btnTables.BackColor = Color.Transparent;
            btnTables.BackgroundColor = Color.Transparent;
            btnTables.BorderColor = Color.PaleVioletRed;
            btnTables.BorderRadius = 20;
            btnTables.BorderSize = 0;
            btnTables.FlatAppearance.BorderSize = 0;
            btnTables.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 147, 44);
            btnTables.FlatStyle = FlatStyle.Flat;
            btnTables.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTables.ForeColor = Color.Black;
            btnTables.Image = (Image)resources.GetObject("customButtonMenu1.Image");
            btnTables.ImageAlign = ContentAlignment.MiddleLeft;
            btnTables.Location = new Point(22, 175);
            btnTables.Margin = new Padding(3, 2, 3, 2);
            btnTables.Name = "customButtonMenu1";
            btnTables.Size = new Size(141, 34);
            btnTables.TabIndex = 4;
            btnTables.Text = "Tables";
            btnTables.TextColor = Color.Black;
            btnTables.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTables.UseVisualStyleBackColor = false;
            btnTables.Click += _tablesButton;
            btnTables.MouseEnter += customButtonMenu1_MouseEnter;
            btnTables.MouseLeave += customButtonMenu1_MouseLeave;
           
            
            // 
            // cbAddOrder
            // 
            cbAddOrder.BackColor = Color.MediumSlateBlue;
            cbAddOrder.BackgroundColor = Color.MediumSlateBlue;
            cbAddOrder.BorderColor = Color.PaleVioletRed;
            cbAddOrder.BorderRadius = 20;
            cbAddOrder.BorderSize = 0;
            cbAddOrder.FlatAppearance.BorderSize = 0;
            cbAddOrder.FlatStyle = FlatStyle.Flat;
            cbAddOrder.ForeColor = Color.White;
            cbAddOrder.Location = new Point(58, 551);
            cbAddOrder.Margin = new Padding(3, 2, 3, 2);
            cbAddOrder.Name = "cbAddOrder";
            cbAddOrder.Size = new Size(164, 38);
            cbAddOrder.TabIndex = 0;
            cbAddOrder.Text = "Siparişi Onayla";
            cbAddOrder.TextColor = Color.White;
            cbAddOrder.UseVisualStyleBackColor = false;
            cbAddOrder.Click += customButtonMenu3_Click;
            // 
            // flpCart
            // 
            flpCart.AutoScroll = true;
            flpCart.FlowDirection = FlowDirection.TopDown;
            flpCart.Location = new Point(0, 98);
            flpCart.Margin = new Padding(3, 2, 3, 2);
            flpCart.Name = "flpCart";
            flpCart.Padding = new Padding(9, 0, 0, 0);
            flpCart.Size = new Size(pnlRight.Width, pnlRight.Height - 100);
            flpCart.TabIndex = 7;
            // 
            // flpProducts
            // 
            flpProducts.Location = new Point(3, 98);
            flpProducts.Margin = new Padding(3, 2, 3, 2);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(600, 533);
            flpProducts.TabIndex = 7;
            // 
            // lblTableNo
            // 
            lblTableNo.AutoSize = true;
            lblTableNo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTableNo.Location = new Point(32, 50);
            lblTableNo.Name = "lblTableNo";
            lblTableNo.Size = new Size(90, 25);
            lblTableNo.TabIndex = 0;
            lblTableNo.Text = "Table No";
            // 
            // flpCategories
            // 
            flpCategories.AutoScroll = true;
            flpCategories.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpCategories.Location = new Point(3, 2);
            flpCategories.Margin = new Padding(3, 2, 3, 2);
            flpCategories.Name = "flpCategories";
            flpCategories.Padding = new Padding(35, 15, 35, 15);
            flpCategories.Size = new Size(600, 92);
            flpCategories.TabIndex = 6;
            // 
            // WaiterForm
            // 
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ControlBox = false;
            Controls.Add(pnlCenter);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "WaiterForm";
            Text = "Form1";
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            pnlCenter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlRight;
        private CustomButton btnTables;
        private PictureBox pictureBox1;
        private Label lblCount;
        private Label lblTableNo;
        private Label lblCategoriName;
        private FlowLayoutPanel flpCategories;
        private FlowLayoutPanel flpProducts;
        private FlowLayoutPanel flpCart;
        private CustomButton cbAddOrder;
        private CustomButton btnLogout;
        private Panel pnlCenter;
    }
}