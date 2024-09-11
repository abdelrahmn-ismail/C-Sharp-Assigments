using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Project
{
    internal class Math
    {
        #region Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters
        //public double Add(double x, double y) => x + y;
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return (x * y);
        }
        public static double Divide(double x, double y)
        {
            if (y != 0)
            {
                return (double)x / y;
            }
            else
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
        }
        #endregion
    }
}
