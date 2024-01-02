using RayihaRestaurant.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayihaRestaurant.Core.Extensions
{
    public static class ProductPictureExtension
    {
        private static readonly Dictionary<ProductPicture, string> turMappings = new Dictionary<ProductPicture, string>
        {
            { ProductPicture.Ezogelin_Corba, @"..\..\..\Images\ic_ezogelin_corbasi.png" },
            { ProductPicture.Mercimek_Corba, @"..\..\..\Images\ic_mercimek_corbasi.png" },
            { ProductPicture.Gunun_Corba, @"..\..\..\Images\ic_gunun_corbasi.png" },
            { ProductPicture.Kasarli_Tost, @"..\..\..\Images\ic_kasarli_tost.png" },
            { ProductPicture.Sucuklu_Tost, @"..\..\..\Images\ic_sucuklutost.png" },
            { ProductPicture.Karisik_Tost, @"..\..\..\Images\ic_karısık_tost.png" },
            { ProductPicture.Kavurmalı_Kasarli_Tost, @"..\..\..\Images\ic_kavurmalı_kasarlı_tost.png" },
            { ProductPicture.Klasik_Kahvalti_Tabagi, @"..\..\..\Images\ic_klasik_kahvaltı_tabagi.png" },
            { ProductPicture.Rayiha_Special_Kahvalti_Tabagi, @"..\..\..\Images\ic_rayiha_special_kahvalti_tabagi.png" },
            { ProductPicture.Rayiha_Serpme_Kahvalti, @"..\..\..\Images\ic_rayiha_serpme_kahvaltı.png" },
            { ProductPicture.Coban_Salata, @"..\..\..\Images\ic_coban_salata.png" },
            { ProductPicture.Pilic_Salata, @"..\..\..\Images\ic_pilic_salata.png" },
            { ProductPicture.Ton_Balikli_Salata, @"..\..\..\Images\ic_tonbalıklı_salata.png" },
            { ProductPicture.Mevsim_Salata, @"..\..\..\Images\ic_mevsim_salata.png" },
            { ProductPicture.Citir_Salata, @"..\..\..\Images\ic_citir_salata.png" },
            { ProductPicture.Hamburger, @"..\..\..\Images\ic_hamburger.png" },
            { ProductPicture.Cheeseburger, @"..\..\..\Images\ic_cheeseburger.png" },
            { ProductPicture.Ton_Balikli_Sandwich, @"..\..\..\Images\ic_ton_balıklı_sandwich.png" },
            { ProductPicture.Sigara_Boregi, @"..\..\..\Images\ic_sigara_boregi.png" },
            { ProductPicture.Pacanga_Boregi, @"..\..\..\Images\ic_pacanga_boregi.png" },
            { ProductPicture.Elma_Dilim_Patates, @"..\..\..\Images\ic_elma_dilim_patates.png" },
            { ProductPicture.Patates_Kizartmasi, @"..\..\..\Images\ic_patates_kizartmasi.png" },
            { ProductPicture.Icli_Kofte, @"..\..\..\Images\ic_icli_kofte.png" },
            { ProductPicture.Soya_Soslu_Tavuk, @"..\..\..\Images\ic_soya_soslu_tavuk.png" },
            { ProductPicture.Mantar_Soslu_Tavuk, @"..\..\..\Images\ic_mantar_soslu_tavuk.png" },
            { ProductPicture.Pilic_Sinitzel, @"..\..\..\Images\ic_pilic_sinitzel.png" },
            { ProductPicture.Kori_Soslu_Tavuk, @"..\..\..\Images\ic_kori_soslu_tavuk.png" },
            { ProductPicture.Tavuk_Sote, @"..\..\..\Images\ic_tavuk_sote.png" },
            { ProductPicture.Urfa_Kavurmasi, @"..\..\..\Images\ic_urfa_kavurma.png" },
            { ProductPicture.Firin_Sutlac, @"..\..\..\Images\ic_fırın_sutlac.png" },
            { ProductPicture.Kabak_Tatlisi, @"..\..\..\Images\ic_kabak_tatlisi.png" },
            { ProductPicture.Dondurma_Tatli, @"..\..\..\Images\ic_dondurma_tatlisi.png" },
            { ProductPicture.Kunefe, @"..\..\..\Images\ic_kunefe.png" },
            { ProductPicture.Adana_Kebap, @"..\..\..\Images\ic_adana_kebap.png" },
            { ProductPicture.Urfa_Kebap, @"..\..\..\Images\ic_urfa_kebap.png" },
            { ProductPicture.Ozel_Izgara_Kofte, @"..\..\..\Images\ic_ozel_izgara_kofte.png" },
            { ProductPicture.Kasarli_Kofte, @"..\..\..\Images\ic_kasarli_kofte.png" },
            { ProductPicture.Kuzu_Sis, @"..\..\..\Images\ic_kuzu_sis.png" },
            { ProductPicture.Tavuk_Sis, @"..\..\..\Images\ic_tavuk_sis.png" },
            { ProductPicture.Tavuk_Kanat, @"..\..\..\Images\ic_tavuk_kanat.png" },
            { ProductPicture.Tavuk_Pirzola, @"..\..\..\Images\ic_tavuk_pirzola.png" },
            { ProductPicture.Sucuk_Izgara, @"..\..\..\Images\ic_sucuk_izgara.png" },
            { ProductPicture.Karisik_Kebap, @"..\..\..\Images\ic_karisik_kebap.png" },
            { ProductPicture.Rayiha_Special, @"..\..\..\Images\ic_rayiha_special.png" },
            { ProductPicture.Antrikot, @"..\..\..\Images\ic_antrikot.png" },
            { ProductPicture.Kuzu_Pirzola, @"..\..\..\Images\ic_kuzu_pirzola.png" },
            { ProductPicture.Iskender_Kebap, @"..\..\..\Images\ic_iskender_kebap.png" },
            { ProductPicture.Cop_Sis, @"..\..\..\Images\ic_cop_sis.png" },
            { ProductPicture.Kuzu_Ciger, @"..\..\..\Images\ic_kuzu_ciger.png" },
            { ProductPicture.Lahmacun, @"..\..\..\Images\ic_lahmacun.png" },
            { ProductPicture.Ozel_Lahmacun, @"..\..\..\Images\ic_ozel_lahmacun.png" },
            { ProductPicture.Adana_Durum, @"..\..\..\Images\ic_adana_durum.png" },
            { ProductPicture.Urfa_Durum, @"..\..\..\Images\ic_urfa_durum.png" },
            { ProductPicture.Tavuk_Sis_Durum, @"..\..\..\Images\ic_tavuk_sis_durum.png" },
            { ProductPicture.Cop_Sis_Durum, @"..\..\..\Images\ic_cop_sis.png" },
            { ProductPicture.Kasarli_Pide, @"..\..\..\Images\ic_kasarlı_pide.png" },
            { ProductPicture.Sucuklu_Pide, @"..\..\..\Images\ic_sucuklu_pide.png" },
            { ProductPicture.Kıymali_Pide, @"..\..\..\Images\ic_kiymali_pide.png" },
            { ProductPicture.Kusbasi_Pide, @"..\..\..\Images\ic_kusbasili_pide.png" },
            { ProductPicture.Kavurmalı_Pide, @"..\..\..\Images\ic_kavurmali_pide.png" },
            { ProductPicture.Pastirmali_Pide, @"..\..\..\Images\ic_pastirmali_pide.png" },
            { ProductPicture.Karisik_Pide, @"..\..\..\Images\ic_karisik_pide.png" },
            { ProductPicture.Cola, @"..\..\..\Images\ic_cola.png" },
            { ProductPicture.Fanta, @"..\..\..\Images\ic_fanta.png" },
            { ProductPicture.Sprite, @"..\..\..\Images\ic_sprite.png" },
            { ProductPicture.Cappy, @"..\..\..\Images\ic_cappy.png" },
            { ProductPicture.Ayran, @"..\..\..\Images\ic_ayran.png" },
            { ProductPicture.Meyveli_Soda, @"..\..\..\Images\ic_meyveli_soda.png" },
            { ProductPicture.Soda, @"..\..\..\Images\ic_soda.png" },
            { ProductPicture.Su, @"..\..\..\Images\ic_su.png" },
            { ProductPicture.Cay, @"..\..\..\Images\ic_cay.png" },
            { ProductPicture.Fincan_Cay, @"..\..\..\Images\ic_fincan_cay.png" },
            { ProductPicture.Meyve_Caylari, @"..\..\..\Images\ic_meyve_caylari.png" },
            { ProductPicture.Turk_Kahvesi, @"..\..\..\Images\ic_turk_kahvesi.png" },
            { ProductPicture.Nescafe, @"..\..\..\Images\ic_nescafe.png" },
            { ProductPicture.Salep, @"..\..\..\Images\ic_salep.png" },
            { ProductPicture.Cappuccino, @"..\..\..\Images\ic_cappuccino.png" },
            { ProductPicture.Espresso, @"..\..\..\Images\ic_espresso.png" },
            { ProductPicture.Sicak_Cikolata, @"..\..\..\Images\ic_sicak_cikolata.png" },
        };

        public static string? PictureConverter(this int? value)
        {
            if (value == null) return null;
            ProductPicture pic = (ProductPicture)value;
            return turMappings.TryGetValue(pic, out string? picWithSpaces) ? picWithSpaces : value.ToString();
        }
    }
}
