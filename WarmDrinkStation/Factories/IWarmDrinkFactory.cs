using WarmDrinkStation.Drinks;

namespace WarmDrinkStation.Factories;

public interface IWarmDrinkFactory
{
    IWarmDrink Prepare(int total); // Metod för att förbereda drycken med en specifik mängd
}
