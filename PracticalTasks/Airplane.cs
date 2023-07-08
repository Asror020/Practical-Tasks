using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTasks
{
    public class Airplane : Flyable
    {
        private double initialSpeed = 200;

        public Airplane()
        {
            this.Speed = 200;
        }

        public override void FlyTo(Coordinate point)
        {
            double distance = CalculateDistance(this.CurrentPosition, point);

            Console.WriteLine($"An airplane started to fly to {point} at a speed of {this.Speed} km/h");

            while (distance > 10)
            {
                this.initialSpeed += 10;
                distance -= 10;
                Console.WriteLine($"Airplane increased its speed to {this.initialSpeed}");
            }
        }

        public override TimeSpan GetFlyTime(Coordinate point)
        {
            double speed = this.Speed;
            double distance = CalculateDistance(this.CurrentPosition, point);
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
}
