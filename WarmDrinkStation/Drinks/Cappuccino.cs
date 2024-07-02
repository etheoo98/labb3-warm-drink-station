namespace WarmDrinkStation.Drinks;

public class Cappuccino : IWarmDrink
{
    public void Consume()
    {
        Console.WriteLine("Warm cappuccino is served.");
    }
}