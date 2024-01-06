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
            btnClose = new Button();
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
            flpOrders.Location = new Point(27, 60);
            flpOrders.Name = "flpOrders";
            flpOrders.Size = new Size(1115, 667);
            flpOrders.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1083, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(59, 47);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // KitchenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 853);
            Controls.Add(btnClose);
            Controls.Add(flpOrders);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KitchenForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "KitchenForm";
            FormClosing += KitchenForm_FormClosing;
            Load += KitchenForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flpOrders;
        private Button btnClose;
    }
}