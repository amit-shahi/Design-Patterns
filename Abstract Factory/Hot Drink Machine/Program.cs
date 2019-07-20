using System;
using static System.Console;


namespace Abstract_Factory
{
  public interface IHotDrink
  {
    void Consume();
  }

  
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Abstract Factory Design Pattern");

            var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 300);
            //drink.Consume();

            IHotDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
