using System;
using Bakery;
namespace Bakery {

  public class Program {

    public static void Main()
    {
      Console.WriteLine("------------Welcome to Pierre's Bakery!-------");
      Console.WriteLine("Bread:$5 each or buy 2, get 1 free!");
      Console.WriteLine("Pastries: $2 each or 3 for $5!");
      Console.WriteLine("How many loves of bread would you like?");
      int pastryOrder = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int breadOrder = int.Parse(Console.ReadLine());
      
    }
  }
}