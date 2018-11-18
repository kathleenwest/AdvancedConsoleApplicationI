using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConsoleApplicationI
{
    /// <summary>
    /// The PointList class implements the IList interface
    /// to allow Add, Delete, Update, Insert, etc. operations
    /// on a custom list of Point type objects
    /// </summary>
    public class PointList : IList<Point>
    {
        //List of Point objects
        private List<Point> _Points = new List<Point>();

        // Custom Event Handler for any change to the list
        public event EventHandler<PointListChangedEventArgs> Changed;

        // Interface methods 
        // Some trigger the event Changed with a custom argument

        #region Interface Methods
        public Point this[int index]
        {
            get { return _Points[index]; }
            set { _Points[index] = value; Changed?.Invoke(this, new PointListChangedEventArgs(PointListChangedOperations.Update)); }
        }

        public int Count => _Points.Count;

        public bool IsReadOnly => ((IList<Point>)_Points).IsReadOnly;

        public void Add(Point item)
        {    
            _Points.Add(item);
            Changed?.Invoke(this, new PointListChangedEventArgs(PointListChangedOperations.Add)); 
        }

        public void Clear()
        {
            _Points.Clear();
            Changed?.Invoke(this, new PointListChangedEventArgs(PointListChangedOperations.Clear));
        }

        public bool Contains(Point item)
        {
            return _Points.Contains(item);
        }

        public void CopyTo(Point[] array, int arrayIndex)
        {
            _Points.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Point> GetEnumerator()
        {
            return _Points.GetEnumerator();
        }

        public int IndexOf(Point item)
        {
            return _Points.IndexOf(item);
        }

        public void Insert(int index, Point item)
        {
            _Points.Insert(index, item);
            Changed?.Invoke(this, new PointListChangedEventArgs(PointListChangedOperations.Insert));
        }

        public bool Remove(Point item)
        {
            bool success = _Points.Remove(item);
            if(success)
            {
                Changed?.Invoke(this, new PointListChangedEventArgs(PointListChangedOperations.Remove));
            }        
            return success;
        }

        public void RemoveAt(int index)
        {
            _Points.RemoveAt(index);
            Changed?.Invoke(this, new PointListChangedEventArgs(PointListChangedOperations.Remove));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Points.GetEnumerator();
        }

        #endregion Interface Methods

    } // end of class
} // end of namespace
