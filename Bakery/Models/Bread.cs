namespace Bakery
{
  public class Bread
  {
    public string greetingCustomer()
    {
      return "Welcome to our bakery. Our prices are as follows \nBread: \nPastery: ";
    }

    public int breadPrice(int userQuantity)
    {
      int breadCost = 5;
      int userPrice = breadCost * userQuantity;
      int discountPrice = (userQuantity / 3) * breadCost;
      if(userQuantity >= 3)
      {
        userPrice = userPrice - discountPrice;
      }
      return userPrice;
    }
  }
}