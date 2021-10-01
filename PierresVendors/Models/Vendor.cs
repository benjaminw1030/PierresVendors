using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    //getters & setters here

    public Vendor(string categoryName)
    {
      //constructor goes here
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}