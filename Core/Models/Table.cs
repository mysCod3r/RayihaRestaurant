using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RayihaRestaurant.Core.Models    
{
    public class Table
    {

        [Key]
        [Column("id")]
        public required int Id { get; init; }
        [Column("number")]
        public required int Number { get; init; }
        [Column("order_id")]
        public required Order Order { get; init; }
        [Column("table_status")]
        public required bool Status { get; init; }
        public ICollection<Order> Orders { get; } = new List<Order>();

    }
}
