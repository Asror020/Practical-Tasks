using System;

struct Coordinate
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}

interface IFlyable
{
    void FlyTo(Coordinate point);

    TimeSpan GetFlyTime(Coordinate point);
}

abstract class Flyable : IFlyable
{
    public int Speed { get; set; }

    public Coordinate CurrentPosition { get; set; }

    public virtual void FlyTo(Coordinate point)
    {
        Console.WriteLine($"Object is flying to {point}");
    }

    public virtual TimeSpan GetFlyTime(Coordinate point)
    {
        double distance = CalculateDistance(CurrentPosition, point);
        TimeSpan time = TimeSpan.FromHours(distance / Speed);
        return time;
    }

    public double CalculateDistance(Coordinate a, Coordinate b)
    {
        double dx = a.X - b.X;
        double dy = a.Y - b.Y;
        double dz = a.Z - b.Z;
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}

class Bird : Flyable
{
    public Bird()
    {
        Random random = new Random();
        Speed = random.Next() % 20 + 1;
    }

    public override void FlyTo(Coordinate point)
    {
        Console.WriteLine($"A bird is flying to {point} at a speed of {Speed} km/h");
    }
}

class Airplane : Flyable
{
    private double _initialSpeed = 200;

    public Airplane()
    {
        Speed = 200;
    }

    public override void FlyTo(Coordinate point)
    {
        double distance = CalculateDistance(CurrentPosition, point);

        Console.WriteLine($"An airplane started to fly to {point} at a speed of {Speed} km/h");

        while (distance > 10)
        {
            _initialSpeed += 10;
            distance -= 10;
            Console.WriteLine($"Airplane increased its speed to {_initialSpeed}");
        }
    }

    public override TimeSpan GetFlyTime(Coordinate point)
    {
        double speed = Speed;
        double distance = CalculateDistance(CurrentPosition, point);
        double time = 0;

        while (distance > 10)
        {
            time += 10 / speed;
            distance -= 10;
            speed += 10;
        }
        time += distance / speed;

        return TimeSpan.FromHours(time);
    }

}

class Drone : Flyable
{
    private const double MAX_DISTANCE = 1000;

    public Drone()
    {
        Speed = 50;
    }

    public override void FlyTo(Coordinate point)
    {
        double distance = CalculateDistance(CurrentPosition, point);
        if (distance > MAX_DISTANCE)
        {
            Console.WriteLine($"Cannot fly drone to {point}, distance is beyond maximum of {MAX_DISTANCE}");
            return;
        }

        Console.WriteLine($"A drone is flying to {point} at a speed of {Speed} km/h");
    }

    public override TimeSpan GetFlyTime(Coordinate point)
    {
        double distance = CalculateDistance(CurrentPosition, point);
        if (distance > MAX_DISTANCE)
        {
            Console.WriteLine($"Cannot fly drone to {point}, distance is beyond maximum of {MAX_DISTANCE}");
            return TimeSpan.Zero;
        }

        double time = distance / Speed;
        double hoverTime = distance / 10;

        return TimeSpan.FromHours(time) + TimeSpan.FromMinutes(hoverTime);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Coordinate startingPoint = new Coordinate { X = 0, Y = 0, Z = 0 };
        Coordinate endPoint = new Coordinate { X = 100, Y = 50, Z = 20 };

        Bird bird = new Bird();
        bird.CurrentPosition = startingPoint;

        Airplane airplane = new Airplane();
        airplane.CurrentPosition = startingPoint;

        Drone drone = new Drone();
        drone.CurrentPosition = startingPoint;

        bird.FlyTo(endPoint);
        Console.WriteLine($"Bird fly time: {bird.GetFlyTime(endPoint)}");

        airplane.FlyTo(endPoint);
        Console.WriteLine($"Airplane fly time: {airplane.GetFlyTime(endPoint)}");

        drone.FlyTo(endPoint);
        Console.WriteLine($"Drone fly time: {drone.GetFlyTime(endPoint)}");

        Console.ReadLine();
    }
}