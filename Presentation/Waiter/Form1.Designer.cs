﻿
namespace RayihaRestaurant.Presentation.Waiter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            customButtonMenu2 = new Components.CustomButton();
            customButtonMenu1 = new Components.CustomButton();
            panel2 = new Panel();
            customButtonMenu3 = new Components.CustomButton();
            panel3 = new Panel();
            panel4 = new Panel();
            lblTotalAmount = new Label();
            flowLayoutPanelCart = new FlowLayoutPanel();
            button1 = new Button();
            label6 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(222, 640);
            panel1.TabIndex = 0;
            panel1.MouseDown += OnMouseDown;
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
            customButtonMenu1.Click += customButtonMenu1_Click;
            customButtonMenu1.MouseEnter += customButtonMenu1_MouseEnter;
            customButtonMenu1.MouseLeave += customButtonMenu1_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(customButtonMenu3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(222, 579);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1337, 61);
            panel2.TabIndex = 0;
            // 
            // customButtonMenu3
            // 
            customButtonMenu3.BackColor = Color.MediumSlateBlue;
            customButtonMenu3.BackgroundColor = Color.MediumSlateBlue;
            customButtonMenu3.BorderColor = Color.PaleVioletRed;
            customButtonMenu3.BorderRadius = 20;
            customButtonMenu3.BorderSize = 0;
            customButtonMenu3.FlatAppearance.BorderSize = 0;
            customButtonMenu3.FlatStyle = FlatStyle.Flat;
            customButtonMenu3.ForeColor = Color.White;
            customButtonMenu3.Location = new Point(980, 14);
            customButtonMenu3.Margin = new Padding(3, 2, 3, 2);
            customButtonMenu3.Name = "customButtonMenu3";
            customButtonMenu3.Size = new Size(164, 38);
            customButtonMenu3.TabIndex = 0;
            customButtonMenu3.Text = "customButtonMenu3";
            customButtonMenu3.TextColor = Color.White;
            customButtonMenu3.UseVisualStyleBackColor = false;
            customButtonMenu3.Click += customButtonMenu3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(flowLayoutPanelCart);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1108, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 579);
            panel3.TabIndex = 1;
            panel3.MouseDown += OnMouseDown;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblTotalAmount);
            panel4.Location = new Point(0, 457);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(451, 122);
            panel4.TabIndex = 8;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.BackColor = Color.Transparent;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(32, 56);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(121, 21);
            lblTotalAmount.TabIndex = 0;
            lblTotalAmount.Text = "Amount Total: ";
            // 
            // flowLayoutPanelCart
            // 
            flowLayoutPanelCart.AutoScroll = true;
            flowLayoutPanelCart.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelCart.Location = new Point(0, 89);
            flowLayoutPanelCart.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelCart.Name = "flowLayoutPanelCart";
            flowLayoutPanelCart.Padding = new Padding(9, 0, 0, 0);
            flowLayoutPanelCart.Size = new Size(451, 370);
            flowLayoutPanelCart.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(383, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(47, 35);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 50);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 0;
            label6.Text = "Table No";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(222, 0);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(35, 15, 35, 15);
            flowLayoutPanel1.Size = new Size(886, 117);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(222, 117);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(886, 313);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(222, 428);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(886, 152);
            panel5.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1559, 640);
            ControlBox = false;
            Controls.Add(panel5);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            MouseDown += OnMouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Components.CustomButton customButtonMenu1;
        private Components.CustomButton customButtonMenu2;
        private PictureBox pictureBox1;
        private Label lblCount;
        private Components.CustomButton cbmPlus;
        private Label label5;
        private Components.CustomButton cbmMinus;
        private Label label4;
        private Label label3;
        private Label label6;
        private PictureBox pictureBox4;
        private Button button1;
        private Label label2;
        private Label lblCategoriName;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanelCart;
        private Panel panel4;
        private Label lblTotalAmount;
        private Components.CustomButton customButtonMenu3;
        private Panel panel5;
    }
}