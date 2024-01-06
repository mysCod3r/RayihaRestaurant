using RayihaRestaurant.Core.Models;

namespace RayihaRestaurant.Presentation.Waiter.Components
{
    internal class KitchenOrderCard: CustomPanel
    {
        public int tableId { get; set; }
        private bool _isSecondClick;
        private Label _tableNo;
        private CustomButton _statusButton;
        private Order order;
        private FlowLayoutPanel _flpProducts;
        Label lblQuantity;
        Label lblProductName;
        CustomPanel customPanel;


        public KitchenOrderCard(Order order)
        {
            BackColor = Color.White;
            BorderRadius = 50;
            Location = new Point(3, 3);
            Size = new Size(338, 541);
            TabIndex = 0;
            this.order = order;
            _flpProducts = new FlowLayoutPanel();
            _tableNo = new Label();
            _statusButton = new CustomButton();
            lblQuantity = new Label();
            lblProductName = new Label();
            customPanel = new CustomPanel();
            _init();
        }

        private void _init()
        {
            _writeTableNo();
            _writeStatusButton();
            _writeFlpProducts();
            _writeTitles();
        }
        private void _writeTableNo()
        {
            _tableNo.AutoSize = true;
            _tableNo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _tableNo.Location = new Point(26, 10);
            _tableNo.Size = new Size(92, 13);
            _tableNo.TabIndex = 0;
            _tableNo.Text ="Masa no: " + order.TableID;
            Controls.Add(_tableNo);
        }

        
        private void _writeStatusButton()
        {
            _statusButton.BackColor = Color.Red;
            _statusButton.BackgroundColor = Color.Red;
            _statusButton.BorderColor = Color.PaleVioletRed;
            _statusButton.BorderRadius = 20;
            _statusButton.BorderSize = 0;
            _statusButton.FlatAppearance.BorderSize = 0;
            _statusButton.FlatStyle = FlatStyle.Flat;
            _statusButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _statusButton.ForeColor = Color.White;
            _statusButton.Location = new Point(71, 459);
            _statusButton.Name = "btnStatus";
            _statusButton.Size = new Size(198, 52);
            _statusButton.TabIndex = 1;
            _statusButton.Text = "Bekliyor...";
            _statusButton.TextColor = Color.White;
            _statusButton.UseVisualStyleBackColor = false;
            _statusButton.Click += btnStatus_Click;
            Controls.Add(_statusButton);
        }
        private void _writeFlpProducts()
        {
            _flpProducts.AutoScroll = true;
            _flpProducts.Location = new Point(0, 67);
            _flpProducts.Size = new Size(335, 386);
            _flpProducts.TabIndex = 3;
            _createAndAddProduct();
            Controls.Add(_flpProducts);
        }

        private void _writeTitles()
        {
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Gray;
            lblQuantity.Location = new Point(178, 23);
            lblQuantity.Size = new Size(79, 23);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity";

            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(0, 147, 44);
            lblProductName.Location = new Point(0, 23);
            lblProductName.Size = new Size(125, 23);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Prodcut Name";

            customPanel.BorderRadius = 50;
            customPanel.Controls.Add(lblQuantity);
            customPanel.Controls.Add(lblProductName);
            customPanel.Location = new Point(50, 23);
            customPanel.Size = new Size(332, 59);
            customPanel.TabIndex = 1;

            Controls.Add(customPanel);
        }
        private void _createAndAddProduct()
        {
            foreach (OrderDetail detail in order.OrderDetails)
            { 
                KitchenOrderCardItem kitchenOrderCardItem = new KitchenOrderCardItem(detail);
                _flpProducts.Controls.Add(kitchenOrderCardItem);
            }
        }

        private void btnStatus_Click(object? sender, EventArgs e)
        {
            if (_isSecondClick)
            {
                _statusButton.BackColor = Color.Green;
                _statusButton.Text = "Hazır";
                _statusButton.ForeColor = Color.White;
                _statusButton.Click -= btnStatus_Click;
            }
            else
            {
                _statusButton.BackColor = Color.Yellow;
                _statusButton.Text = "Hazırlanıyor";
                _statusButton.ForeColor = Color.Black;
            }
            _isSecondClick = !_isSecondClick;
        }

    }
}
