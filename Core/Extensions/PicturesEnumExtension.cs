using RayihaRestaurant.Core.Enums;

namespace RayihaRestaurant.Core.Extensions
{
    public static class PicturesEnumExtension
    {
    
        private static readonly Dictionary<Pictures, Bitmap> turMappings = new Dictionary<Pictures, Bitmap>
        {
            {Pictures.Dinner, Properties.Resources.ic_adana_kebap },
            {Pictures.Minus, Properties.Resources.ic_minus },

        };

        public static Bitmap? PictureConverter(this int? value)
        {
            if (value == null) return null;
            Pictures pic = (Pictures)value;
            return turMappings.TryGetValue(pic, out Bitmap? picWithSpaces) ? picWithSpaces : null;
        }
    }
}

