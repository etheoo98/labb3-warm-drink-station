namespace WarmDrinkStation.Drinks;

public class Coffee : IWarmDrink
{
    public void Consume()
    {
        Console.WriteLine("Warm coffee is served.");
    }
}