using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_01
{
    internal class Range<T> where T : IComparable<T> // T Must impelement this IComparable interface 
    {
        public T Min { get; private set; }
        public T Max { get; private set; }

        public Range(T min, T max)
        {
            if(min.CompareTo(max) < 0)
            {
                throw new ArgumentException("Minimum value cannot be greater than Maximum value.");
            }
            this.Min = min;
            this.Max= max;
        }

        // Method to check if a value is within the range
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        // Method to get the length of the range (difference between max and min)
        public T Length()
        {
            dynamic max = Max;
            dynamic min = Min;
            return  max - min;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Range: [{Min}, {Max}]";
        }
    }
}
