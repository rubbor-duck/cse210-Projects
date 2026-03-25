public class Dirtbike : Vehicle
{
    public Dirtbike(string name, string description, string year, double cost, int odometer, double fuelCapacity, double fuelRemaning) : base(name, description, year, cost, odometer, fuelCapacity, fuelRemaning)
    {
        
    }

    public override void EngineStartMessage()
    {
        Console.WriteLine("Reeninininininininine");
        Console.WriteLine($"{GetName} renenenings on");
    }
}