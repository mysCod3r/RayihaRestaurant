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
            btnCheckout = new RayihaRestaurant.Presentation.Waiter.Components.CustomButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            lblAmount = new Label();
            lblQuantity = new Label();
            lblProductName = new Label();
            customPanel1 = new RayihaRestaurant.Presentation.Waiter.Components.CustomPanel();
            panel2 = new Panel();
            lblTotalAmount = new Label();
            panel1.SuspendLayout();
            customPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            btnCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(574, 672);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(199, 54);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Hesabı Al";
            btnCheckout.TextColor = Color.White;
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 85);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 0, 10, 0);
            flowLayoutPanel1.Size = new Size(398, 512);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblAmount);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(lblProductName);
            panel1.Location = new Point(3, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 74);
            panel1.TabIndex = 0;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(310, 23);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(75, 23);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Gray;
            lblQuantity.Location = new Point(210, 23);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 23);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(0, 147, 44);
            lblProductName.Location = new Point(19, 23);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(125, 23);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 50;
            customPanel1.Controls.Add(panel2);
            customPanel1.Controls.Add(flowLayoutPanel1);
            customPanel1.Controls.Add(panel1);
            customPanel1.Location = new Point(155, 62);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(401, 664);
            customPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotalAmount);
            panel2.Location = new Point(3, 594);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 67);
            panel2.TabIndex = 6;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(171, 25);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(119, 23);
            lblTotalAmount.TabIndex = 0;
            lblTotalAmount.Text = "Total Amount";
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            //ClientSize = new Size(828, 853);
            Controls.Add(customPanel1);
            Controls.Add(btnCheckout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CashierForm";
            Text = "CashierForm";
            MouseDown += OnMouseDown;
            Controls.SetChildIndex(btnCheckout, 0);
            Controls.SetChildIndex(customPanel1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RayihaRestaurant.Presentation.Waiter.Components.CustomButton btnCheckout;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lblProductName;
        private Label lblAmount;
        private Label lblQuantity;
        private RayihaRestaurant.Presentation.Waiter.Components.CustomPanel customPanel1;
        private Panel panel2;
        private Label lblTotalAmount;
    }
}