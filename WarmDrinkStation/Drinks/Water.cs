namespace WarmDrinkStation.Drinks;

internal class Water : IWarmDrink
{
    public void Consume()
    {
        Console.WriteLine("Warm water is served."); // Utskrift vid konsumtion av vatten
    }
}