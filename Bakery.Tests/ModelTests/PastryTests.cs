using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    //[TestMethod]
    // public void PastryConstructor_HasOrder_3()
    // {
    //   int order = 3;
    //   Pastry newPastry = new Pastry(order);
    //   Assert.AreEqual(3, newPastry.Order);
    // }
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
      int [] pastryArray = new int [3] {3, 6, 1};
      Pastry newPastry = new Pastry(pastryArray);
      newPastry.AddPastryOrder();
      newPastry.SetPrice();
      
      Assert.AreEqual(17, newPastry.PastryPrice);
    }
    [TestMethod]
    public void AddPastryOrder_AddsArrayValues_7()
    {
      int [] pastryArray = new int [3] {2, 4, 1};
      Pastry newPastry = new Pastry(pastryArray);
      newPastry.AddPastryOrder();
      Assert.AreEqual(7, newPastry.Order);
    }
  }
}