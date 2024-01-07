
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            customButtonMenu2 = new CustomButton();
            customButtonMenu1 = new CustomButton();
            panel2 = new Panel();
            cbAddOrder = new CustomButton();
            panel3 = new Panel();
            flowLayoutPanelCart = new FlowLayoutPanel();
            button1 = new Button();
            lblTableNo = new Label();
            flowLayoutCategoryPanel = new FlowLayoutPanel();
            flowLayoutProductPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(customButtonMenu2);
            panel1.Controls.Add(customButtonMenu1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 261);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 30);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // customButtonMenu2
            // 
            customButtonMenu2.BackColor = Color.Transparent;
            customButtonMenu2.BackgroundColor = Color.Transparent;
            customButtonMenu2.BorderColor = Color.PaleVioletRed;
            customButtonMenu2.BorderRadius = 20;
            customButtonMenu2.BorderSize = 0;
            customButtonMenu2.FlatAppearance.BorderSize = 0;
            customButtonMenu2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 147, 44);
            customButtonMenu2.FlatStyle = FlatStyle.Flat;
            customButtonMenu2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButtonMenu2.ForeColor = Color.Black;
            customButtonMenu2.Image = (Image)resources.GetObject("customButtonMenu2.Image");
            customButtonMenu2.ImageAlign = ContentAlignment.MiddleLeft;
            customButtonMenu2.Location = new Point(22, 579);
            customButtonMenu2.Margin = new Padding(3, 2, 3, 2);
            customButtonMenu2.Name = "customButtonMenu2";
            customButtonMenu2.Padding = new Padding(9, 2, 2, 2);
            customButtonMenu2.Size = new Size(141, 38);
            customButtonMenu2.TabIndex = 6;
            customButtonMenu2.Text = "Logout";
            customButtonMenu2.TextColor = Color.Black;
            customButtonMenu2.UseVisualStyleBackColor = false;
            customButtonMenu2.MouseEnter += customButtonMenu2_MouseEnter;
            customButtonMenu2.MouseLeave += customButtonMenu2_MouseLeave;
            // 
            // customButtonMenu1
            // 
            customButtonMenu1.BackColor = Color.Transparent;
            customButtonMenu1.BackgroundColor = Color.Transparent;
            customButtonMenu1.BorderColor = Color.PaleVioletRed;
            customButtonMenu1.BorderRadius = 20;
            customButtonMenu1.BorderSize = 0;
            customButtonMenu1.FlatAppearance.BorderSize = 0;
            customButtonMenu1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 147, 44);
            customButtonMenu1.FlatStyle = FlatStyle.Flat;
            customButtonMenu1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButtonMenu1.ForeColor = Color.Black;
            customButtonMenu1.Image = (Image)resources.GetObject("customButtonMenu1.Image");
            customButtonMenu1.ImageAlign = ContentAlignment.MiddleLeft;
            customButtonMenu1.Location = new Point(22, 175);
            customButtonMenu1.Margin = new Padding(3, 2, 3, 2);
            customButtonMenu1.Name = "customButtonMenu1";
            customButtonMenu1.Size = new Size(141, 34);
            customButtonMenu1.TabIndex = 4;
            customButtonMenu1.Text = "Tables";
            customButtonMenu1.TextColor = Color.Black;
            customButtonMenu1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButtonMenu1.UseVisualStyleBackColor = false;
            customButtonMenu1.Click += _tablesButton;
            customButtonMenu1.MouseEnter += customButtonMenu1_MouseEnter;
            customButtonMenu1.MouseLeave += customButtonMenu1_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cbAddOrder);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(222, 200);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(62, 61);
            panel2.TabIndex = 0;
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
            cbAddOrder.Location = new Point(980, 14);
            cbAddOrder.Margin = new Padding(3, 2, 3, 2);
            cbAddOrder.Name = "cbAddOrder";
            cbAddOrder.Size = new Size(164, 38);
            cbAddOrder.TabIndex = 0;
            cbAddOrder.Text = "Siparişi Onayla";
            cbAddOrder.TextColor = Color.White;
            cbAddOrder.UseVisualStyleBackColor = false;
            cbAddOrder.Click += customButtonMenu3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(flowLayoutPanelCart);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(lblTableNo);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(-167, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 200);
            panel3.TabIndex = 1;
            // 
            // flowLayoutPanelCart
            // 
            flowLayoutPanelCart.AutoScroll = true;
            flowLayoutPanelCart.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelCart.Location = new Point(0, 89);
            flowLayoutPanelCart.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelCart.Name = "flowLayoutPanelCart";
            flowLayoutPanelCart.Padding = new Padding(9, 0, 0, 0);
            flowLayoutPanelCart.Size = new Size(451, 490);
            flowLayoutPanelCart.TabIndex = 7;
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
            // flowLayoutCategoryPanel
            // 
            flowLayoutCategoryPanel.AutoScroll = true;
            flowLayoutCategoryPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutCategoryPanel.Dock = DockStyle.Top;
            flowLayoutCategoryPanel.Location = new Point(222, 0);
            flowLayoutCategoryPanel.Margin = new Padding(3, 2, 3, 2);
            flowLayoutCategoryPanel.Name = "flowLayoutCategoryPanel";
            flowLayoutCategoryPanel.Padding = new Padding(35, 15, 35, 15);
            flowLayoutCategoryPanel.Size = new Size(0, 117);
            flowLayoutCategoryPanel.TabIndex = 6;
            // 
            // flowLayoutProductPanel
            // 
            flowLayoutProductPanel.AutoScroll = true;
            flowLayoutProductPanel.Location = new Point(222, 117);
            flowLayoutProductPanel.Margin = new Padding(3, 2, 3, 2);
            flowLayoutProductPanel.Name = "flowLayoutProductPanel";
            flowLayoutProductPanel.Size = new Size(886, 462);
            flowLayoutProductPanel.TabIndex = 7;
            // 
            // WaiterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ControlBox = false;
            Controls.Add(flowLayoutProductPanel);
            Controls.Add(flowLayoutCategoryPanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "WaiterForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private CustomButton customButtonMenu1;
        private CustomButton customButtonMenu2;
        private PictureBox pictureBox1;
        private Label lblCount;
        private CustomButton cbmPlus;
        private Label label5;
        private CustomButton cbmMinus;
        private Label label4;
        private Label label3;
        private Label lblTableNo;
        private PictureBox pictureBox4;
        private Button button1;
        private Label label2;
        private Label lblCategoriName;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutCategoryPanel;
        private FlowLayoutPanel flowLayoutProductPanel;
        private FlowLayoutPanel flowLayoutPanelCart;
        private CustomButton cbAddOrder;
    }
}