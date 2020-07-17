using Microsoft.VisualStudio.TestTools.UnitTesting;


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
    //[TestMethod]
    // public void PastryPrice_Every3rdpastry1Dollar_17()
    // {
    //   int order = 10;
    //   Pastry newPastry = new Pastry(order);
    //   Assert.AreEqual(17, newPastry.GetPrice());
    // }

    [TestMethod]
    public void SetPrice_Every3rdpastry1Dollar_17()
    {
      int order = 10;
      Pastry newPastry = new Pastry(order);
      newPastry.SetPrice();
      Assert.AreEqual(17, newPastry.PastryPrice);
    }

  }
}