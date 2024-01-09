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
            _writeImage();
            _writeName();
        }
        private void _writeImage()
        {
            PictureBox pbProduct = new PictureBox();
            pbProduct.Location = new Point(28, 16);
            pbProduct.Size = new Size(80, 60);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap? img = CategoryPicturesEnumExtension.PictureConverter(_category.ID);
            pbProduct.Image = img;
            pbProduct.Enabled = false;
            Controls.Add(pbProduct);
        }

        private void _writeName()
        {
            Label lblName = new Label();
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Size = new Size(35, 25);
            lblName.Padding = new Padding(left:0, right:0, bottom: 4, top: 0);
            lblName.Dock = DockStyle.Fill;
            lblName.AutoSize = false;
            lblName.TextAlign = ContentAlignment.BottomCenter;
            lblName.Text = _category.Name;
            lblName.Enabled = false;
            Controls.Add(lblName);
        }


    }
}
