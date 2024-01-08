﻿using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Presentation.Components;

namespace RayihaRestaurant.Presentation.Waiter.Components
{
    internal class CategoryPanelMenu : CustomPanel
    {
        
        private Category _category;
        public Category category => _category;
        public CategoryPanelMenu(Category category, EventHandler onClick)
        {
            _category = category;
            Click += onClick;
            Size = new Size(140, 110);
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
            lblName.Location = new Point(5, 80);
            lblName.Size = new Size(35, 25);
            lblName.TabIndex = 1;
            lblName.Text = category.Name;
            Controls.Add(lblName);
        }


    }
}
