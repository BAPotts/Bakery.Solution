namespace Bakery
{
  public class Pastry
  {
    public int [] PastryArray {get; set;}
    public int Order {get; set;}
    public int PastryPrice {get; set;}
    public Pastry(int[] pastryArray)
    {
      PastryArray = pastryArray;
      Order = 0;
      PastryPrice = 0;
    }

    public void SetPrice()
    {int pastryPrice = 0;
      for (int i=1; i<= Order; i++)
      { if (i % 3 == 0)
        { pastryPrice += 1;
        }
        else
        { pastryPrice += 2;
        }
      }
    PastryPrice = pastryPrice; 
    }
      public void AddPastryOrder()
    {int order = 0;
      for(int i = 0; i <PastryArray.Length; i++)
      {
        order += PastryArray[i];
      }
      Order = order;
    }
  }
}