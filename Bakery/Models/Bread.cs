namespace Bakery
{
  public class Bread
  {
    public int Order {get; set;}
    public Bread(int order)
    {
      Order = order;
    }

    public int getPrice()
    {int breadPrice = 0;
      for (int i=0; i<= Order; i++)
      { if (i % 2 == 0)
        { 
        }
        else
        { breadPrice += 5;
        }
      }
     return breadPrice; 
    }
  }
}