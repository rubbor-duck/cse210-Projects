public class Dirtbike : Vehicle
{
    public Dirtbike(string name, string description, string year, double cost, int odometer, double fuelCapacity, double fuelRemaning) : base(name, description, year, cost, odometer, fuelCapacity, fuelRemaning)
    {
        
    }

    public override void EngineStartMessage()
    {
        Console.WriteLine("Reeninininininininine");
        Console.WriteLine($"{GetName()} renenenings on");
    }

    public override string GetStringRepresentation()
    {
        string stringrep = $"Dirtbike:{GetName()}:{GetDescription()}:{GetYear()}:{GetCost()}:{GetOdometer()}:{GetFuelCapacity()}:{GetFuel()}";

        return stringrep;
    }
}