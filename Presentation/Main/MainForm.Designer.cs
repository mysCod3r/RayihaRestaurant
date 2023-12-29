namespace RayihaRestaurant
{
    partial class MainForm
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
            btnWaiter = new Button();
            btnCashier = new Button();
            btnKitchen = new Button();
            SuspendLayout();
            // 
            // btnWaiter
            // 
            btnWaiter.Font = new Font("Segoe UI", 24F);
            btnWaiter.Location = new Point(12, 95);
            btnWaiter.Name = "btnWaiter";
            btnWaiter.Size = new Size(222, 197);
            btnWaiter.TabIndex = 0;
            btnWaiter.Text = "Waiter";
            btnWaiter.UseVisualStyleBackColor = true;
            btnWaiter.Click += btnWaiter_Click;
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Segoe UI", 24F);
            btnCashier.Location = new Point(240, 95);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(222, 197);
            btnCashier.TabIndex = 1;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // btnKitchen
            // 
            btnKitchen.Font = new Font("Segoe UI", 24F);
            btnKitchen.Location = new Point(468, 95);
            btnKitchen.Name = "btnKitchen";
            btnKitchen.Size = new Size(222, 197);
            btnKitchen.TabIndex = 2;
            btnKitchen.Text = "Kitchen";
            btnKitchen.UseVisualStyleBackColor = true;
            btnKitchen.Click += btnKitchen_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(btnKitchen);
            Controls.Add(btnCashier);
            Controls.Add(btnWaiter);
            Name = "MainForm";
            Text = "Main";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnWaiter;
        private Button btnCashier;
        private Button btnKitchen;
    }
}
