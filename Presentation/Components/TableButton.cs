using RayihaRestaurant.Core.Base;
using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Extensions;

namespace RayihaRestaurant.Presentation.Components
{
    internal class TableButton : CustomButton
    {
        private int _tableId;
        private BaseForm _form;
        public TableButton(int tableId,bool isAvailable, BaseForm form)
        {
            _form = form;
            _tableId = tableId;
            Text = _tableId.ToString();
            Click += (_, __) => _openForm();
            Bitmap? img = PicturesEnumExtension.PictureConverter(isAvailable ? (int)Pictures.Restaurant_table_on : (int)Pictures.Restaurant_table_off);
            BackgroundImage = img;
            AutoSize = true;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Location = new Point(1711, 12);
            Size = new Size(150, 150);
            Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Padding = new Padding(5);
            TabIndex = 2;
            UseVisualStyleBackColor = false;
        }

        private void _openForm()
        {
            _form.SetTable(_tableId);
            _form.Open();
        }
    }
}
