using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Extensions;
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Presentation.Components;

namespace RayihaRestaurant.Presentation.Waiter.Components
{
    internal class CartItem : CustomPanel
    {
        private Label _lblProductName;
        private Label _lblPrice;
        private Label _lblQuantity;
        private Label _lblTotal;
        public OrderItem orderItem;
        public CartItem(OrderItem orderItem) 
        {
            this.orderItem = orderItem;
            _lblProductName = new Label();
            _lblPrice = new Label();
            _lblQuantity = new Label();
            _lblTotal = new Label();
            BackColor = Color.Transparent;
            BorderRadius = 50;
            Controls.Add(_lblPrice);
            Controls.Add(_lblQuantity);
            Controls.Add(_lblTotal);
            Controls.Add(_lblProductName);
            ForeColor = Color.White;
            Location = new Point(3, 3);
            Size = new Size(300, 64);
            TabIndex = 1;
            BorderStyle = BorderStyle.FixedSingle;
            Padding = new Padding(10, 0, 0, 0);
            _init();
        }


        void _init()
        {
            _writeProductName();
            _writePrice();
            _writeQuantity();
            _writeTotal();
            _writeImage();

        }
        private void _writeImage()
        {
            PictureBox pbProduct = new PictureBox();
            pbProduct.Location = new Point(10, 14);
            pbProduct.Size = new Size(50, 40);
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap? img = PicturesEnumExtension.PictureConverter(orderItem.Product.ID);
            pbProduct.Image = img;
            Controls.Add(pbProduct);
        }

        void _writeProductName()
        {
            _lblProductName.AutoSize = true;
            _lblProductName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lblProductName.ForeColor = Color.Black;
            _lblProductName.Location = new Point(62, 10);
            _lblProductName.Name = orderItem.Product?.Name;
            _lblProductName.Size = new Size(64, 25);
            _lblProductName.TabIndex = 0;
            _lblProductName.Text = orderItem.Product?.Name;
        }

        void _writePrice()
        {
            _lblPrice.AutoSize = true;
            _lblPrice.BackColor = Color.Transparent;
            _lblPrice.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            _lblPrice.ForeColor = Color.FromArgb(0, 147, 44);
            _lblPrice.Location = new Point(62, 45);
            _lblPrice.Size = new Size(8, 19);
            _lblPrice.TabIndex = 6;
            _lblPrice.Text = orderItem.Product?.Price?.ToString("0.00");
        }

        void _writeQuantity()
        {
            _lblQuantity.AutoSize = true;
            _lblQuantity.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lblQuantity.ForeColor = Color.Gray;
            _lblQuantity.Location = new Point(_lblPrice.Location.X + 32, 45);
            _lblQuantity.Size = new Size(16, 23);
            _lblQuantity.TabIndex = 5;
            _lblQuantity.Text = " x " + orderItem.Quantity.ToString();
        }

        void _writeTotal()
        {
            _lblTotal.AutoSize = true;
            _lblTotal.BackColor = Color.Transparent;
            _lblTotal.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            _lblTotal.ForeColor = Color.FromArgb(0, 147, 44);
            _lblTotal.Location = new Point(Width - 64, 50);
            _lblTotal.Size = new Size(32, 19);
            _lblTotal.TabIndex = 2;
            double? total = orderItem.Product?.Price * orderItem.Quantity;
            _lblTotal.Text = total.ToString();
        }

        public void refreshTexts()
        {
            _lblQuantity.Text = " x " + orderItem.Quantity.ToString();
            double? total = orderItem.Product?.Price * orderItem.Quantity;
            _lblTotal.Text = total?.ToString("0.00");
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            CartItem other = (CartItem)obj;

            return orderItem.Product == other.orderItem.Product;
        }

        public override int GetHashCode()
        {
            return orderItem.GetHashCode();
        }
    }
}
