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

    

}