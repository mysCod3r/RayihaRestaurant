using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayihaRestaurant.Core.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int ID { get; init; }
        public int? OrderID { get; init; }
        public int? ProductID { get; init; }
        public Product? Product { get; init; }
        public int? Quantity { get; init; }
    }
}
