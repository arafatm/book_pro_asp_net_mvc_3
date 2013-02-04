using System;
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

  class Program
  {
    static void Main(string[] args)
    {

      // create a new Product object
      Product myProduct = new Product();

      // set the property value
      myProduct.Name = "Kayak";

      // get the property
      string productName = myProduct.Name;
      Console.WriteLine("Product name: {0}", productName);
    }
  }
}
