
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
            pictureBox1.Size = new Size(pnlLeft.Width - 32, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnTables
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
            cbAddOrder.BackColor = Color.FromArgb(0, 147, 44);
            cbAddOrder.BackgroundColor = Color.FromArgb(0, 147, 44);
            cbAddOrder.BorderColor = Color.PaleVioletRed;
            cbAddOrder.BorderRadius = 20;
            cbAddOrder.BorderSize = 0;
            cbAddOrder.FlatAppearance.BorderSize = 0;
            cbAddOrder.FlatStyle = FlatStyle.Flat;
            cbAddOrder.ForeColor = Color.White;
            cbAddOrder.Text = "Siparişi Onayla";
            cbAddOrder.Size = new Size(120, 40);
            cbAddOrder.Location = new Point((pnlRight.Width / 2) - (60), pnlLeft.Height - 4);
            cbAddOrder.Name = "cbAddOrder";
            cbAddOrder.TabIndex = 0;
            cbAddOrder.TextColor = Color.White;
            cbAddOrder.UseVisualStyleBackColor = false;
            cbAddOrder.Click += customButtonMenu3_Click;
            // 
            // flpCart
            // 
            flpCart.AutoScroll = true;
            flpCart.Location = new Point(0, 98);
            flpCart.Margin = new Padding(3, 2, 3, 2);
            flpCart.Name = "flpCart";
            flpCart.Padding = new Padding(9, 0, 0, 0);
            flpCart.Size = new Size(pnlRight.Width, pnlRight.Height - 100);
            flpCart.TabIndex = 7;
            // 
            // flpCategories
            // 
            flpCategories.AutoScroll = true;
            flpCategories.Location = new Point(3, 2);
            flpCategories.Name = "flpCategories";
            flpCategories.Size = new Size(pnlCenter.Width, 130);
            flpCategories.TabIndex = 6;
            // 
            // flpProducts
            // 
            flpProducts.Location = new Point(3, 138);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(pnlCenter.Width, Height - (flpCategories.Height + 60));
            flpProducts.TabIndex = 7;
            flpProducts.AutoScroll = true;
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

        private Label lblCount;
        private Label lblTableNo;
        private Label lblCategoriName;
        private Panel pnlLeft;
        private Panel pnlCenter;
        private Panel pnlRight;
        private FlowLayoutPanel flpCategories;
        private FlowLayoutPanel flpProducts;
        private FlowLayoutPanel flpCart;
        private CustomButton btnTables;
        private CustomButton cbAddOrder;
        private PictureBox pictureBox1;
    }
}