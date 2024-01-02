namespace Rayiha.Presentation.Cashier
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            btnClose = new Button();
            customPanel1 = new RayihaRestaurant.Presentation.Waiter.Components.CustomPanel();
            cpOrderItem = new RayihaRestaurant.Presentation.Waiter.Components.CustomPanel();
            lblAmount = new Label();
            lblQuantity = new Label();
            lblProdcutName = new Label();
            btnCheckout = new RayihaRestaurant.Presentation.Waiter.Components.CustomButton();
            customPanel1.SuspendLayout();
            cpOrderItem.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1711, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(59, 47);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // customPanel1
            // 
            customPanel1.AutoScroll = true;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 50;
            customPanel1.Controls.Add(cpOrderItem);
            customPanel1.Location = new Point(544, 131);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(439, 633);
            customPanel1.TabIndex = 3;
            // 
            // cpOrderItem
            // 
            cpOrderItem.BorderRadius = 50;
            cpOrderItem.Controls.Add(lblAmount);
            cpOrderItem.Controls.Add(lblQuantity);
            cpOrderItem.Controls.Add(lblProdcutName);
            cpOrderItem.Location = new Point(34, 51);
            cpOrderItem.Name = "cpOrderItem";
            cpOrderItem.Size = new Size(377, 68);
            cpOrderItem.TabIndex = 0;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAmount.ForeColor = Color.Black;
            lblAmount.Location = new Point(267, 23);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(71, 23);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Gray;
            lblQuantity.Location = new Point(150, 23);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(79, 23);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity";
            // 
            // lblProdcutName
            // 
            lblProdcutName.AutoSize = true;
            lblProdcutName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdcutName.ForeColor = Color.FromArgb(0, 147, 44);
            lblProdcutName.Location = new Point(19, 23);
            lblProdcutName.Name = "lblProdcutName";
            lblProdcutName.Size = new Size(125, 23);
            lblProdcutName.TabIndex = 0;
            lblProdcutName.Text = "Prodcut Name";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(0, 147, 44);
            btnCheckout.BackgroundColor = Color.FromArgb(0, 147, 44);
            btnCheckout.BorderColor = Color.PaleVioletRed;
            btnCheckout.BorderRadius = 20;
            btnCheckout.BorderSize = 0;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(1033, 685);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(267, 79);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Hesabı Al";
            btnCheckout.TextColor = Color.White;
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 853);
            Controls.Add(btnCheckout);
            Controls.Add(customPanel1);
            Controls.Add(btnClose);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CashierForm";
            Text = "CashierForm";
            customPanel1.ResumeLayout(false);
            cpOrderItem.ResumeLayout(false);
            cpOrderItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private RayihaRestaurant.Presentation.Waiter.Components.CustomPanel customPanel1;
        private RayihaRestaurant.Presentation.Waiter.Components.CustomButton btnCheckout;
        private RayihaRestaurant.Presentation.Waiter.Components.CustomPanel cpOrderItem;
        private Label lblProdcutName;
        private Label lblQuantity;
        private Label lblAmount;
    }
}