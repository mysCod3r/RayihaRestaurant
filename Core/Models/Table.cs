using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("Tables")]
    public class Table
    {
        public int Id { get; init; }
        public int? Number { get; init; }
        public required bool Status { get; init; }
    }
}
