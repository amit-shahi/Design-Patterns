using static System.Console;

namespace Abstract_Factory
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            WriteLine("This tea is awesome!");
        }
    }
}