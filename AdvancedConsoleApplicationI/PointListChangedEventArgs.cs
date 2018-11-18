using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConsoleApplicationI
{
    /// <summary>
    /// The PointListChangedEventArgs inherits from the EventArgs
    /// to create a custom event arguments with additional 
    /// identifying information for the category of event operation
    /// example: add, update, insert, remove, etc.. 
    /// </summary>
    public class PointListChangedEventArgs : EventArgs
    {
        // The property to hold the custom operation type for the argument
        // to better identify the event with a custom parameter
        public PointListChangedOperations Operation { get; set; } = PointListChangedOperations.Unknown;

        /// <summary>
        /// The constructor builds a custom PointListChangedEventArgs object with a specific 
        /// operation input type. This is a custom EventArgs type object.
        /// </summary>
        /// <param name="operation">a PointListChangedOperations Type input is expected</param>
        public PointListChangedEventArgs(PointListChangedOperations operation)
        {
            Operation = operation;
        } // end of method

    } // end of class
} // end of namespace
