using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("Categories")]
    public class Category
    {
        public int ID { get; init; }
        public string? Name { get; init; }
    }
}
