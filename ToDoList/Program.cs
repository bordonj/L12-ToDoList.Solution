using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    private static int selectedOption = 0;

    public static void Main()
    {
      Console.Clear();
      Console.WriteLine("Welcome to the To Do List!!!");
      // Console.WriteLine("Would you like to add an Item, or view your List?! (add/view)");

      if (selectedOption == 0) {
        WriteLine("- add", ConsoleColor.White, ConsoleColor.Black);
      } else {
        Console.WriteLine("- add");
      }

      if (selectedOption == 1) {
        WriteLine("- view", ConsoleColor.White, ConsoleColor.Black);
      } else {
        Console.WriteLine("- view");
      }

      while (true) {
        ConsoleKeyInfo pressedKey = Console.ReadKey(true);

        if (pressedKey.Key == ConsoleKey.UpArrow) {
          selectedOption--;
          Main();
        }

        if (pressedKey.Key == ConsoleKey.DownArrow) {
          selectedOption++;
          Main();
        }

        if (pressedKey.Key == ConsoleKey.Enter) {
          if (selectedOption == 0) {
            AddItem();
          } else if (selectedOption == 1) {
            ViewItems();
          } else {
            Main();
          }
        }
      }
    }

    static void WriteLine (string text, ConsoleColor background, ConsoleColor foreground)
    {
        Console.BackgroundColor = background;
        Console.ForegroundColor = foreground;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    static void AddItem()
    {
      Console.WriteLine("Please enter description of the Item you would like to add:");
      string newItem = Console.ReadLine();
      Item addedItem = new Item(newItem);
      Console.WriteLine($"{newItem} has been added to your list!!");

      WaitForAnyKeypress();
      Main();
    }

    static void ViewItems()
    {
      List<Item> result = Item.GetAll();
      result.ForEach((item) => Console.WriteLine(item.Description));

      WaitForAnyKeypress();
      Main();
    }

    static void WaitForAnyKeypress()
    {
      Console.WriteLine("-- press any key to go back to main menu");
      Console.ReadKey();
    }
  }
}