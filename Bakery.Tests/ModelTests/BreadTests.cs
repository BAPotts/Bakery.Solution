using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // [TestMethod]
    // public void BreadConstructor_HasOrder_3()
    // {
    //   int order = 3;
    //   Bread newBread = new Bread(order);
    //   Assert.AreEqual(3, newBread.Order);
    // }

    // [TestMethod]
    // public void BreadPrice_Gives3rdBreadFree_20()
    // {
    //   int order = 6;
    //   Bread newBread = new Bread(order);
    //   Assert.AreEqual(20, newBread.GetPrice());
    // }
    [TestMethod]
    public void SetPrice_Gives3rdBreadFree_20()
    {
      int [] breadArray = new int [3] {2, 4, 1};
      Bread newBread = new Bread(breadArray);
      newBread.AddBreadOrder();
      newBread.SetPrice();

      Assert.AreEqual(25, newBread.BreadPrice);
    }
    [TestMethod]
    public void AddBreadOrder_AddsArrayValues_7()
    {
      int [] breadArray = new int [3] {2, 4, 1};
      Bread newBread = new Bread(breadArray);
      newBread.AddBreadOrder();
      Assert.AreEqual(7, newBread.Order);
    }
  }
}