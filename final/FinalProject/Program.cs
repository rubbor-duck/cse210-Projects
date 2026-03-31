using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();   // master list for the vehicles
        int selection = -1;     // variable for the switch function
        int error = 0;          // error flag

        while (selection != 0)
        {
            // main menu
            Console.Clear();
            Console.WriteLine("ō͡≡o˞ Vehicle Manager ō͡≡o˞");
            Console.WriteLine("1. Save Vehicle List\n2. Load Vehicle List\n3. New Vehicle\n4. Refuel Vehicle\n5. Start Vehicle\n6. Vehicle Details\n0. Exit");

            Console.Write("Selection: ");
            selection = int.Parse(Console.ReadLine());
            {

                switch(selection)
                {
                    // Save to File
                    case 1:
                    Save(vehicles);
                    break;

                    // Load from File
                    case 2:
                    vehicles.Clear();
                    Load(vehicles);
                    break;

                    // New vehicle
                    case 3:
                    NewVehicle(vehicles);
                    break;
                    
                    // Refuel vehicle
                    case 4:
                    Console.Write("What Vehicle do you want to refull: ");
                    string vehicle_selection = Console.ReadLine();
                    error = 0;

                    foreach (Vehicle vehicle in vehicles)
                        {
                            if (vehicle.GetName() == vehicle_selection)
                            {
                                Console.Write("How much fuel do you want to put in: ");
                                double fuel = double.Parse(Console.ReadLine());
                                error = 1;

                                vehicle.ReFuel(fuel);
                                Console.WriteLine("Press enter to go back to the main menu");
                                Console.ReadLine();

                            }

                            else
                            {
                                continue;
                            }
                        }

                        // If vehicle could not be found
                        if (error != 1)
                        {
                            Console.Write($"Could not find a vehicle name '{vehicle_selection}'");
                            Console.WriteLine("Press enter to go back to the main menu");
                            Console.ReadLine();
                        }
                        
                    break;

                    // Start vehicle
                    case 5:

                    {
                    Console.Write("What Vehicle do you want to start: ");
                    vehicle_selection = Console.ReadLine();

                    error = 0;
                    foreach (Vehicle vehicle in vehicles)
                        {
                            if (vehicle.GetName() == vehicle_selection)
                            {
                                vehicle.StartEngine();
                                error = 1;
                                Console.WriteLine("Press enter to go back to the main menu");
                                Console.ReadLine();

                            }

                            else
                            {
                                continue;
                            }
                        }

                        
                        // If vehicle could not be found
                        if (error != 1)
                        {
                            Console.Write($"Could not find a vehicle name '{vehicle_selection}'");
                            Console.WriteLine("Press enter to go back to the main menu");
                            Console.ReadLine();
                        }
                    break;
                    }

                    // Vehicle details
                    case 6:
                    Console.Write("What vehicle do you want the details of: ");
                    vehicle_selection = Console.ReadLine();

                    error = 0;

                    // finds vehicle, and shows the attributes of the vehicle
                    foreach (Vehicle vehicle in vehicles)
                        {
                            if (vehicle.GetName() == vehicle_selection) {
                            string line = vehicle.GetStringRepresentation();
                            string[] parts = null;

                                // splits the string by ":"
                                parts = line.Split(":");
                                
                                
                                // line split up into its different values
                                string vehicletype = parts[0];
                                string name = parts[1];
                                string description = parts[2];
                                string year = parts[3];
                                double cost = double.Parse(parts[4]);
                                int odometer = int.Parse(parts[5]);
                                double fuelCapacity = double.Parse(parts[6]);
                                double fuelRemaning = double.Parse(parts[7]);

                                Console.WriteLine($"Name: {name}\nDescription: {description}\nYear: {year}\nCost: {cost}\nOdometer Reading: {odometer}\nTank Capacity: {fuelCapacity}\nFuel Remaining: {fuelRemaning}");

                                // 1. Sports Car\n2. Bike\n3. Truck\n4. Electric Sedan\n5. Sedan\n6. SemiTruck\n7. DirtBike
                                // checks the goal type, then loads the attributes into a new goal that gets added to the overarching goal list

                                if (vehicletype == "Truck")
                                {
                                    int bedCapacity = int.Parse(parts[8]);
                                    Console.WriteLine($"Bed Capacity: {bedCapacity}");
                                }

                                else if (vehicletype == "ElectricSedan")
                                {
                                    int batteryHealth = int.Parse(parts[8]);
                                    Console.WriteLine($"Battery Health: {batteryHealth}");
                                }

                                else if (vehicletype == "SemiTruck")
                                {
                                    bool trailer = bool.Parse(parts[8]);
                                    Console.WriteLine($"Has a Trailer: {trailer}");
                                }

                                error = 1;
                                Console.Write("Press enter to go back to the main menu");
                                Console.ReadLine();
                            }

                            else {
                                continue;
                            }
                        }    
                                // If vehicle could not be found
                                if (error != 1)
                                {
                                    Console.WriteLine($"Could not find a vehicle name '{vehicle_selection}'");
                                    Console.Write("Press enter to go back to the main menu");
                                    Console.ReadLine();
                                }
                            break;
                }
            }
        }
    }    







        // saves the vehicle list to a user specified file
    static void Save(List<Vehicle> vehicles)
    {
        string fileName;

        // gets the file name to save to
        Console.Write("What file would you like to save to? ");
        fileName = Console.ReadLine();

        // writes to a file
        using (StreamWriter _writer = new StreamWriter(fileName))
        {
            // iterates through all the goals in the list
            foreach (Vehicle vehicle in vehicles)
            {
                // converts the goal list into an array of strings for easier writing to file
                string stringrep = vehicle.GetStringRepresentation();

                // writes the array to the selected file
                _writer.WriteLine(stringrep);
                _writer.WriteLine("");
            }
        }
    }

        // loads a vehicle list from a user specified file
    static void Load(List<Vehicle> vehicles)
{
        string fileName;

        // gets the file name to load from
        Console.Write("What file would you like to load from? ");
        fileName = Console.ReadLine();

        // creates an array of all the lines of the file
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string[] parts = null;

        // goes through each line and breaks the lines down into individual strings
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            // splits the string by ":"
            parts = line.Split(":");
            
            
            // line split up into its different values
            string vehicletype = parts[0];
            string name = parts[1];
            string description = parts[2];
            string year = parts[3];
            double cost = double.Parse(parts[4]);
            int odometer = int.Parse(parts[5]);
            double fuelCapacity = double.Parse(parts[6]);
            double fuelRemaning = double.Parse(parts[7]);

            // 1. Sports Car\n2. Bike\n3. Truck\n4. Electric Sedan\n5. Sedan\n6. SemiTruck\n7. DirtBike
            // checks the goal type, then loads the attributes into a new goal that gets added to the overarching goal list
            if (vehicletype == "Sportscar")
            {
                SportsCar sports = new SportsCar(name, description, year, cost, odometer, fuelCapacity, fuelRemaning);
                vehicles.Add(sports);
            }

            else if (vehicletype == "Bike")
            {
                Bike bike = new Bike(name, description, year, cost, odometer, fuelCapacity, fuelRemaning);
                vehicles.Add(bike);
            }

            else if (vehicletype == "Truck")
            {
                int bedCapacity = int.Parse(parts[8]);
                Truck truck = new Truck(name, description, year, cost, odometer, fuelCapacity, fuelRemaning, bedCapacity);
                vehicles.Add(truck);
            }

            else if (vehicletype == "ElectricSedan")
            {
                int batteryHealth = int.Parse(parts[8]);
                ElectricSedan electric = new ElectricSedan(name, description, year, cost, odometer, fuelCapacity, fuelRemaning, batteryHealth);
                vehicles.Add(electric);
            }

            else if (vehicletype == "Sedan")
            {
                Sedan sedan = new Sedan(name, description, year, cost, odometer, fuelCapacity, fuelRemaning);
                vehicles.Add(sedan);
            }

            else if (vehicletype == "SemiTruck")
            {
                bool trailer = bool.Parse(parts[8]);
                SemiTruck truck = new SemiTruck(name, description, year, cost, odometer, fuelCapacity, fuelRemaning, trailer);
                vehicles.Add(truck);
            }

            else if (vehicletype == "Dirtbike")
            {
                Dirtbike bike = new Dirtbike(name, description, year, cost, odometer, fuelCapacity, fuelRemaning);
                vehicles.Add(bike);
            }

        }
    }

        // new vehicle selection menu
    static void NewVehicle(List<Vehicle> vehicles)
    {
        int selection = -1;
    
        Console.WriteLine("Please select an option");
        Console.WriteLine("1. Sports Car\n2. Bike\n3. Truck\n4. Electric Sedan\n5. Sedan\n6. SemiTruck\n7. DirtBike");
        Console.Write("Selection: ");
        selection = int.Parse(Console.ReadLine());
        switch(selection)
        {
            case 0:
                {
                    break;
                }
            // Sports car
            case 1:
                {
                    Console.Write("Maker/model of the car: ");
                    string name = Console.ReadLine();

                    Console.Write("Description of car: ");
                    string description = Console.ReadLine();

                    Console.Write("Year of car: ");
                    string year = Console.ReadLine();

                    Console.Write("Sell Price: ");
                    double cost = double.Parse(Console.ReadLine());

                    Console.Write("Odometer Reading: ");
                    int odometer = int.Parse(Console.ReadLine());

                    Console.Write("Fuel Capaity (Liters): ");
                    double fuelCapacity = double.Parse(Console.ReadLine());

                    Console.Write("Fuel remaning in car: ");
                    double fuelRemaning = double.Parse(Console.ReadLine());

                    SportsCar sports = new SportsCar(name, description, year, cost, odometer, fuelCapacity, fuelRemaning);

                    vehicles.Add(sports);
                    break;
                }

            // Bike
            case 2:
                {
                    Console.Write("Maker/model of the bike: ");
                    string name = Console.ReadLine();

                    Console.Write("Description of the bike: ");
                    string description = Console.ReadLine();

                    Console.Write("Year of bike: ");
                    string year = Console.ReadLine();

                    Console.Write("Sell Price: ");
                    double cost = double.Parse(Console.ReadLine());

                    Console.Write("How many miles have been put on this bike: ");
                    int odometer = int.Parse(Console.ReadLine());

                    Console.Write("Endurance of Rider (in miles): ");
                    double fuelCapacity = double.Parse(Console.ReadLine());

                    Console.Write("Energy left in Rider (in miles): ");
                    double fuelRemaning = double.Parse(Console.ReadLine());

                    Bike bike = new Bike(name, description, year, cost, odometer, fuelCapacity, fuelRemaning);

                    vehicles.Add(bike);
                    break;
                }   

            // Truck
            case 3:
                {
                    Console.Write("Maker/model of the truck: ");
                    string name = Console.ReadLine();

                    Console.Write("Description of truck: ");
                    string description = Console.ReadLine();

                    Console.Write("Year of truck: ");
                    string year = Console.ReadLine();

                    Console.Write("Sell Price: ");
                    double cost = double.Parse(Console.ReadLine());

                    Console.Write("Odometer Reading: ");
                    int odometer = int.Parse(Console.ReadLine());

                    Console.Write("Fuel Capaity (Liters): ");
                    double fuelCapacity = double.Parse(Console.ReadLine());

                    Console.Write("Fuel remaning in car: ");
                    double fuelRemaning = double.Parse(Console.ReadLine());

                    Console.Write("Bed capaity of the truck: ");
                    int bedCapacity = int.Parse(Console.ReadLine());

                    Truck truck = new Truck(name, description, year, cost, odometer, fuelCapacity, fuelRemaning, bedCapacity);

                    vehicles.Add(truck);
                    break;
                }

            // Electric Sedan
            case 4:
                {
                    Console.Write("Maker/model of the car: ");
                    string name = Console.ReadLine();

                    Console.Write("Description of car: ");
                    string description = Console.ReadLine();

                    Console.Write("Year of car: ");
                    string year = Console.ReadLine();

                    Console.Write("Sell Price: ");
                    double cost = double.Parse(Console.ReadLine());

                    Console.Write("Odometer Reading: ");
                    int odometer = int.Parse(Console.ReadLine());

                    Console.Write("Fuel Capaity (Liters): ");
                    double fuelCapacity = double.Parse(Console.ReadLine());

                    Console.Write("Fuel remaning in car: ");
                    double fuelRemaning = double.Parse(Console.ReadLine());

                    Console.Write("Battery Health % (Write in ints *ex: 95% = 95*)");
                    int batteryHealth = int.Parse(Console.ReadLine());

                    ElectricSedan sports = new ElectricSedan(name, description, year, cost, odometer, fuelCapacity, fuelRemaning, batteryHealth);

                    vehicles.Add(sports);
                    break; 
                }

            // Sedan
            case 5:
                {
                    Console.Write("Maker/model of the car: ");
                    string name = Console.ReadLine();

                    Console.Write("Description of car: ");
                    string description = Console.ReadLine();

                    Console.Write("Year of car: ");
                    string year = Console.ReadLine();

                    Console.Write("Sell Price: ");
                    double cost = double.Parse(Console.ReadLine());

                    Console.Write("Odometer Reading: ");
                    int odometer = int.Parse(Console.ReadLine());

                    Console.Write("Fuel Capaity (Liters): ");
                    double fuelCapacity = double.Parse(Console.ReadLine());

                    Console.Write("Fuel remaning in car: ");
                    double fuelRemaning = double.Parse(Console.ReadLine());

                    Sedan sedan = new Sedan(name, description, year, cost, odometer, fuelCapacity, fuelRemaning);

                    vehicles.Add(sedan);
                    break;
                }

            //  Semi Truck
            case 6:
                {
                    Console.Write("Maker/model of the car: ");
                    string name = Console.ReadLine();

                    Console.Write("Description of car: ");
                    string description = Console.ReadLine();

                    Console.Write("Year of car: ");
                    string year = Console.ReadLine();

                    Console.Write("Sell Price: ");
                    double cost = double.Parse(Console.ReadLine());

                    Console.Write("Odometer Reading: ");
                    int odometer = int.Parse(Console.ReadLine());

                    Console.Write("Fuel Capaity (Liters): ");
                    double fuelCapacity = double.Parse(Console.ReadLine());

                    Console.Write("Fuel remaning in car: ");
                    double fuelRemaning = double.Parse(Console.ReadLine());

                    Console.Write("Does it have a trailer attached (Y/N): ");
                    string temp = Console.ReadLine();
                    bool trailer;

                    while (true)
                    {
                        if (temp == "Y" || temp == "y")
                        {
                            trailer = true;
                            break;
                        }

                        else if (temp == "N" || temp == "n")
                        {
                            trailer = false;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Not a valid response");
                        }
                    }

                    SemiTruck semi = new SemiTruck(name, description, year, cost, odometer, fuelCapacity, fuelRemaning, trailer);

                    vehicles.Add(semi);
                    break;
                }  

            // DirtBike
            case 7:
                {
                    Console.Write("Maker/model of the dirtbike: ");
                    string name = Console.ReadLine();

                    Console.Write("Description of dirtbike: ");
                    string description = Console.ReadLine();

                    Console.Write("Year of dirtbike: ");
                    string year = Console.ReadLine();

                    Console.Write("Sell Price: ");
                    double cost = double.Parse(Console.ReadLine());

                    Console.Write("Odometer Reading: ");
                    int odometer = int.Parse(Console.ReadLine());

                    Console.Write("Fuel Capaity (Liters): ");
                    double fuelCapacity = double.Parse(Console.ReadLine());

                    Console.Write("Fuel remaning in car: ");
                    double fuelRemaning = double.Parse(Console.ReadLine());

                    Dirtbike dirtbike = new Dirtbike(name, description, year, cost, odometer, fuelCapacity, fuelRemaning);

                    vehicles.Add(dirtbike);
                    break;
                }    
        }
    }
}