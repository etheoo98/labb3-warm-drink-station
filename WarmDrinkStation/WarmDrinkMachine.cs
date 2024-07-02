using WarmDrinkStation.Drinks;
using WarmDrinkStation.Factories;

namespace WarmDrinkStation;

// Maskin som hanterar skapandet av varma drycker
public class WarmDrinkMachine
{
    private readonly List<Tuple<string, IWarmDrinkFactory>> namedFactories; // Lista över fabriker med deras namn

    public WarmDrinkMachine()
    {
        namedFactories = new List<Tuple<string, IWarmDrinkFactory>>(); // Initierar listan över fabriker

        // Registrerar fabriker explicit
        RegisterFactory<HotWaterFactory>("Hot Water"); // Registrerar fabriken för varmt vatten
        RegisterFactory<CoffeeFactory>("Coffee");
        RegisterFactory<CappuccinoFactory>("Cappuccino");
        RegisterFactory<ChocolateFactory>("Chocolate");
    }

    // Metod för att registrera en fabrik
    private void RegisterFactory<T>(string drinkName) where T : IWarmDrinkFactory, new()
    {
        namedFactories.Add(Tuple.Create(drinkName, (IWarmDrinkFactory)Activator.CreateInstance(typeof(T)))); // Lägger till fabriken i listan
    }

    // Metod för att skapa en varm dryck
    public IWarmDrink MakeDrink()
    {
        Console.WriteLine("This is what we serve today:");
        for (var index = 0; index < namedFactories.Count; index++)
        {
            var tuple = namedFactories[index];
            Console.WriteLine($"{index}: {tuple.Item1}"); // Skriver ut tillgängliga drycker
        }
        Console.WriteLine("Select a number to continue:");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int i) && i >= 0 && i < namedFactories.Count) // Läser och validerar användarens val
            {
                Console.Write("How much: ");
                if (int.TryParse(Console.ReadLine(), out int total) && total > 0) // Läser och validerar mängden
                {
                    return namedFactories[i].Item2.Prepare(total); // Förbereder och returnerar drycken
                }
            }
            Console.WriteLine("Something went wrong with your input, try again."); // Meddelande vid felaktig inmatning
        }
    }
}