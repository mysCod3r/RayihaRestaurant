namespace Rayiha.Presentation.Kitchen
{
    partial class KitchenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenForm));
            button1 = new Button();
            flpOrders = new FlowLayoutPanel();
            customPanel1 = new RayihaRestaurant.Presentation.Waiter.Components.CustomPanel();
            flpProducts = new FlowLayoutPanel();
            pnlBtnStatus = new Panel();
            btnStatus = new RayihaRestaurant.Presentation.Waiter.Components.CustomButton();
            lblTableNo = new Label();
            cpOrderItem = new RayihaRestaurant.Presentation.Waiter.Components.CustomPanel();
            lblProdcutName = new Label();
            lblQuantity = new Label();
            flpOrders.SuspendLayout();
            customPanel1.SuspendLayout();
            flpProducts.SuspendLayout();
            pnlBtnStatus.SuspendLayout();
            cpOrderItem.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1711, 12);
            button1.Name = "button1";
            button1.Size = new Size(59, 47);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnClose_Click;
            // 
            // flpOrders
            // 
            flpOrders.AutoScroll = true;
            flpOrders.Controls.Add(customPanel1);
            flpOrders.Location = new Point(2, 65);
            flpOrders.Name = "flpOrders";
            flpOrders.Size = new Size(1782, 787);
            flpOrders.TabIndex = 2;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 50;
            customPanel1.Controls.Add(flpProducts);
            customPanel1.Controls.Add(pnlBtnStatus);
            customPanel1.Controls.Add(lblTableNo);
            customPanel1.Location = new Point(3, 3);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(338, 541);
            customPanel1.TabIndex = 0;
            // 
            // flpProducts
            // 
            flpProducts.AutoScroll = true;
            flpProducts.Controls.Add(cpOrderItem);
            flpProducts.Location = new Point(0, 67);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(335, 386);
            flpProducts.TabIndex = 3;
            // 
            // pnlBtnStatus
            // 
            pnlBtnStatus.Controls.Add(btnStatus);
            pnlBtnStatus.Location = new Point(41, 459);
            pnlBtnStatus.Name = "pnlBtnStatus";
            pnlBtnStatus.Size = new Size(244, 65);
            pnlBtnStatus.TabIndex = 2;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.Red;
            btnStatus.BackgroundColor = Color.Red;
            btnStatus.BorderColor = Color.PaleVioletRed;
            btnStatus.BorderRadius = 20;
            btnStatus.BorderSize = 0;
            btnStatus.FlatAppearance.BorderSize = 0;
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.ForeColor = Color.White;
            btnStatus.Location = new Point(21, 10);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(198, 52);
            btnStatus.TabIndex = 1;
            btnStatus.Text = "Bekliyor...";
            btnStatus.TextColor = Color.White;
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // lblTableNo
            // 
            lblTableNo.AutoSize = true;
            lblTableNo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTableNo.Location = new Point(26, 29);
            lblTableNo.Name = "lblTableNo";
            lblTableNo.Size = new Size(92, 25);
            lblTableNo.TabIndex = 0;
            lblTableNo.Text = "Masa No:";
            // 
            // cpOrderItem
            // 
            cpOrderItem.BorderRadius = 50;
            cpOrderItem.Controls.Add(lblQuantity);
            cpOrderItem.Controls.Add(lblProdcutName);
            cpOrderItem.Location = new Point(3, 3);
            cpOrderItem.Name = "cpOrderItem";
            cpOrderItem.Size = new Size(312, 66);
            cpOrderItem.TabIndex = 1;
            // 
            // lblProdcutName
            // 
            lblProdcutName.AutoSize = true;
            lblProdcutName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdcutName.ForeColor = Color.FromArgb(0, 147, 44);
            lblProdcutName.Location = new Point(38, 23);
            lblProdcutName.Name = "lblProdcutName";
            lblProdcutName.Size = new Size(125, 23);
            lblProdcutName.TabIndex = 0;
            lblProdcutName.Text = "Prodcut Name";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Gray;
            lblQuantity.Location = new Point(178, 23);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(79, 23);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity";
            // 
            // KitchenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 853);
            Controls.Add(flpOrders);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KitchenForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "KitchenForm";
            FormClosing += KitchenForm_FormClosing;
            Load += KitchenForm_Load;
            flpOrders.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            flpProducts.ResumeLayout(false);
            pnlBtnStatus.ResumeLayout(false);
            cpOrderItem.ResumeLayout(false);
            cpOrderItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flpOrders;
        private RayihaRestaurant.Presentation.Waiter.Components.CustomPanel customPanel1;
        private RayihaRestaurant.Presentation.Waiter.Components.CustomButton btnStatus;
        private Label lblTableNo;
        private FlowLayoutPanel flpProducts;
        private Panel pnlBtnStatus;
        private RayihaRestaurant.Presentation.Waiter.Components.CustomPanel cpOrderItem;
        private Label lblProdcutName;
        private Label lblQuantity;
    }
}