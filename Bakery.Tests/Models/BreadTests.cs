using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.TestTools
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void greetingCustomer_ReturnsGreetingWhenStart_String()
    {
      Bread breadGreeting = new Bread();
      string expected = "Welcome to our bakery. Our prices are as follows \nBread: \nPastery: ";
      string result = breadGreeting.greetingCustomer();
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void breadPrice_ReturnsPriceOfBread_int()
    {
      Bread breadCost = new Bread();
      int expectedPrice = 5;
      int userQuantity = 1;
      int actualPrice = breadCost.breadPrice(userQuantity);
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }


//----------------------------------------------------------------------------------------------------
  [TestClass]
  public class PasteryTests
  {
    //[TestMethod]
    
  }
}
