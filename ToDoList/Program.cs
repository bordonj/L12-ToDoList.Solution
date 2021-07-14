using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello");
      Console.WriteLine("Welcome to the To Do List!!!");
      Console.WriteLine("Would you like to add an Item, or view your List?! (add/view)");
      string userAnswer = Console.ReadLine();
      if (userAnswer == "add") 
      {
        AddItem();
      }
      else if (userAnswer == "view")
        { 
          ViewItems();
        }
    }
    static void AddItem()
    {
      Console.WriteLine("Please enter description of the Item you would like to add:");
      string newItem = Console.ReadLine();
      Item addedItem = new Item(newItem);
      Console.WriteLine($"{newItem} has been added to your list!!");
      Main();
    }

    static void ViewItems()
    {
      List<Item> result = Item.GetAll();
      result.ForEach((item) => Console.WriteLine(item.Description));
      Main();
    }
  }
}