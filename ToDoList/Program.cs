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
          var list = Item.GetAll();
          list.ForEach(Console.WriteLine);
        }
    
      
    }
    static void AddItem()
    {
      Console.WriteLine("Please enter description of the Item you would like to add:");
      string newItem = Console.ReadLine();
      Item addedItem = new Item(newItem);
      Console.WriteLine($"{newItem} has been added to your list!! Would you like to add an item to your list or view your list? (add/view)");
      string userAnswer = Console.ReadLine();
      if (userAnswer == "add") 
      {
        AddItem();
      }
      else if (userAnswer == "view")
        { 
          // var list = Item.GetAll();
          // list.ForEach(Console.WriteLine(Item.Description));
          List<Item> result = Item.GetAll();
          // for (int i = 0; i < result.Count; i++)
          // {
          //   (Console.WriteLine(Item.Description));
          // }
          result.ForEach((item) => Console.WriteLine(Item.Description));
        }
    }

  }
}