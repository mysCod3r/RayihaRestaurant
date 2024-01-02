using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("Orders")]
    public class Order
    {
        public int ID { get; init; }
        public Double? TotalPrice { get; init; }
        public int? UserID { get; init; }
        public User? User { get; init; }
        public int? TableID { get; init; }
        public Table? Table { get; init; }
        [Column("OrderStatus")]
        public string? OrderStatus { get; init; }
        public bool? IsPaid { get; init; }
        public List<OrderDetail> OrderDetails { get; init;} = new List<OrderDetail>();
    }
    enum OrderStatus
    {
        InProgress, //0
        Completed, //1
        Pending, //2
    }
}

