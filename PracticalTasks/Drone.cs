using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTasks
{
    public class Drone : Flyable
    {
        private const double maxDistance = 1000;

        public Drone()
        {
            this.Speed = 50;
        }

        public override void FlyTo(Coordinate point)
        {
            double distance = CalculateDistance(this.CurrentPosition, point);
            if (distance > maxDistance)
            {
                Console.WriteLine($"Cannot fly drone to {point}, distance is beyond maximum of {maxDistance}");
                return;
            }

            Console.WriteLine($"A drone is flying to {point} at a speed of {this.Speed} km/h");
        }

        public override TimeSpan GetFlyTime(Coordinate point)
        {
            double distance = CalculateDistance(this.CurrentPosition, point);
            if (distance > maxDistance)
            {
                Console.WriteLine($"Cannot fly drone to {point}, distance is beyond maximum of {maxDistance}");
                return TimeSpan.Zero;
            }

            double time = distance / this.Speed;
            double hoverTime = distance / 10;

            return TimeSpan.FromHours(time) + TimeSpan.FromMinutes(hoverTime);
        }
    }
}
