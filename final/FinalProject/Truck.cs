public class Truck : Vehicle
{
    private int _bedCapacity;

    public Truck(string name, string description, string year, double cost, int odometer, double fuelCapacity, double fuelRemaning, int bedCapacity) : base(name, description, year, cost, odometer, fuelCapacity, fuelRemaning)
    {
        _bedCapacity = bedCapacity;
    }

    public int GetBedCapacity()
    {
        return _bedCapacity;
    }

    public override void EngineStartMessage()
    {
        Console.WriteLine("Rummmmmmmmmmmmmmmmm");
        Console.WriteLine($"{GetName()} has roared to life");
    }

    public override void StartEngine()
    {
        base.StartEngine();

        EngineStartMessage();
    }

}