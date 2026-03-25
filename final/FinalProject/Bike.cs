public class Bike : Vehicle
{
    public Bike(string name, string description, string year, double cost, int odometer, double fuelCapacity, double fuelRemaning) : base(name, description, year, cost, odometer, fuelCapacity, fuelRemaning)
    {
        
    }

    public override void ReFuel(double fuel)
    {
        Console.WriteLine("*Gives granola bar and gaterade to cyclist*");
        Console.WriteLine("The cyclist has been refueled");
        SetFuel(fuel);
    }

    public override void StartEngine()
    {
        Console.WriteLine("Cyclist turns on helmet flashlight.");
        TurnOnLights();

        if (GetFuel() <=0)
        {
            Console.WriteLine("The cyclist is too tired to bike. He need some food/rest :(");
            return;
        }
        Console.WriteLine("*crickets*");
        Console.WriteLine($"{GetName()} has been started, if you can call hopping on the bike starting it.");
    }
}