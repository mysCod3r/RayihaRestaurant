using RayihaRestaurant.Core.Enums;

namespace RayihaRestaurant.Core.Extensions
{
    public static class ProductPicturesEnumExtension
    {

        private static readonly Dictionary<ProductPictures, Bitmap> turMappings = new Dictionary<ProductPictures, Bitmap>
        {
            {ProductPictures.EzogelinCorbasi, Properties.Resources.ic_ezogelin_corbasi },
            {ProductPictures.MercimekCorbasi, Properties.Resources.ic_mercimek_corbasi },
            {ProductPictures.GununCorbasi, Properties.Resources.ic_gunun_corbasi },
            {ProductPictures.KasarliTost, Properties.Resources.ic_kasarli_tost },
            {ProductPictures.SucukluTost, Properties.Resources.ic_sucuklu_tost },
            {ProductPictures.KarisikTost, Properties.Resources.ic_karisik_tost },
            {ProductPictures.KavurmaliKasarliTost, Properties.Resources.ic_kavurmalı_kasarlı_tost },
            {ProductPictures.KlasikKavhvaltiTabagi, Properties.Resources.ic_klasik_kahvaltı_tabagi },
            {ProductPictures.RayihaSpecialKahvalti, Properties.Resources.ic_rayiha_special_kahvalti_tabagi },
            {ProductPictures.RayihaSerpmeKahvalti, Properties.Resources.ic_serpme_kahvalti },
            {ProductPictures.CobanSalata, Properties.Resources.ic_coban_salata },
            {ProductPictures.PilicSalata, Properties.Resources.ic_pilic_salata },
            {ProductPictures.TonBalikliSalata, Properties.Resources.ic_tonbalıklı_salata },
            {ProductPictures.MevsimSalata, Properties.Resources.ic_mevsim_salata },
            {ProductPictures.CitirSalata, Properties.Resources.ic_citir_salata },
            {ProductPictures.Hamburger, Properties.Resources.ic_hamburger },
            {ProductPictures.Cheesburger, Properties.Resources.ic_cheeseburger },
            {ProductPictures.TonBalikliSandwich, Properties.Resources.ic_ton_balıklı_sandwich },
            {ProductPictures.SigaraBoregi, Properties.Resources.ic_sigara_boregi },
            {ProductPictures.PacangaBoregi, Properties.Resources.ic_pacanga_boregi },
            {ProductPictures.ElmaDilimPatates, Properties.Resources.ic_elma_dilim_patates },
            {ProductPictures.PatatesKizartmasi, Properties.Resources.ic_patates_kizartmasi },
            {ProductPictures.IcliKofte, Properties.Resources.ic_icli_kofte },
            {ProductPictures.SoyaSosluTavuk, Properties.Resources.ic_soya_soslu_tavuk },
            {ProductPictures.MantarSosluTavuk, Properties.Resources.ic_mantar_soslu_tavuk },
            {ProductPictures.PilicSinitzel, Properties.Resources.ic_pilic_sinitzel },
            {ProductPictures.KoriSosluTavuk, Properties.Resources.ic_kori_soslu_tavuk },
            {ProductPictures.TavukSote, Properties.Resources.ic_tavuk_sote },
            {ProductPictures.UrfaKavurmasi, Properties.Resources.ic_urfa_kavurma },
            {ProductPictures.FirinSutlac, Properties.Resources.ic_fırın_sutlac },
            {ProductPictures.KabakTatlisi, Properties.Resources.ic_kabak_tatlisi },
            {ProductPictures.DondurmaTatli, Properties.Resources.ic_dondurma_tatlisi },
            {ProductPictures.Kunefe, Properties.Resources.ic_kunefe },
            {ProductPictures.AdanaKebap, Properties.Resources.ic_adana_kebap },
            {ProductPictures.UrfaKebap, Properties.Resources.ic_urfa_kebap },
            {ProductPictures.OzelIzgaraKofte, Properties.Resources.ic_ozel_izgara_kofte },
            {ProductPictures.KasarliKofte, Properties.Resources.ic_kasarli_kofte },
            {ProductPictures.KuzuSis, Properties.Resources.ic_kuzu_sis },
            {ProductPictures.TavukSis, Properties.Resources.ic_tavuk_sis },
            {ProductPictures.TavukKanat, Properties.Resources.ic_tavuk_kanat },
            {ProductPictures.TavukPirzola, Properties.Resources.ic_tavuk_pirzola},
            {ProductPictures.SucukIzgara, Properties.Resources.ic_sucuk_izgara },
            {ProductPictures.KarisikKebap, Properties.Resources.ic_karisik_kebap },
            {ProductPictures.RayihaSpecial, Properties.Resources.ic_rayiha_special },
            {ProductPictures.Antrikot, Properties.Resources.ic_antrikot },
            {ProductPictures.KuzuPirzola, Properties.Resources.ic_kuzu_pirzola },
            {ProductPictures.IskenderKebap, Properties.Resources.ic_iskender_kebap },
            {ProductPictures.CopSis, Properties.Resources.ic_cop_sis },
            {ProductPictures.KuzuCiger, Properties.Resources.ic_kuzu_ciger },
            {ProductPictures.Lahmacun, Properties.Resources.ic_lahmacun },
            {ProductPictures.OzelLahmacun, Properties.Resources.ic_ozel_lahmacun },
            {ProductPictures.AdanaDurum, Properties.Resources.ic_adana_durum },
            {ProductPictures.UrfaDurum, Properties.Resources.ic_urfa_durum },
            {ProductPictures.TavukSisDurum, Properties.Resources.ic_tavuk_sis_durum },
            {ProductPictures.CopSisDurum, Properties.Resources.ic_cop_sis_durum },
            {ProductPictures.KasarliPide, Properties.Resources.ic_kasarlı_pide },
            {ProductPictures.SucukluPide, Properties.Resources.ic_sucuklu_pide },
            {ProductPictures.KiymaliPide, Properties.Resources.ic_kiymali_pide },
            {ProductPictures.KusbasiliPide, Properties.Resources.ic_kusbasili_pide },
            {ProductPictures.KavurmaliPide, Properties.Resources.ic_kavurmali_pide },
            {ProductPictures.PastirmaliPide, Properties.Resources.ic_pastirmali_pide },
            {ProductPictures.KarisikPide, Properties.Resources.ic_karisik_pide },
            {ProductPictures.Cola, Properties.Resources.ic_cola },
            {ProductPictures.Fanta, Properties.Resources.ic_fanta },
            {ProductPictures.Sprite, Properties.Resources.ic_sprite },
            {ProductPictures.Cappy, Properties.Resources.ic_cappy },
            {ProductPictures.Ayran, Properties.Resources.ic_ayran },
            {ProductPictures.MeyveliSoda, Properties.Resources.ic_meyveli_soda },
            {ProductPictures.Soda, Properties.Resources.ic_soda },
            {ProductPictures.Su, Properties.Resources.ic_su },
            {ProductPictures.Cay, Properties.Resources.ic_cay },
            {ProductPictures.FincanCay, Properties.Resources.ic_fincan_cay },
            {ProductPictures.MeyveCaylari, Properties.Resources.ic_meyve_caylari },
            {ProductPictures.TurkKahvesi, Properties.Resources.ic_turk_kahvesi },
            {ProductPictures.Nescafe, Properties.Resources.ic_nescafe },
            {ProductPictures.Salep, Properties.Resources.ic_salep },
            {ProductPictures.Cappuccino, Properties.Resources.ic_cappuccino },
            {ProductPictures.Espresso, Properties.Resources.ic_espresso },
            {ProductPictures.SicakCikolata, Properties.Resources.ic_sicak_cikolata },

        };

        public static Bitmap? PictureConverter(this int? value)
        {
            if (value == null) return null;
            ProductPictures pic = (ProductPictures)value;
            return turMappings.TryGetValue(pic, out Bitmap? picWithSpaces) ? picWithSpaces : null;
        }
    }
}

