public class ElectricSedan : Vehicle
{
    private double _batteryHealth;

    public ElectricSedan(string name, string description, string year, double cost, int odometer, double fuelCapacity, double fuelRemaning, int batteryHealth) : base(name, description, year, cost, odometer, fuelCapacity, fuelRemaning)
    {
        _batteryHealth = batteryHealth;
    }

    public double GetBatteryHealth()
    {
        return _batteryHealth;
    }

    public override void ReFuel(double fuel)
    {
        SetFuel(fuel);
        if (_batteryHealth <= 30)
        {
            Console.WriteLine("You can only charge to 50%, you need to change the car's battery");
            SetFuel(0.5 * GetFuelCapacity());
        }

        if(GetFuel() > GetFuelCapacity())
        {
            SetFuel(GetFuelCapacity());
            Console.WriteLine("The charger stopped at 100% to protect the battery");
        }
    }

    public override void EngineStartMessage()
    {
        Console.WriteLine("You hear the quite hum of the fans turn on.");
        Console.WriteLine($"{GetName} has quitely started, ready to be eco friendly 🤮");
    }

    public override void StartEngine()
    {
        base.StartEngine();

        EngineStartMessage();
    }

}