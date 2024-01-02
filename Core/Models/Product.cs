using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("Products")]
    public class Product
    {
        public int ID { get; init; }
        public string? Name { get; init; }
        public Double? Price { get; init; }
        public int? CategoryID { get; init; }
        public Category? Category { get; init; }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Product otherProduct = (Product)obj;
            return ID == otherProduct.ID;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
   
}
