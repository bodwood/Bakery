using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.TestTools
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void PriceConstructor_CreatesInstanceOfPrice_Price()
    {
      Bread newPrice = new Bread(5,3);
      Assert.AreEqual(typeof(Bread), newPrice.GetType());
    }

    [TestMethod]
    public void breadPrice_ReturnsPriceOfBread_int()
    {
      Bread newPrice = new Bread(5,3);
      int expectedPrice = 5;
      int userQuantity = 1;
      int actualPrice = newPrice.breadPrice(userQuantity);
      Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void breadPrice_ReturnPriceFor2Loafs_int()
    {
      Bread newPrice = new Bread(5,3);
      int expectedPrice = 10;
      int actualPrice = newPrice.breadPrice(2);
      Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void breadPrice_ReturnPriceFor3Loafs_int()
    {
      Bread newPrice = new Bread(5,3);
      int expectedPrice = 20;
      int userQuantity = 6;
      int actualPrice = newPrice.breadPrice(userQuantity);
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }


  //----------------------------------------------------------------------------------------------------
  [TestClass]
  public class PasteryTests
  {
    [TestMethod]
    public void Pastery_ReturnPasteryType_type()
    {
      Pastery pasteryType = new Pastery();
      Assert.AreEqual(typeof(Pastery), pasteryType.GetType());
    }

  }
}
