using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_HasOrder_3()
    {
      int order = 3;
      Pastry newPastry = new Pastry(order);
      Assert.AreEqual(3, newPastry.Order);
    }
  }
}