using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_HasOrder_3()
    {
      int order = 3;
      Bread newBread = new Bread(order);
      Assert.AreEqual(3, newBread.Order);
    }

  }
}