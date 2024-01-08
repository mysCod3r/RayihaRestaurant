using System.ComponentModel.DataAnnotations.Schema;

namespace RayihaRestaurant.Core.Models
{
    [Table("Categories")]
    public class Category
    {
        public int ID { get; init; }
        public string? Name { get; init; }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Category otherCategory = (Category)obj;
            return ID == otherCategory.ID;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
