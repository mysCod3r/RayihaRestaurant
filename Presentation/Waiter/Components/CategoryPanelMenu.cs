using RayihaRestaurant.Core.Extensions;
using RayihaRestaurant.Core.Models;
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
            _writeImage(_category);
        }
        private void _writeImage(Category category)
        {
            PictureBox pbProduct = new PictureBox();
            pbProduct.Location = new Point(28, 16);
            pbProduct.Size = new Size(80, 60);
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap? img = CategoryPicturesEnumExtension.PictureConverter(category.ID);
            pbProduct.Image = img;
            Controls.Add(pbProduct);
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
