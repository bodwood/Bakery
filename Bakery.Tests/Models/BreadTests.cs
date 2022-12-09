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
      string expected = "";
      string result = breadGreeting.greetingCustomer();
      Assert.AreEqual(expected, result);
    }
  }
}
