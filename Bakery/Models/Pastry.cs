namespace Bakery
{
  public class Pastry
  {
    public int Order {get; set;}

    public Pastry(int order)
    {
      Order = order;
    }

    public int GetPrice()
    {int pastryPrice = 0;
      for (int i=1; i<= Order; i++)
      { if (i % 3 == 0)
        { pastryPrice += 1;
        }
        else
        { pastryPrice += 2;
        }
      }
    return pastryPrice; 
    }
  }
}