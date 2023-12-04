using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RayihaRestaurant.Core.Models
{
    public class Product
    {
        [Key]
        [Column("id")]
        public required int Id { get; init; }
        [Column("name")]
        public required string Name { get; init; }
        [Column("price")]
        public required Double Price { get; init; }
        [Column("category_id")]
        public required int CategoryId { get; init; }
        public Category Category { get; init; } = null!;
        [Column("order_id")]
        public required int OrderId { get; init; }
        public Order Order { get; init; } = null!;
    }
}
