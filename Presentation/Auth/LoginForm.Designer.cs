namespace Rayiha.Presentation.Waiter
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(879, 37);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(832, 0);
            button1.Name = "button1";
            button1.Size = new Size(47, 37);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(btnLogin);
            panel2.Location = new Point(285, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 320);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(161, 26);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 9;
            label4.Text = "Login";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(63, 154);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(63, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(268, 27);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 6;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(63, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(268, 27);
            txtUsername.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(87, 73, 76);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(85, 235);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(879, 494);
            panel3.TabIndex = 5;
            // 
            // WaiterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(879, 531);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "WaiterForm";
            Text = "WaiterForm";
            FormClosed += WaiterForm_FormClosed;
            Load += WaiterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel3;
    }
}