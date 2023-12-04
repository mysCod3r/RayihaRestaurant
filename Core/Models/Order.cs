using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{

    [Table("Orders")]
    public class Order
    {
        [Key]
        [Column("id")]
        public required int Id { get; init; }
        [Column("total_price")]
        public required Double TotalPrice { get; init; }
        [Column("user_id")]
        public required int UserId { get; init; }
        public User User { get; init; } = null!;
        [Column("table_id")]
        public required int TableId { get; init; }
        public Table Table { get; init; } = null!;
        [Column("order_status")]
        public required string Status { get; init; }
        [Column("is_paid")]
        public required bool IsPaid { get; init; }
        public ICollection<Product> Products { get; } = new List<Product>();
    }
}
