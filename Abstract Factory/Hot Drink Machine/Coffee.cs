using static System.Console;

namespace Abstract_Factory
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            WriteLine("This coffee is delicious!");
        }
    }
}