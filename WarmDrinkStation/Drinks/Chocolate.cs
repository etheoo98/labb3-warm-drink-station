namespace WarmDrinkStation.Drinks;

public class Chocolate : IWarmDrink
{
    public void Consume()
    {
        Console.WriteLine("Warm chocolate is served.");
    }
}