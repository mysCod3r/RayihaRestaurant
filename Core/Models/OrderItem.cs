namespace RayihaRestaurant.Core.Models
{
    public class OrderItem
    {
        public OrderItem(Product product)
        {
            Product = product;
            Quantity = 1;
        }

        public Product Product { get; init; }
        public int Quantity { get; set; }
    }
}
