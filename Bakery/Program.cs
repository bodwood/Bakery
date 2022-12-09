using System;
using Bakery;

namespace Bakery.Program
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine(Bread.greetingCustomer + "\n" + Bread.discountGreeting);
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("What would you like to purchase?\nEnter 'B' for bread loafs \nEnter 'P' for pasteries\nEnter 'E' to exit");

      char userChoice = char.Parse(Console.ReadLine().ToLower().Trim());
      createOrder(userChoice);
    }
    public static void createOrder(char userChoice)
    {
   
      if (userChoice == 'b')
      {
        Console.WriteLine("\nHow many loafs of bread would you like to purchase?");
        
      }
      else if (userChoice == 'p')
      {
        Console.WriteLine("\nHow many pasteries would you like to purchase?");
      }
      else if (userChoice == 'e')
      {
        System.Environment.Exit(0);
      }
      else{
        Console.WriteLine("\n!!Please enter a valid input:!!\n'B' for bread loafs\n'P' for pasteries\n'E' to exit application");
        userChoice = char.Parse(Console.ReadLine().ToLower().Trim());
        createOrder(userChoice);
      }

    }

  }
}