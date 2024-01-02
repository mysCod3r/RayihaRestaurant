using RayihaRestaurant.Core.Enums;

namespace RayihaRestaurant.Core.Extensions
{
    public static class PicturesEnumExtension
    {
    
        private static readonly Dictionary<Pictures, string> turMappings = new Dictionary<Pictures, string>
        {
            { Pictures.Close, @"..\..\..\Pictures\Close.png" },
            { Pictures.Dinner, @"..\..\..\Pictures\Dinner_black.png" },
            { Pictures.Logout, @"..\..\..\Pictures\Logout.png" },
            { Pictures.Logout_white, @"..\..\..\Pictures\Logout_white.png" },
            { Pictures.Minus, @"..\..\..\Pictures\Minus.png" },
            { Pictures.Password, @"..\..\..\Pictures\Password.png" },
            { Pictures.Plus, @"..\..\..\Pictures\Plus.png" },
            { Pictures.Table, @"..\..\..\Pictures\Table.png" },
            { Pictures.Table_white, @"..\..\..\Pictures\Table_white.png" },
            { Pictures.User, @"..\..\..\Pictures\User.png" },
            { Pictures.wp9443719, @"..\..\..\Pictures\wp9443719.png" },
        };

        public static string? PictureConverter(this int? value)
        {
            if (value == null) return null;
            Pictures pic = (Pictures)value;
            return turMappings.TryGetValue(pic, out string? picWithSpaces) ? picWithSpaces : value.ToString();
        }
    }
}

