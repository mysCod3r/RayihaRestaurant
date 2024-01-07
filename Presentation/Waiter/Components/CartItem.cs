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
            Size = new Size(467, 86);
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
        }

        void _writeProductName()
        {
            _lblProductName.AutoSize = true;
            _lblProductName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lblProductName.ForeColor = Color.Black;
            _lblProductName.Location = new Point(127, 20);
            _lblProductName.Name = orderItem.Product?.Name;
            _lblProductName.Size = new Size(109, 25);
            _lblProductName.TabIndex = 0;
            _lblProductName.Text = orderItem.Product?.Name;
        }

        void _writePrice()
        {
            _lblPrice.AutoSize = true;
            _lblPrice.BackColor = Color.Transparent;
            _lblPrice.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            _lblPrice.ForeColor = Color.FromArgb(0, 147, 44);
            _lblPrice.Location = new Point(130, 45);
            _lblPrice.Size = new Size(43, 19);
            _lblPrice.TabIndex = 6;
            _lblPrice.Text = orderItem.Product?.Price.ToString();
        }

        void _writeQuantity()
        {
            _lblQuantity.AutoSize = true;
            _lblQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lblQuantity.ForeColor = Color.Gray;
            _lblQuantity.Location = new Point(175, 42);
            _lblQuantity.Size = new Size(20, 23);
            _lblQuantity.TabIndex = 5;
            _lblQuantity.Text = orderItem.Quantity.ToString();
        }

        void _writeTotal()
        {
            _lblTotal.AutoSize = true;
            _lblTotal.BackColor = Color.Transparent;
            _lblTotal.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            _lblTotal.ForeColor = Color.FromArgb(0, 147, 44);
            _lblTotal.Location = new Point(385, 49);
            _lblTotal.Size = new Size(42, 19);
            _lblTotal.TabIndex = 2;
            double? total = orderItem.Product?.Price * orderItem.Quantity;
            _lblTotal.Text = total.ToString();
        }

        public void refreshTexts()
        {
            _lblQuantity.Text = orderItem.Quantity.ToString();
            double? total = orderItem.Product?.Price * orderItem.Quantity;
            _lblTotal.Text = total.ToString();
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
