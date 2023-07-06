using System;

class Engine
{
    public int Power { get; set; }
    public int Volume { get; set; }
    public string Type { get; set; }
    public string SerialNumber { get; set; }

    public override string ToString()
    {
        return $"Engine: Power={Power}, Volume={Volume}, Type={Type}, SerialNumber={SerialNumber}";
    }
}

class Chassis
{
    public int WheelsNumber { get; set; }
    public int Number { get; set; }
    public int PermissibleLoad { get; set; }

    public override string ToString()
    {
        return $"Chassis: WheelsNumber={WheelsNumber}, Number={Number}, PermissibleLoad={PermissibleLoad}";
    }
}

class Transmission
{
    public string Type { get; set; }
    public int NumberOfGears { get; set; }
    public string Manufacturer { get; set; }

    public override string ToString()
    {
        return $"Transmission: Type={Type}, NumberOfGears={NumberOfGears}, Manufacturer={Manufacturer}";
    }
}

class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }

    public override string ToString()
    {
        return $"Vehicle: Make={Make}, Model={Model}, Year={Year}, {Engine}, {Chassis}, {Transmission}";
    }
}

class PassengerCar : Vehicle
{
    public int PassengerCapacity { get; set; }

    public override string ToString()
    {
        return $"PassengerCar: {base.ToString()}, PassengerCapacity={PassengerCapacity}";
    }
}

class Truck : Vehicle
{
    public int CargoCapacity { get; set; }

    public override string ToString()
    {
        return $"Truck: {base.ToString()}, CargoCapacity={CargoCapacity}";
    }
}

class Bus : Vehicle
{
    public int PassengerCapacity { get; set; }
    public int StandingCapacity { get; set; }

    public override string ToString()
    {
        return $"Bus: {base.ToString()}, PassengerCapacity={PassengerCapacity}, StandingCapacity={StandingCapacity}";
    }
}

class Scooter : Vehicle
{
    public int MaxSpeed { get; set; }

    public override string ToString()
    {
        return $"Scooter: {base.ToString()}, MaxSpeed={MaxSpeed}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Engine engine1 = new Engine { Power = 200, Volume = 3000, Type = "Gasoline", SerialNumber = "123" };
        Chassis chassis1 = new Chassis { WheelsNumber = 4, Number = 1234, PermissibleLoad = 1000 };
        Transmission transmission1 = new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Ford" };
        PassengerCar car1 = new PassengerCar { Make = "Ford", Model = "Mustang", Year = 2022, Engine = engine1, Chassis = chassis1, Transmission = transmission1, PassengerCapacity = 4 };

        Engine engine2 = new Engine { Power = 300, Volume = 5000, Type = "Diesel", SerialNumber = "456" };
        Chassis chassis2 = new Chassis { WheelsNumber = 6, Number = 5678, PermissibleLoad = 5000 };
        Transmission transmission2 = new Transmission { Type = "Manual", NumberOfGears = 10, Manufacturer = "Volvo" };
        Truck truck1 = new Truck { Make = "Volvo", Model = "FH16", Year = 2021, Engine = engine2, Chassis = chassis2, Transmission = transmission2, CargoCapacity = 20000 };

        Engine engine3 = new Engine { Power = 150, Volume = 2500, Type = "Gasoline", SerialNumber = "789" };
        Chassis chassis3 = new Chassis { WheelsNumber = 6, Number = 9012, PermissibleLoad = 4000 };
        Transmission transmission3 = new Transmission { Type = "Automatic", NumberOfGears = 6, Manufacturer = "Mercedes-Benz" };
        Bus bus1 = new Bus { Make = "Mercedes-Benz", Model = "Citaro", Year = 2020, Engine = engine3, Chassis = chassis3, Transmission = transmission3, PassengerCapacity = 50, StandingCapacity = 20 };

        Engine engine4 = new Engine { Power = 50, Volume = 150, Type = "Electric", SerialNumber = "101" };
        Chassis chassis4 = new Chassis { WheelsNumber = 2, Number = 3456, PermissibleLoad = 150 };
        Transmission transmission4 = new Transmission { Type = "Automatic", NumberOfGears = 1, Manufacturer = "Honda" };
        Scooter scooter1 = new Scooter { Make = "Honda", Model = "PCX", Year = 2022, Engine = engine4, Chassis = chassis4, Transmission = transmission4, MaxSpeed = 70 };

        Console.WriteLine(car1);
        Console.WriteLine(truck1);
        Console.WriteLine(bus1);
        Console.WriteLine(scooter1);
    }
}