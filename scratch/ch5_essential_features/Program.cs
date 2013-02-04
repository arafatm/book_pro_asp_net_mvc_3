using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ch5_essential_features
{
  public class Product
  {
    private string name;

    public string Name
    {
      get { return name; }
      set { name = value; }
    }
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
