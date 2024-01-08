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
            pnlContent = new Panel();
            picPassword = new PictureBox();
            picUsername = new PictureBox();
            lblLogin = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).BeginInit();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.Transparent;
            pnlContent.Controls.Add(picPassword);
            pnlContent.Controls.Add(picUsername);
            pnlContent.Controls.Add(lblLogin);
            pnlContent.Controls.Add(lblPassword);
            pnlContent.Controls.Add(txtPassword);
            pnlContent.Controls.Add(lblUsername);
            pnlContent.Controls.Add(txtUsername);
            pnlContent.Controls.Add(btnLogin);
            pnlContent.Location = new Point(285, 124);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(369, 320);
            pnlContent.TabIndex = 4;
            // 
            // picPassword
            // 
            picPassword.Image = (Image)resources.GetObject("picPassword.Image");
            picPassword.Location = new Point(24, 177);
            picPassword.Name = "picPassword";
            picPassword.Size = new Size(33, 27);
            picPassword.SizeMode = PictureBoxSizeMode.CenterImage;
            picPassword.TabIndex = 11;
            picPassword.TabStop = false;
            // 
            // picUsername
            // 
            picUsername.Image = (Image)resources.GetObject("picUsername.Image");
            picUsername.Location = new Point(24, 120);
            picUsername.Name = "picUsername";
            picUsername.Size = new Size(33, 27);
            picUsername.SizeMode = PictureBoxSizeMode.CenterImage;
            picUsername.TabIndex = 10;
            picUsername.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(161, 26);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(53, 21);
            lblLogin.TabIndex = 9;
            lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(63, 154);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(59, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(63, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(268, 23);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(63, 97);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(64, 15);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(63, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(268, 23);
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
            // btnClose
            // 
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(87, 73, 76);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(655, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 50);
            btnClose.TabIndex = 12;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(879, 531);
            Controls.Add(btnClose);
            Controls.Add(pnlContent);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "WaiterForm";
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsername).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlContent;
        private Label lblLogin;
        private Label lblUsername;
        private Label lblPassword;
        private PictureBox picPassword;
        private PictureBox picUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Button btnClose;
    }
}