using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Presentation.Components;

namespace RayihaRestaurant.Presentation.Cashier.Components
{
    internal class CashierOrderCartItem : CustomPanel
    {
        private Label _lblProdcutName;
        private Label _lblAmount;
        private Label _lblQuantity;
        private OrderDetail orderDetail;
        public CashierOrderCartItem(OrderDetail orderDetail)
        {
            this.orderDetail = orderDetail;
            BorderRadius = 50;
            Padding = new Padding(0, 0, 50, 0);
            Location = new Point(34, 51);
            Size = new Size(370, 50);
            TabIndex = 0;
            _lblProdcutName = new Label();
            _lblAmount = new Label();
            _lblQuantity = new Label();
            _init();

        }

        private void _init()
        {
            _writeName();
            _writeAmount();
            _writeQuantity();
        }

        private void _writeName()
        {
            _lblProdcutName.AutoSize = true;
            _lblProdcutName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lblProdcutName.ForeColor = Color.Black;
            _lblProdcutName.Location = new Point(19, 23);
            _lblProdcutName.Size = new Size(130, 10);
            _lblProdcutName.TabIndex = 0;
            _lblProdcutName.Margin = new Padding(0, 0, 0, 10);
            _lblProdcutName.Text = orderDetail.Product?.Name;
            Controls.Add(_lblProdcutName);
        }

        private void _writeAmount()
        {
            _lblAmount.AutoSize = true;
            _lblAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            _lblAmount.ForeColor = Color.Black;
            _lblAmount.Location = new Point(310, 23);
            _lblAmount.Size = new Size(50, 4);
            _lblAmount.TabIndex = 2;
            double itemTotal = (orderDetail.Quantity ?? 0) * (orderDetail?.Product?.Price ?? 0);
            _lblAmount.Text = itemTotal.ToString("0.00");
            Controls.Add(_lblAmount);
        }

        private void _writeQuantity()
        {
            _lblQuantity.AutoSize = true;
            _lblQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            _lblQuantity.ForeColor = Color.Black;
            _lblQuantity.Location = new Point(240, 23);
            _lblQuantity.Size = new Size(79, 23);
            _lblQuantity.TabIndex = 1;
            _lblQuantity.Text = orderDetail.Quantity.ToString();
            Controls.Add(_lblQuantity);
        }


    }
}
