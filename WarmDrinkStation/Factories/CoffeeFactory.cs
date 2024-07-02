using WarmDrinkStation.Drinks;

namespace WarmDrinkStation.Factories;

public class CoffeeFactory : IWarmDrinkFactory
{
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml hot coffee in your cup");
        return new Coffee();
    }
}