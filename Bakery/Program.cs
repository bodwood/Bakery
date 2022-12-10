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
        int userBreadQuantity = int.Parse(Console.ReadLine().Trim());
        Bread userBread = new Bread(userBreadQuantity);
        int totalBreadPrice = userBread.breadPrice(userBreadQuantity);
        if (userBreadQuantity <= 0)
        {
          Console.WriteLine("!!Error: Please enter a number greater than 0!!\n");
          createOrder('b');
        }
        else if (userBreadQuantity == 1)
        {
          Console.WriteLine($"\nThe total price for {userBreadQuantity} bread loaf is: ${totalBreadPrice}");
        }
        else
          Console.WriteLine($"\nThe total price for {userBreadQuantity} bread loafs is: ${totalBreadPrice}");
      }

      //----------------------------------------
      else if (userChoice == 'p')
      {
        Console.WriteLine("\nHow many pasteries would you like to purchase?");
        int userPasteryQuantity = int.Parse(Console.ReadLine().Trim());
        Pastery userPastery = new Pastery(userPasteryQuantity);
        int totalPasteryPrice = userPastery.pasteryPrice(userPasteryQuantity);
        if (userPasteryQuantity <= 0)
        {
          Console.WriteLine("!!Error: Please enter a number greater than 0!!\n");
          createOrder('p');
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
        Console.WriteLine("\n!!Please enter a valid input!!\n'B' for bread loafs\n'P' for pasteries\n'E' to exit application");
        userChoice = char.Parse(Console.ReadLine().ToLower().Trim());
        createOrder(userChoice);
      }

    }

  }
}