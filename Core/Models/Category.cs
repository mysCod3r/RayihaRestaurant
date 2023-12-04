using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [Column("id")]
        public int Id { get; init; }
        [Column("name")]
        public string? Name { get; init; }
        public ICollection<Product> Products { get;} = new List<Product>();
    }
}
