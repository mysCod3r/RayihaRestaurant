using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("Users")]
    public class User
    {
        public int ID { get; init; }
        public string? Name { get; init; }
        public string? Password { get; init; }
        public string? Type { get; init; }  
    }
}
