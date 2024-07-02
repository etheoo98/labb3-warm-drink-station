using WarmDrinkStation;
using WarmDrinkStation.Drinks;

var machine = new WarmDrinkMachine(); // Skapar en instans av WarmDrinkMachine
IWarmDrink drink = machine.MakeDrink(); // Skapar en dryck
drink.Consume(); // Konsumerar drycken