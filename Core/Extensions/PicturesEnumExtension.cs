using RayihaRestaurant.Core.Enums;

namespace RayihaRestaurant.Core.Extensions
{
    public static class PicturesEnumExtension
    {
    
        private static readonly Dictionary<Pictures, Bitmap> turMappings = new Dictionary<Pictures, Bitmap>
        {
            {Pictures.Close, Properties.Resources.ic_close },
            {Pictures.Dinner, Properties.Resources.ic_dinner_black },
            {Pictures.Logout, Properties.Resources.ic_logout },
            {Pictures.Logout_white, Properties.Resources.ic_logout_white },
            {Pictures.Minus, Properties.Resources.ic_minus },
            {Pictures.Password, Properties.Resources.ic_password },
            {Pictures.Plus, Properties.Resources.ic_plus },
            {Pictures.Table, Properties.Resources.ic_table },
            {Pictures.Table_white, Properties.Resources.ic_table_white },
            {Pictures.User, Properties.Resources.ic_user },
            {Pictures.Backgorund, Properties.Resources.ic_background },
            {Pictures.Restaurant_table_on, Properties.Resources.ic_restaurant_table_on },
            {Pictures.Restaurant_table_off, Properties.Resources.ic_restaurant_table_off }
        };

        public static Bitmap? PictureConverter(this int? value)
        {
            if (value == null) return null;
            Pictures pic = (Pictures)value;
            return turMappings.TryGetValue(pic, out Bitmap? picWithSpaces) ? picWithSpaces : null;
        }
    }
}

