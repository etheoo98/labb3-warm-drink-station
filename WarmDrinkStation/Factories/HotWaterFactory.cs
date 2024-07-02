using WarmDrinkStation.Drinks;

namespace WarmDrinkStation.Factories;

// Implementerar en specifik fabrik som förbereder varmt vatten
internal class HotWaterFactory : IWarmDrinkFactory
{
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml hot water in your cup"); // Utskrift av mängden vatten som hälls upp
        return new Water(); // Returnerar en ny instans av Water
    }
}