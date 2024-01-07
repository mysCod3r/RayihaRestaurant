namespace RayihaRestaurant.Core.Base
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            scrollPanel = new Panel();
            btnClose = new Button();
            lblWindowPanel = new Label();
            scrollPanel.SuspendLayout();
            SuspendLayout();
            // 
            // scrollPanel
            // 
            scrollPanel.Controls.Add(btnClose);
            scrollPanel.Controls.Add(lblWindowPanel);
            scrollPanel.Location = new Point(0, 0);
            scrollPanel.Name = "scrollPanel";
            scrollPanel.Size = new Size(800, 31);
            scrollPanel.TabIndex = 0;
            scrollPanel.TabStop = true;
            scrollPanel.MouseDown += OnMouseDown;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(772, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 31);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += _btnClose;
            // 
            // lblWindowPanel
            // 
            lblWindowPanel.AutoSize = true;
            lblWindowPanel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWindowPanel.Location = new Point(352, 5);
            lblWindowPanel.Name = "lblWindowPanel";
            lblWindowPanel.Size = new Size(167, 21);
            lblWindowPanel.TabIndex = 0;
            lblWindowPanel.Text = "Window Panel Name";
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scrollPanel);
            Name = "BaseForm";
            Text = "BaseForm";
            scrollPanel.ResumeLayout(false);
            scrollPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel scrollPanel;
        private Label lblWindowPanel;
        private Button btnClose;
    }
}