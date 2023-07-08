using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTasks
{
    public interface IFlyable
    {
        /// <summary>
        /// Flyes to given coordinate
        /// </summary>
        /// <param name="point">The destination coordinate</param>
        void FlyTo(Coordinate point);

        /// <summary>
        /// Gets the time spent to go to the given coordinate
        /// </summary>
        /// <param name="point">The destination coordinate</param>
        /// <returns>Time spent to reach the coordinate</returns>
        TimeSpan GetFlyTime(Coordinate point);
    }
}
