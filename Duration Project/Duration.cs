using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duration_Project
{
    internal class Duration
    {
        #region Attributes
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int seconds)
        {
            Hours   = seconds / 3600;
            Minutes = (seconds % 3600) / 60;
            Seconds = seconds % 60;
        }
        #endregion

        #region Overrides Some Methods
        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }
        // Override Equals method for value comparison
        public override bool Equals(object? obj)
        {
            if(obj is Duration other)
            {
                return this.Hours == other.Hours && this.Minutes == other.Minutes && this.Seconds == other.Seconds;
            }
            return false;
        }
        // Override GetHashCode to ensure consistency with Equals
        public override int GetHashCode()
        {
            return (Hours, Minutes, Seconds).GetHashCode(); // Combines all three attributes
        }
        #endregion

        #region Helper Methods
        private int ToSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
        #endregion
        
        #region required Operators overloading

        #region Additions Operator
        // Addition 2 Classes
        public static Duration operator + (Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }
        // Addition Class + sec
        public static Duration operator + (Duration d1, int seconds)
        {
            Duration d2 = new Duration(seconds); // Create a new Duration using seconds
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }
        // Addition sec + Class
        public static Duration operator + (int seconds, Duration d1)
        {
            Duration d2 = new Duration(seconds); // Create a new Duration using seconds
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }
        #endregion

        #region Substraction Operator
        // Addition 2 Classes
        public static Duration operator - (Duration d1, Duration d2)
        {
            return new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
        }
        // Addition Class + sec
        public static Duration operator - (Duration d1, int seconds)
        {
            Duration d2 = new Duration(seconds); // Create a new Duration using seconds
            return new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
        }
        // Addition sec + Class
        public static Duration operator - (int seconds, Duration d1)
        {
            Duration d2 = new Duration(seconds); // Create a new Duration using seconds
            return new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
        }
        #endregion

        #region Increaments
        // Increment operator (++)
        public static Duration operator ++(Duration d)
        {
            // Add 1 minute (60 seconds)
            return d + 60;
        }
        // Decrement operator (--)
        public static Duration operator --(Duration d)
        {
            if(d.ToSeconds() < 60 )
            {
                // Return a Duration object representing 0 seconds
                return new Duration(0, 0, 0);
            }
            // Subtract 1 minute (60 seconds)
            return d - new Duration(60);
        }
        #endregion

        #region Comparison operators

        // Comparison operator >
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToSeconds() > d2.ToSeconds();
        }
        // Comparison operator <
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToSeconds() <  d2.ToSeconds();
        }

        // Comparison operator <=
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() <= d2.ToSeconds();
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() >= d2.ToSeconds();
        }
        #endregion

        #region Implicit conversion 
        public static implicit operator bool(Duration d)
        {
            return d.ToSeconds() > 0;
        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }
        #endregion


        #endregion

    }
}
