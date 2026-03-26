public class SemiTruck : Vehicle
{
    private bool _trailer;

    public SemiTruck(string name, string description, string year, double cost, int odometer, double fuelCapacity, double fuelRemaning, bool trailer) : base(name, description, year, cost, odometer, fuelCapacity, fuelRemaning)
    {
        _trailer = trailer;
    }

    public bool GetTrailer()
    {
        return _trailer;
    }

    public override void EngineStartMessage()
    {
        Console.WriteLine("Rabababababababababababa");
        Console.WriteLine($"{GetName()} rumbles to life");
    }

    public override string GetStringRepresentation()
    {
        string stringrep = $"SemiTruck: {GetName()}:{GetDescription()}:{GetYear()}:{GetCost()}:{GetOdometer()}:{GetFuelCapacity()}:{GetFuel()}:{_trailer}";

        return stringrep;
    }
}