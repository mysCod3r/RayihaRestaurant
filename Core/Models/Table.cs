using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("Tables")]
    public class Table
    {
        public int ID { get; init; }
        public string? Number { get; init; }
        [Column("TableStatus")]
        public required bool TableStatus { get; init; }
    }
}
