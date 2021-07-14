using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    // add set; to line below
    public static string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};
    public static List<Item> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public Item(string description)
    {
      Description = description;
      _instances.Add(this); // New code.
    }
    // properties, methods, etc. will go here.

  }
}