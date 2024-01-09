using RayihaRestaurant.Core.Enums;

namespace RayihaRestaurant.Core.Extensions
{
    public static class OrderStatusExtension
    {
        public static Color GetColor(this OrderStatus? orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.Pending: return Color.Red;
                case OrderStatus.InProgress: return Color.Yellow;
                case OrderStatus.Completed: return Color.Green;
                default: return Color.Black;
            }
        }

        public static string GetText(this OrderStatus? orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.Pending: return "Bekliyor";
                case OrderStatus.InProgress: return "Hazırlanıyor";
                case OrderStatus.Completed: return "Hazır";
                default: return "!";
            }
        }



    }

}
