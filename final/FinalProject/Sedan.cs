public class Sedan : Vehicle
{
    public Sedan(string name, string description, string year, double cost, int odometer, double fuelCapacity, double fuelRemaning) : base(name, description, year, cost, odometer, fuelCapacity, fuelRemaning)
    {
        
    }

    public override string GetStringRepresentation()
    {
        string stringrep = $"Sedan: {GetName()}:{GetDescription()}:{GetYear()}:{GetCost()}:{GetOdometer()}:{GetFuelCapacity()}:{GetFuel()}";

        return stringrep;
    }
}