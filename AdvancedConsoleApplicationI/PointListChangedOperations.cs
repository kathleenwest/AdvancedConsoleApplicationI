using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConsoleApplicationI
{
    /// <summary>
    /// Enumeration to describe the category of operation
    /// and additional identifying information for the
    /// custom event arguments PointListChangedEventArgs 
    /// that describe an event of that type
    /// </summary>
    public enum PointListChangedOperations
    {
        Unknown = 0,
        Add = 1,
        Remove = 2,
        Insert = 3,
        Clear = 4,
        Update = 5
    } // end of enum

} // end of namespace
