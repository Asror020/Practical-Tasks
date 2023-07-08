using PracticalTasks;

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