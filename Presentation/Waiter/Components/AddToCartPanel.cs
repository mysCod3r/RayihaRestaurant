﻿using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Extensions;
using RayihaRestaurant.Core.Models;
using RayihaRestaurant.Presentation.Components;

namespace RayihaRestaurant.Presentation.Waiter.Components
{
    internal class AddToCartPanel : CustomPanel
    {
        private Product _product;
        private int _quantity = 0;

        private Label _lblAddToDish;
        private Label _lblCount;
        private CustomButton _plusButton;
        private CustomButton _minusButton;
        private FlowLayoutPanel _flowLayoutCart;

        public AddToCartPanel(Product product, FlowLayoutPanel flowLayoutCart)
        {
            _lblAddToDish = new Label();
            _lblCount = new Label();
            _plusButton = new CustomButton();
            _minusButton = new CustomButton();
            _product = product;
            _flowLayoutCart = flowLayoutCart;
            BackColor = Color.FromArgb(204, 233, 213);
            BorderRadius = 18;
            ForeColor = Color.White;
            Location = new Point(12, 200);
            Size = new Size(258, 33);
            TabIndex = 2;
            Click += (_, __) => _increase();
            _init();
        }

        void _init()
        {
            _labelAddToDish();
            _labelCount();
            _plusIcon();
            _minusIcon();
        }
        
        void _labelAddToDish()
        {
            _lblAddToDish.AutoSize = true;
            _lblAddToDish.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            _lblAddToDish.ForeColor = Color.Black;
            _lblAddToDish.Location = new Point(90, 8);
            _lblAddToDish.Size = new Size(87, 19);
            _lblAddToDish.TabIndex = 0;
            _lblAddToDish.Text = "Sepete Ekle";
            _lblAddToDish.TextAlign = ContentAlignment.MiddleRight;
            _lblAddToDish.Click += (_, __) => _increase();
            Controls.Add(_lblAddToDish);
        }

        void _labelCount()
        {
            _lblCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lblCount.ForeColor = Color.Black;
            _lblCount.Location = new Point(112, 5);
            _lblCount.Text = _quantity.ToString();
            _lblCount.Size = new Size(40, 23);
            _lblCount.TabIndex = 4;
            _lblCount.Hide();
            Controls.Add(_lblCount);
        }

        void _plusIcon()
        {
            _plusButton.BackColor = Color.Transparent;
            _plusButton.BackgroundColor = Color.Transparent;
            Bitmap? imgPlus = PicturesEnumExtension.PictureConverter((int)Pictures.Plus);
            _plusButton.BackgroundImage = imgPlus;
            _plusButton.BackgroundImageLayout = ImageLayout.Center;
            _plusButton.BorderColor = Color.PaleVioletRed;
            _plusButton.BorderRadius = 20;
            _plusButton.BorderSize = 0;
            _plusButton.FlatAppearance.BorderSize = 0;
            _plusButton.FlatStyle = FlatStyle.Flat;
            _plusButton.ForeColor = Color.White;
            _plusButton.Location = new Point(190, 1);
            _plusButton.Size = new Size(30, 30);
            _plusButton.TabIndex = 3;
            _plusButton.TextColor = Color.White;
            _plusButton.UseVisualStyleBackColor = false;
            _plusButton.Click += (_, __) => _increase();
            _plusButton.Hide();
            Controls.Add(_plusButton);
        }

        void _minusIcon()
        {
            _minusButton.BackColor = Color.Transparent;
            _minusButton.BackgroundColor = Color.Transparent;
            Bitmap? imgMinus = PicturesEnumExtension.PictureConverter((int)Pictures.Minus);
            _minusButton.BackgroundImage = imgMinus;
            _minusButton.BackgroundImageLayout = ImageLayout.Center;
            _minusButton.BorderColor = Color.PaleVioletRed;
            _minusButton.BorderRadius = 20;
            _minusButton.BorderSize = 0;
            _minusButton.FlatAppearance.BorderSize = 0;
            _minusButton.FlatStyle = FlatStyle.Flat;
            _minusButton.ForeColor = Color.White;
            _minusButton.Location = new Point(30, 1);
            _minusButton.Size = new Size(30, 30);
            _minusButton.TabIndex = 3;
            _minusButton.TextColor = Color.White;
            _minusButton.UseVisualStyleBackColor = false;
            _minusButton.Click += (_, __) => _decrease();
            _minusButton.Hide();
            Controls.Add(_minusButton);
        }

        private void _increase()
        {
            _quantity += 1;
            _productAdded();
            _lblCount.Text = _quantity.ToString();
            if (_quantity > 1)
            {
                return;
            }
            else
            {
                _itemsControl();
            }
        }

        private void _decrease()
        {
            _quantity -= 1;
            _productRemoved();
            _lblCount.Text = _quantity.ToString();
            if (_quantity != 0)
            {
                return;
            }
            else
            {
                _itemsControl();
            }
        }

        private void _itemsControl()
        {
            if (_quantity == 0)
            {
                _minusButton.Hide();
                _plusButton.Hide();
                _lblCount.Hide();
                _lblAddToDish.Show();
            }
            else
            {
                _minusButton.Show();
                _plusButton.Show();
                _lblCount.Show();
                _lblAddToDish.Hide();
            }
        }

        private void _productAdded()
        {
            OrderItem order = new OrderItem(_product);
            CartItem item = new CartItem(order);

            if (_flowLayoutCart.Controls.Contains(item))
            {
                int index = _flowLayoutCart.Controls.GetChildIndex(item);
                CartItem x = (CartItem)_flowLayoutCart.Controls[index];
                x.orderItem.Quantity += 1;
                x.refreshTexts();
            }
            else
            {
                _flowLayoutCart.Controls.Add(item);
            }
        }

        private void _productRemoved()
        {
            OrderItem order = new OrderItem(_product);
            CartItem item = new CartItem(order);

            int index = _flowLayoutCart.Controls.GetChildIndex(item);
            CartItem x = (CartItem)_flowLayoutCart.Controls[index];

            if (x.orderItem.Quantity > 1)
            {
                x.orderItem.Quantity -= 1;
            }
            else
            {
                _flowLayoutCart.Controls.Remove(x);
            }
            x.refreshTexts();
        }
    }
}
