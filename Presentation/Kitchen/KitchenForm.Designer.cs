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
            button1.Location = new Point(1497, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(52, 35);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnClose_Click;
            // 
            // flpOrders
            // 
            flpOrders.AutoScroll = true;
            flpOrders.Location = new Point(24, 45);
            flpOrders.Margin = new Padding(3, 2, 3, 2);
            flpOrders.Name = "flpOrders";
            flpOrders.Size = new Size(Width-25, Height-50);
            flpOrders.TabIndex = 2;
            // 
            // KitchenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpOrders);
            Controls.Add(button1);
            Name = "KitchenForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "KitchenForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flpOrders;
    }
}