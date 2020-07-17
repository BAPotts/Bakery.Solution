using System;

namespace Bakery {

  public class Program {

    public static void Main()
    {
      Greeting();

      Console.WriteLine("How many loaves of bread would you like?");
      int breadOrder = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int pastryOrder = int.Parse(Console.ReadLine());

      Bread newBread = new Bread(breadOrder);
      newBread.SetPrice();
      Pastry newPastry = new Pastry(pastryOrder);
      newPastry.SetPrice();
      Console.WriteLine("---------Your Order-----------");
      OrderOutput(newBread);
      Console.WriteLine("Pastry Order: " + pastryOrder);
      //Console.WriteLine("Pastry Price Sub-Total: $" + pastryTotal);
      // Console.WriteLine("Total Price: $" + (breadTotal + pastryTotal));
    }

    public static void Greeting()
    {
      Console.WriteLine("------------Welcome to Pierre's Bakery!-------");
      Console.WriteLine("Bread:$5 each or buy 2, get 1 free!");
      Console.WriteLine("Pastries: $2 each or 3 for $5!");
    }

    public static void OrderOutput(Bread bread)
    {
      Console.WriteLine("Bread Order: " + bread.Order);
      Console.WriteLine("Bread Price Sub-Total: $" + bread.BreadPrice);
    }
  }
}