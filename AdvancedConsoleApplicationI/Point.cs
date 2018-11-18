using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConsoleApplicationI
{
    /// <summary>
    /// The Point object represents a cartesian coordinate 
    /// </summary>
    public class Point
    {
        // Auto Properties
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        /// <summary>
        /// Constructor to set the x and y coordinate values of a point
        /// </summary>
        /// <param name="x">x coordinate integer value for the point</param>
        /// <param name="y">y coordinate integer value of the point</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Overrises the output of a point object as a string
        /// </summary>
        /// <returns>(X,Y) format of a point</returns>
        public override string ToString()
        {
            return $"({X},{Y})";
        }  

    } // end of class
} // end of namespace
