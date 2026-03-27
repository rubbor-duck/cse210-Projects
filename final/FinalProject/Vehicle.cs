using System.Net;

public abstract class Vehicle
{
    private string _name;
    private string _description;
    private string _year;
    private double _cost;
    private int _odometer;
    private double _fuelRemaning;
    private double _fuelCapacity;
    private bool _lights;

    // Constructor
    public Vehicle(string name, string description, string year, double cost, int odometer, double fuelCapacity, double fuelRemaning)
    {
        _name = name;
        _description = description;
        _year = year;
        _cost = cost;
        _odometer = odometer;
        _fuelCapacity = fuelCapacity;
        _fuelRemaning = fuelRemaning;
        _lights = false;
    }

    // Gets name
    public string GetName()
    {
        return _name;
    }

    // Gets description
    public string GetDescription()
    {
        return _description;
    }

    // Gets the Year
    public string GetYear()
    {
        return _year;
    }

    // Gets the Cost
    public double GetCost()
    {
        return _cost;
    }

    // Sets the fuel to whatever fuelRemaning is equal to
    public void SetFuel(double fuelRemaning)
    {
        _fuelRemaning = fuelRemaning;
    }

    // Gets the current fuel level in the car
    public double GetFuel()
    {
        return _fuelRemaning;
    }

    // Gets the fuel capacity of the car
    public double GetFuelCapacity()
    {
        return _fuelCapacity;
    }

    // Gets the odometer
    public int GetOdometer()
    {
        return _odometer;
    }

    // virtual function to refuel the vehicle
    public virtual void ReFuel(double fuel)
    {
        _fuelRemaning += fuel;

        if (_fuelRemaning > _fuelCapacity)
        {
            Console.WriteLine("Fuel is spilling out of the tank!");
            _fuelRemaning = _fuelCapacity;
        }

        else if (_fuelRemaning == _fuelCapacity)
        {
            Console.WriteLine("Tank is full");
        }

        else
        {
            Console.WriteLine($"Tank is filled to {_fuelRemaning}L out of {_fuelCapacity}L");
        }
    }

    // turns on light
    public void TurnOnLights()
    {
        _lights = true;
        Console.WriteLine("Lights are now on");
    }

    // turns off light
    public void TurnOffLights()

    {
        _lights = false;
        Console.WriteLine("Lights have been turned off");
    }

    // virtual function that displays a start engine message
    public virtual void EngineStartMessage()
    {
        Console.WriteLine("Vroom");
        Console.WriteLine($"{_name} has fired up");
    }

    // virtual function that starts the vehicle's engine
    public virtual void StartEngine()
    {
        TurnOnLights();

        if (_fuelRemaning <=0)
        {
            Console.WriteLine("The car sputters out. You are out of fuel :(");
            return;
        }

        EngineStartMessage();
    }

    // converts the attributes into a single string for displaying/saving
    public virtual string GetStringRepresentation()
    {
        string stringrep = $"Vehicle:{_name}:{_description}:{_year}:{_cost}:{_odometer}:{_fuelCapacity}:{_fuelRemaning}";

        return stringrep;
    }
}