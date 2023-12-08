using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; init; }
        public string? Username { get; init; }
        public string? Password { get; init; }
        public string? Type { get; init; }
    }
}
