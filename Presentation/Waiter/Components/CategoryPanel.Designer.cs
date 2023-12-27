namespace RayihaRestaurant.Presentation.Waiter.Components
{
    partial class CategoryPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryPanel));
            customPanelMenu2 = new CustomPanelMenu();
            label2 = new Label();
            lblCategoriName = new Label();
            pictureBox2 = new PictureBox();
            customPanelMenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // customPanelMenu2
            // 
            customPanelMenu2.BackColor = Color.Transparent;
            customPanelMenu2.BorderRadius = 50;
            customPanelMenu2.Controls.Add(label2);
            customPanelMenu2.Controls.Add(lblCategoriName);
            customPanelMenu2.Controls.Add(pictureBox2);
            customPanelMenu2.ForeColor = Color.White;
            customPanelMenu2.Location = new Point(0, 0);
            customPanelMenu2.Name = "customPanelMenu2";
            customPanelMenu2.Size = new Size(116, 119);
            customPanelMenu2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 83);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Items";
            // 
            // lblCategoriName
            // 
            lblCategoriName.AutoSize = true;
            lblCategoriName.BackColor = Color.Transparent;
            lblCategoriName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoriName.ForeColor = Color.Black;
            lblCategoriName.Location = new Point(18, 60);
            lblCategoriName.Name = "lblCategoriName";
            lblCategoriName.Size = new Size(35, 25);
            lblCategoriName.TabIndex = 1;
            lblCategoriName.Text = "All";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // CategoryPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customPanelMenu2);
            Name = "CategoryPanel";
            Size = new Size(116, 119);
            customPanelMenu2.ResumeLayout(false);
            customPanelMenu2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomPanelMenu customPanelMenu2;
        private Label label2;
        private Label lblCategoriName;
        private PictureBox pictureBox2;
    }
}
