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
      Console.WriteLine("Would you like to purchase?\nEnter 'B' for bread loafs \nEnter 'P' for pasteries");
    }
  }
}