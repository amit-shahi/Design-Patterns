namespace Abstract_Factory
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}