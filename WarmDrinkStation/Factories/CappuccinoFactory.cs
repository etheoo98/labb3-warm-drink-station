using WarmDrinkStation.Drinks;

namespace WarmDrinkStation.Factories;

public class CappuccinoFactory : IWarmDrinkFactory
{
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml hot cappuccino in your cup");
        return new Cappuccino();
    }
}