using System.Collections.Generic;
namespace Bakery
{
  public class Bread
  {
    public int [] BreadArray {get; set;}
    public int Order {get; set;}
    public int BreadPrice {get; set;}
    public Bread(int[] breadArray)
    {
      BreadArray = breadArray; 
      Order = 0;
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
    public void AddBreadOrder()
    {int order = 0;
      for(int i = 0; i <BreadArray.Length; i++)
      {
        order += BreadArray[i];
      }
      Order = order;
    }
  }
}