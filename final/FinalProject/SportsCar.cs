using System.ComponentModel;

public class SportsCar : Vehicle
{
    public SportsCar (string name, string description, string year, double cost, int odometer, double fuelCapacity, double fuelRemaning) : base(name, description, year, cost, odometer, fuelCapacity, fuelRemaning)
    {
        
    }

    public override void ReFuel(double fuel)
    {
        base.ReFuel(fuel);

    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("Vroooom!!!");
        Console.WriteLine($"{GetName()} has been started");
    }
}