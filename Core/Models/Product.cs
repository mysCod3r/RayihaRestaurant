using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; init; }
        public string? Name { get; init; }
        public Double? Price { get; init; }
        public int? CategoryId { get; init; }
        public Category? Category { get; init; }
    }
}
