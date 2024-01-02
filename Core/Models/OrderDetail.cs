using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int ID { get; init; }
        public int? OrderID { get; init; }
        public int? ProductID { get; init; }
        public Product? Product { get; set; }
        public int? Quantity { get; set; }
    }
}
