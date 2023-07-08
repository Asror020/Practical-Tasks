using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTasks
{
    public class Bird : Flyable
    {
        public Bird()
        {
            Random random = new Random();
            this.Speed = random.Next() % 20 + 1;
        }

        public override void FlyTo(Coordinate point)
        {
            Console.WriteLine($"A bird is flying to {point} at a speed of {this.Speed} km/h");
        }
    }
}
