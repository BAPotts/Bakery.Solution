namespace Bakery
{
  public class Pastry
  {
    public int Order {get; set;}
    public int PastryPrice {get; set;}
    public Pastry(int order)
    {
      Order = order;
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
  }
}