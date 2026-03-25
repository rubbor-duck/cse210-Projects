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


    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetYear()
    {
        return _year;
    }

    public double GetCost()
    {
        return _cost;
    }

    public void SetFuel(double fuelRemaning)
    {
        _fuelRemaning = fuelRemaning;
    }

    public double GetFuel()
    {
        return _fuelRemaning;
    }

    public double GetFuelCapacity()
    {
        return _fuelCapacity;
    }

    public int GetOdometer()
    {
        return _odometer;
    }

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

    public void TurnOnLights()
    {
        _lights = true;
        Console.WriteLine("Lights are now on");
    }

    public void TurnOffLights()

    {
        _lights = false;
        Console.WriteLine("Lights have been turned off");
    }

    public virtual void StartEngine()
    {
        TurnOnLights();

        if (_fuelRemaning <=0)
        {
            Console.WriteLine("The car sputters out. You are out of fuel :(");
            return;
        }

        Console.WriteLine("Vroom");
        Console.WriteLine($"{_name} has fired up");
    }
}