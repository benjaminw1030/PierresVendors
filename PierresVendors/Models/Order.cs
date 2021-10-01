using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public int Price { get; set; }
    public bool Priority { get; set; }
    public int Id { get; }

    public Order(string title, string description, string date, int price, bool priority)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
      Priority = priority;
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}