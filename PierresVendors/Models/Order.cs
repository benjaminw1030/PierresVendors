using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    //getters & setters here

    public Order(string categoryName)
    {
      //constructor goes here
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}