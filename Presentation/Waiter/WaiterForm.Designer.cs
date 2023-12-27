namespace RayihaRestaurant.Presentation.Waiter
{
    partial class WaiterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterForm));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button3 = new Button();
            listView1 = new ListView();
            productName = new ColumnHeader();
            price = new ColumnHeader();
            label2 = new Label();
            button4 = new Button();
            amount = new ColumnHeader();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 7, 92);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 37);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 8);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 1;
            label1.Text = "Rayiha Restaurant";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1045, 0);
            button1.Name = "button1";
            button1.Size = new Size(47, 37);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Location = new Point(12, 107);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 472);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(247, 61);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Location = new Point(268, 107);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(467, 472);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(464, 33);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { productName, price, amount });
            listView1.Location = new Point(741, 107);
            listView1.Name = "listView1";
            listView1.Size = new Size(339, 381);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // productName
            // 
            productName.Text = "Product Name";
            productName.Width = 200;
            // 
            // price
            // 
            price.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(763, 517);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Tutar: ";
            // 
            // button4
            // 
            button4.Location = new Point(921, 502);
            button4.Name = "button4";
            button4.Size = new Size(136, 50);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // amount
            // 
            amount.Text = "Amount";
            amount.Width = 80;
            // 
            // WaiterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 591);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WaiterForm";
            Text = "WaiterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private ListView listView1;
        private ColumnHeader productName;
        private Button button2;
        private ColumnHeader price;
        private Button button3;
        private Label label2;
        private Button button4;
        private ColumnHeader amount;
    }
}