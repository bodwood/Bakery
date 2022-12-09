namespace Bakery
{
  public class Pastery
  {
    public int Price { get; }
    public int Quantity { get; set; }

    public Pastery(int price, int quantity)
    {
      Price = 2;
      Quantity = 0;
    }

    public int pasteryPrice(int quantity)
    {
      return quantity;
    }

  }
}
