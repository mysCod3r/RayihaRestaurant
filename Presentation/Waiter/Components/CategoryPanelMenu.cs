using RayihaRestaurant.Core.Models;
using System.Drawing.Drawing2D;

namespace RayihaRestaurant.Presentation.Waiter.Components
{
    internal class CategoryPanelMenu : CustomPanel
    {
        
        private Category _category;
        public Category category => _category;
        public CategoryPanelMenu(Category category, EventHandler onClick)
        {
            AutoSize = true;
            _category = category;
            Click += onClick;
            Size = new Size(109, 110);
            BackColor = Color.White;
            ForeColor = Color.White;
            _init();
        }

        private void _init()
        {
            _writeName(_category);
        }

        private void _writeName(Category category)
        {
            Label lblName = new Label();
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(18, 60);
            lblName.Size = new Size(35, 25);
            lblName.TabIndex = 1;
            lblName.Text = category.Name;
            Controls.Add(lblName);
        }


    }
}
