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
      char userChoice;
      do
      {
        Console.WriteLine("What would you like to purchase?\nEnter 'B' for bread loafs \nEnter 'P' for pasteries\nEnter 'E' to exit");
        userChoice = char.Parse(Console.ReadLine().ToLower().Trim());
      } while (!createOrder(userChoice));
    }
    public static bool createOrder(char userChoice)
    {
      if (userChoice == 'b')
      {
        Console.WriteLine("\nHow many loafs of bread would you like to purchase?");
        string stringBreadQuantity = Console.ReadLine().Trim();
        int userBreadQuantity;
        if (!int.TryParse(stringBreadQuantity, out userBreadQuantity))
        {
          Console.WriteLine("\n-----------------------------------------");
          Console.WriteLine("*** Error: Please enter a valid number. ***");
          Console.WriteLine("-----------------------------------------");
          return false;
        }
        userBreadQuantity = int.Parse(stringBreadQuantity);
        Bread userBread = new Bread(userBreadQuantity);
        int totalBreadPrice = userBread.breadPrice(userBreadQuantity);
        if (userBreadQuantity <= 0)
        {
          Console.WriteLine("!!Error: Please enter a number greater than 0!!\n");
          return false;
        }
        else if (userBreadQuantity == 1)
        {
          Console.WriteLine($"\nThe total price for {userBreadQuantity} bread loaf is: ${totalBreadPrice}");
        }
        else
          Console.WriteLine($"\nThe total price for {userBreadQuantity} bread loafs is: ${totalBreadPrice}");
      }
      else if (userChoice == 'p')
      {
        Console.WriteLine("\nHow many pasteries would you like to purchase?");
        string stringPasteryQuantity = Console.ReadLine().Trim();
        int userPasteryQuantity;
        if (!int.TryParse(stringPasteryQuantity, out userPasteryQuantity))
        {
          Console.WriteLine("\n-----------------------------------------");
          Console.WriteLine("*** Error: Please enter a valid number. ***");
          Console.WriteLine("-----------------------------------------");
          return false;
        }
        userPasteryQuantity = int.Parse(stringPasteryQuantity);
        Pastery userPastery = new Pastery(userPasteryQuantity);
        int totalPasteryPrice = userPastery.pasteryPrice(userPasteryQuantity);
        if (userPasteryQuantity <= 0)
        {
          Console.WriteLine("!!Error: Please enter a number greater than 0!!\n");
          return false;
        }
        else if (userPasteryQuantity == 1)
        {
          Console.WriteLine($"\nThe total price for {userPasteryQuantity} pastery is: ${totalPasteryPrice}");
        }
        else
          Console.WriteLine($"\nThe total price for {userPasteryQuantity} pasteries is: ${totalPasteryPrice}");
      }
      else if (userChoice == 'e')
      {
        System.Environment.Exit(0);
      }
      else
      {
        Console.WriteLine("\n!!Please enter a valid input!!\n");
        return false;
      }
      return true;
    }

  }
}