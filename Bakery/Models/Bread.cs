namespace Bakery
{
  public class Bread
  {
    public int Price { get;}
    public int Quantity { get; set; }

    public Bread(int quantity)
    {
      Quantity = 0;
      Price = 5;
    }

    public int breadPrice(int userQuantity)
    {
      int userPrice = this.Price * userQuantity;
      int discountPrice = (userQuantity / 3) * this.Price;
      if (userQuantity >= 3)
      {
        userPrice = userPrice - discountPrice;
      }
      return userPrice;
    }

    public static string greetingCustomer = "Welcome to our bakery!\nOur prices: \nBread Loafs: $5 ea. \nPastery: $2 ea. ";
    public static string discountGreeting = "\nDiscounts are as follows:\nBread: Buy 2 get 1 free \nPastery: Buy 3 for $5";
  }
}