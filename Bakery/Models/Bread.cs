namespace Bakery
{
  public class Bread
  {
    public int Order {get; set;}
    public int BreadPrice {get; set;}
    public Bread(int order)
    {
      Order = order;
      BreadPrice = 0;
    }

    public void GetPrice()
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