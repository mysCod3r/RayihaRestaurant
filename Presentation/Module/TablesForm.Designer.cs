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
            flpTables = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flpTables.Location = new Point(10, 44);
            flpTables.Name = "flowLayoutPanel1";
            flpTables.Size = new Size(Width-8, 450);
            flpTables.TabIndex = 1;
            flpTables.AutoScroll = true;
            // 
            // TablesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ControlBox = false;
            Controls.Add(flpTables);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "TablesForm";
            Text = "Table";
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpTables;
    }
}