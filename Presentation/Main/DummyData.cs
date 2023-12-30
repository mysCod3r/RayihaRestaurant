using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayihaRestaurant.Presentation.Main
{
    public class Category
    {
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int id { get; set; }
        public string name { get; set; }
    }
    public class Product
    {
        public Product(int id, string name, Category category, int price)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.price = price;
            this.Count = 0;
        }

        public int id { get; set; }
        public string name { get; set; }
        public Category category { get; set; }
        public int price { get; set; }
        public int Count { get; set; }

    }

    public class User
    {
      

        public User(int id, string name , string password , string type) 
        {
            this.id = id;
            this.name = name;   
            this.password = password;
            this.type = type;
        }

        public int id { get; set; } 
        public string name { get; set; }    
        public string password { get; set; }    
        public string type { get; set; }    
    }
        
    
    public static class DummyData
    {
            public static List<Category> categories = [new Category(1, "Et"), new Category(2, "Sebze")];
            public static List<Product> products = [
            new Product(1, "kebap", categories[0], 15),
            new Product(2, "lahmacun", categories[0], 10),
            new Product(3, "kıyma", categories[0], 12),
            new Product(3, "ıspanak", categories[1], 12)
        ];

        public static List<User> users = [new User(1, "f" , "1" , "waiter"), new User(2, "Gürkan", "123", "cashier")];
        public static int GetProductCountByCategory(string categoryName, IEnumerable<Product> productList)
        {
            return productList.Count(product => product.category.name == categoryName);
        }
    }
}
