using WarmDrinkStation.Drinks;

namespace WarmDrinkStation.Factories;

public class ChocolateFactory : IWarmDrinkFactory
{
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml hot chocolate in your cup");
        return new Chocolate();
    }
}