using System;

namespace Bakery {

  public class Program {

    public static void Main()
    {
      Greeting();
      int [] breadArray = new int[3];
      Console.WriteLine("How many loaves of sourdough would you like?");
      breadArray[0] = int.Parse(Console.ReadLine());
      Console.WriteLine("How many loaves of marble rye would you like?");
      breadArray[1] = int.Parse(Console.ReadLine());
      Console.WriteLine("How many loaves of honey wheat would you like?");
      breadArray[2] = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int pastryOrder = int.Parse(Console.ReadLine());

      Bread newBread = new Bread(breadArray);
      newBread.AddBreadOrder();
      newBread.SetPrice();
      Pastry newPastry = new Pastry(pastryOrder);
      newPastry.SetPrice();
      
      OrderOutput(newBread, newPastry);
      
    }

    public static void Greeting()
    {
      Console.WriteLine("------------Welcome to Pierre's Bakery!-------");
      Console.WriteLine("Bread:$5 each or buy 2, get 1 free!");
      Console.WriteLine("Pastries: $2 each or 3 for $5!");
    }

    public static void OrderOutput(Bread bread, Pastry pastry)
    {
      Console.WriteLine("---------Your Order-----------");
      Console.WriteLine("Bread Order: ");
      Console.WriteLine("Sourdough: " + bread.BreadArray[0]);
      Console.WriteLine("Marble Rye: " + bread.BreadArray[1]);
      Console.WriteLine("Honey Wheat: " + bread.BreadArray[2]);
      Console.WriteLine("Bread Price Sub-Total: $" + bread.BreadPrice);
      Console.WriteLine("Pastry Order: " + pastry.Order);
      Console.WriteLine("Pastry Price Sub-Total: $" + pastry.PastryPrice);
      Console.WriteLine("Total Price: $" + (bread.BreadPrice + pastry.PastryPrice));
    }
  }
}