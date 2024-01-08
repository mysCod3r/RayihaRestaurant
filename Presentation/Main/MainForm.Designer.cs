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
            label1 = new Label();
            btnWelcome = new Presentation.Components.CustomButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 158);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 1;
            label1.Text = "Rayiha Restaurant";
            // 
            // btnWelcome
            // 
            btnWelcome.BackColor = Color.FromArgb(0, 147, 44);
            btnWelcome.BackgroundColor = Color.FromArgb(0, 147, 44);
            btnWelcome.BorderColor = Color.PaleVioletRed;
            btnWelcome.BorderRadius = 19;
            btnWelcome.BorderSize = 0;
            btnWelcome.FlatAppearance.BorderSize = 0;
            btnWelcome.FlatStyle = FlatStyle.Flat;
            btnWelcome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWelcome.ForeColor = Color.White;
            btnWelcome.Location = new Point(173, 201);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(336, 102);
            btnWelcome.TabIndex = 2;
            btnWelcome.Text = "Hoş geldiniz";
            btnWelcome.TextColor = Color.White;
            btnWelcome.UseVisualStyleBackColor = false;
            btnWelcome.Click += btnWelcome_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(btnWelcome);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Main";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Presentation.Components.CustomButton btnWelcome;
    }
}
