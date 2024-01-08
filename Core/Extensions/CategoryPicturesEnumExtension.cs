using RayihaRestaurant.Core.Enums;

namespace RayihaRestaurant.Core.Extensions
{
    public static class CategoryPicturesEnumExtension
    {

        private static readonly Dictionary<CategoryPictures, Bitmap> turMappings = new Dictionary<CategoryPictures, Bitmap>
        {
            {CategoryPictures.Corbalar, Properties.Resources.ic_mercimek_corbasi },
            {CategoryPictures.Tostlar, Properties.Resources.ic_karisik_tost },
            {CategoryPictures.KahvaltiCesitleri, Properties.Resources.ic_rayiha_special_kahvalti_tabagi },
            {CategoryPictures.Salatalar, Properties.Resources.ic_coban_salata },
            {CategoryPictures.BurgerCesitleri, Properties.Resources.ic_hamburger },
            {CategoryPictures.AraSicaklar, Properties.Resources.ic_pacanga_boregi },
            {CategoryPictures.Specials, Properties.Resources.ic_rayiha_special },
            {CategoryPictures.Tatlilar, Properties.Resources.ic_kunefe },
            {CategoryPictures.Izgaralar, Properties.Resources.ic_ozel_izgara_kofte },
            {CategoryPictures.DurumCesitleri, Properties.Resources.ic_urfa_durum },
            {CategoryPictures.KaradenizPidesi, Properties.Resources.ic_karisik_pide },
            {CategoryPictures.Icecekler, Properties.Resources.ic_cappy },
            
        };

        public static Bitmap? PictureConverter(this int? value)
        {
            if (value == null) return null;
            CategoryPictures pic = (CategoryPictures)value;
            return turMappings.TryGetValue(pic, out Bitmap? picWithSpaces) ? picWithSpaces : null;
        }
    }
}

