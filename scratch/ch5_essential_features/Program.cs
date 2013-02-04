using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ch5_essential_features
{
  public class Product
  {
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { set; get; }

  }

  public class ShoppingCart : IEnumerable<Product>
  {
    public List<Product> Products { get; set; }

    public IEnumerator<Product> GetEnumerator()
    {
      return Products.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };

      var results = from product in products
                    orderby product.Price ascending
                    select new {
                      product.Name,
                      product.Price
                    };

      foreach (var p in results)
      {
        Console.WriteLine("Item: {0}, Cost: {1}", p.Name, p.Price);
      }
    }

  }
}
