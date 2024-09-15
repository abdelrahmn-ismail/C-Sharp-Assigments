using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_03
{
    class Point3D : IComparable<Point3D>, ICloneable
    {
        #region Attributes
        private int x, y, z;
        #endregion

        #region Properties
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int Z { get { return z; } set { z = value; } }
        #endregion

        #region Constructors
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D(int x, int y) : this(x, y, 0)
        {
        }
        public Point3D(int x) : this(x, 0)
        {
        }
        public Point3D()
        {
        }
        public Point3D(Point3D point3D)  //copy constructor
        {
            X = point3D.X;
            Y = point3D.Y;
            Z = point3D.Z;
        }

        #endregion

        #region Static Function to Read from the User the Coordinates
        public static Point3D Create3DPoint()
        {
            int x, y, z;

            // Prompt for X value
            Console.WriteLine("Please Enter X Value: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for X: ");
            }

            // Prompt for Y value
            Console.WriteLine("Please Enter Y Value: ");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for Y: ");
            }

            // Prompt for Z value
            Console.WriteLine("Please Enter Z Value: ");
            while (!int.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for Z: ");
            }

            return new Point3D(x, y, z);
        }
        #endregion

        #region OverLoad Operators
        public static bool operator == (Point3D left, Point3D right)
        {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        }
        public static bool operator != (Point3D left, Point3D right)
        {
            // return !left.Equals(right);
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z;

        }
        public override bool Equals(object? obj)
        {
            Point3D p = (Point3D) obj;
            return x == p.X && y == p.Y && z == p.Z;
        }
        #endregion

        #region PrintArray
        public static void Print3DArray(Point3D[] points)
        {
            foreach (var point in points)
            {
                Console.WriteLine(point.ToString());
            }
        }
        #endregion

        #region Sort Array based on X & Y coordinates
        public static void SortPoints(Point3D[] points)
        {
            Array.Sort(points);
        }
        public int CompareTo(Point3D? other)  
        {
            if(x != other?.X)
            {
                return x.CompareTo(other?.x);
            }
            else
            {
                if (y != other?.Y)
                {
                    return y.CompareTo(other?.y);
                }
                else
                {
                    return z.CompareTo(other?.z);
                }
            }
        }
        #endregion

        #region 6. Implement IClonable interface to be able to clone the object.
        public object Clone()
        {
            return new Point3D(this);
        }
        #endregion

        public override string ToString()
        {
            return $"X: {x}, Y: {y}, Z: {z}";
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
