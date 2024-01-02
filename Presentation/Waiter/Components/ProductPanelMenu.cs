using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Extensions;
using RayihaRestaurant.Core.Models;

namespace RayihaRestaurant.Presentation.Waiter.Components
{
    internal class ProductPanelMenu : CustomPanel
    {
        private Product _product;
        private FlowLayoutPanel _flowLayoutCart;

        public ProductPanelMenu(Product product, FlowLayoutPanel flowLayoutCart)
        {
            _product = product;
            _flowLayoutCart = flowLayoutCart;
            BackColor = Color.White;
            ForeColor = Color.Turquoise;
            AutoSize = false;
            Location = new Point(3, 3);
            Size = new Size(280, 245);
            _init();
        }

        private void _init()
        {
            _writeName(_product);
            _writePrice(_product);
            _addToCart(_product);
            _productImage(_product);
        }

        private void _writeName(Product product)
        {
            Label lblFoodName = new Label();
            lblFoodName.AutoSize = true;
            lblFoodName.BackColor = Color.Transparent;
            lblFoodName.CausesValidation = false;
            lblFoodName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodName.ForeColor = Color.Black;
            lblFoodName.Location = new Point(18, 156);
            lblFoodName.Size = new Size(109, 25);
            lblFoodName.TabIndex = 0;
            lblFoodName.Text = product.Name;
            Controls.Add(lblFoodName);
        }

        private void _writePrice(Product product)
        {
            Label lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(0, 147, 44);
            lblPrice.Location = new Point(19, 181);
            lblPrice.Size = new Size(25, 19);
            lblPrice.TabIndex = 1;
            lblPrice.Text = product.Price.ToString();
            Controls.Add(lblPrice);
        }

        private void _addToCart(Product product)
        {
            AddToCartPanel addToCartPanel = new AddToCartPanel(product, _flowLayoutCart);
            Controls.Add(addToCartPanel);
        }

        private void _productImage(Product product)
        {
            PictureBox pbProduct = new PictureBox();
            pbProduct.Location = new Point(28, 23);
            pbProduct.Size = new Size(205, 131);
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            //string? image = ProductPictureExtension.PictureConverter(product.ID);
            //pbProduct.Image = Image.FromFile(image ?? "");
            //pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(pbProduct);
        }
    }
}
