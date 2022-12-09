namespace Bakery
{
  public class Bread
  {
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Bread(int price, int quantity)
    {
      Quantity = 0;
      Price = 5;
    }

    public int breadPrice(int userQuantity)
    {
      int breadCost = 5;
      int userPrice = breadCost * userQuantity;
      int discountPrice = (userQuantity / 3) * breadCost;
      if (userQuantity >= 3)
      {
        userPrice = userPrice - discountPrice;
      }
      return userPrice;
    }

    public static string greetingCustomer = "Welcome to our bakery. Our prices are as follows \nBread: \nPastery: ";
  }
}