using System.Collections.Generic;
namespace Bakery
{
  public class Bread
  {
    public int [] BreadArray {get; set;}
    public int Order {get; set;}
    public int BreadPrice {get; set;}
    public Bread(int order)
    {
      BreadArray = new int [3]; 
      Order = order;
      BreadPrice = 0;
    }

    public void SetPrice()
    {int breadPrice = 0;
      for (int i=1; i<= Order; i++)
      { if (i % 3 == 0)
        { 
        }
        else
        { breadPrice += 5;
        }
      }
    BreadPrice = breadPrice; 
    }
  }
}