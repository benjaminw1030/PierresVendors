using System.Collections.Generic;

namespace Template.Models
{
  public class Model
  {
    private static List<Model> _instances = new List<Model> {};
    //getters & setters here

    public Model(string categoryName)
    {
      //constructor goes here
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}