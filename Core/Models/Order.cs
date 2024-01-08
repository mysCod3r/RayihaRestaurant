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
        public OrderStatus? OrderStatus { get; set; }
        public bool? IsPaid { get; set; }
        public List<OrderDetail> OrderDetails { get; init;} = new List<OrderDetail>();
    }

    public enum OrderStatus
    {
        Pending,
        InProgress,
        Completed,
    }
}

