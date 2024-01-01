using RayihaRestaurant.Presentation.Components;

namespace RayihaRestaurant.Presentation.Waiter
{
    partial class Waiter
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
            customListBox2 = new CustomListBox();
            SuspendLayout();
            // 
            // customListBox2
            // 
            customListBox2.FormattingEnabled = true;
            customListBox2.ItemHeight = 15;
            customListBox2.Location = new Point(298, 155);
            customListBox2.Name = "customListBox2";
            customListBox2.Size = new Size(281, 244);
            customListBox2.TabIndex = 2;
            // 
            // Waiter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 638);
            Controls.Add(customListBox2);
            Name = "Waiter";
            Text = "Waiter";
            ResumeLayout(false);
        }

        #endregion
        private CustomListBox customListBox2;
    }
}