using RayihaRestaurant.Core.Models;

namespace RayihaRestaurant.Presentation.Waiter.Components
{
    internal class KitchenOrderCardItem: CustomPanel
    {
        private Label _productName;
        private Label _quantity;
        private OrderDetail orderDetail;
        public KitchenOrderCardItem(OrderDetail orderDetail)
        {
            this.orderDetail = orderDetail;
            _productName = new Label();
            _quantity = new Label();
            BorderRadius = 50;
            Location = new Point(6, 57);
            Name = "cpOrderItem";
            Size = new Size(325, 45);
            TabIndex = 1;
            _init();
        }

        private void _init()
        {
            _writeProductName();
            _writeQuantity();
        }
        private void _writeProductName()
        {
            _productName.AutoSize = true;
            _productName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _productName.ForeColor = Color.Black;
            _productName.Location = new Point(38, 23);
            _productName.Size = new Size(125, 23);
            _productName.TabIndex = 0;
            _productName.Text = orderDetail?.Product?.Name;
            Controls.Add(_productName);
        }
        private void _writeQuantity()
        {
            _quantity.AutoSize = true;
            _quantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            _quantity.ForeColor = Color.Gray;
            _quantity.Location = new Point(250, 23);
            _quantity.Size = new Size(79, 23);
            _quantity.TabIndex = 1;
            _quantity.Text = orderDetail.Quantity?.ToString();
            Controls.Add(_quantity);
        }
    }
}
