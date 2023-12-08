using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{

    [Table("Orders")]
    public class Order
    {
        public int ID { get; init; }
        public Double? TotalPrice { get; init; }
        public int? UserID { get; init; }
        public User? User { get; init; }
        public int? ProductId { get; init; }
        public Product? Product { get; init; }
        public int? TableId { get; init; }
        public Table? Table { get; init; }
        public string? Status { get; init; }
        public bool? IsPaid { get; init; }
        public virtual List<Product>? Products { get; set; }
    }
}
