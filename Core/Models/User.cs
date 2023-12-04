using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RayihaRestaurant.Core.Models    
{
    public class User
    {
        [Key]
        [Column("id")]
        public required int Id { get; init; }
        [Column("name")]
        public required string Username { get; init; }
        [Column("password")]
        public required string Password { get; init; }
        [Column("type")]
        public required string Type { get; init; }
        public ICollection<Order> Orders { get; } = new List<Order>();
    }
}
