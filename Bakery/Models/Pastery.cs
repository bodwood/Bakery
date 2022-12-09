namespace Bakery
{
  public class Pastery
  {
    public int Price { get; }
    public int Quantity { get; set; }

    public Pastery(int price)
    {
      Price = 2;
      Quantity = 0;
    }

    public int pasteryPrice(int quantity)
    {
      int userPrice = this.Price * quantity;
      int discount = (quantity / 3) * this.Price - (quantity / 3);
      if(quantity >= 3)
      {
        userPrice = userPrice - discount;
      }
      return userPrice;
    }

  }
}
