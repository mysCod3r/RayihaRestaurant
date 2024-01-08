using RayihaRestaurant.Presentation.Waiter.Components;
using System.Windows.Forms;

namespace RayihaRestaurant.Presentation.Module.Views
{
    partial class TablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesForm));
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            button1.Location = new Point(808, 20);
            button1.Name = "button1";
            button1.Size = new Size(59, 47);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 85);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(851, 631);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // TablesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(875, 728);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            DoubleBuffered = true;
            MinimizeBox = false;
            Name = "TablesForm";
            Text = "Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}