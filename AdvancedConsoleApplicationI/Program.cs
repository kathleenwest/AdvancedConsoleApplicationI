using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConsoleApplicationI
{
    /// <summary>
    /// AdvancedConsoleApplicationI: Demos the processing of events and extension methods
    /// </summary>
    class Program
    {
        // A list for holding Point type objects
        static PointList points = new PointList();

        /// <summary>
        /// Main method for the program for entry/start 
        /// </summary>
        /// <param name="args">No Input Parameters</param>
        static void Main(string[] args)
        {
            // Add a new anonoymous function to the event handler that will run
            // when the the Changed event is triggered.
            points.Changed += delegate (object sender, PointListChangedEventArgs e) 
            {
                // Event handler code here 
                Console.WriteLine($"Points changed: {e.Operation}");
            };

            // Test of Delegates
            points.Add(new Point(-4, -7));
            points.Add(new Point(0, 0));
            points.Add(new Point(1, 2));
            points.Add(new Point(-4, 5));
            points.Insert(2, new Point(3, 1));
            points.Add(new Point(7, -2));
            points[0] = new Point(2, 1);
            points.RemoveAt(2);

            // Functional Programming Any 
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Functional Programming Any");

            if (points.Any(pt => pt.X == 0 && pt.Y == 0))
            {
                Console.WriteLine("There exists points that are on the origin.");
            }
            else
            {
                Console.WriteLine("There are no points that are on the origin.");
            }

            // Functional Programming Where
            Console.WriteLine(new string('=',30));
            Console.WriteLine("Functional Programming Where");
            Console.WriteLine("These are the points in the first quadrant:");

            foreach (var pnt in points.Where(pt => pt.X > 0 && pt.Y > 0))
            {
                Console.WriteLine(pnt);
            }


            // Functional Programming Where
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Functional Programming All");
            Console.WriteLine("Are all the points in the list less than 100?");

            if (points.All(pt => pt.X < 100 && pt.Y < 100))
            {
                Console.WriteLine("Yes, all the points in the list are less than 100.");
            }
            else
            {
                Console.WriteLine("No, not all the points in the list are less than 100.");
            }

            // Wait for User Input to Terminate the Program
            Console.WriteLine("Press <ENTER> to quit...");
            Console.ReadLine();

        } // end of method
    } // end of class
} // end of namespace
