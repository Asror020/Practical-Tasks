using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTasks
{
    public abstract class Flyable : IFlyable
    {
        public int Speed { get; set; }

        public Coordinate CurrentPosition { get; set; }

        public abstract void FlyTo(Coordinate point);

        public virtual TimeSpan GetFlyTime(Coordinate point)
        {
            double distance = CalculateDistance(this.CurrentPosition, point);
            TimeSpan time = TimeSpan.FromHours(distance / this.Speed);
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
}
