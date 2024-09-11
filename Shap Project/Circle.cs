using Shap_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shap_Project
{
    internal class Circle : ICircle
    {
        // Props
        public double Radius { get; set; }
        public double Area 
        { 
            get => Math.Pow(Radius ,2);
        }

        // Constructor for Class
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Use Method From Parent Interface
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle, Radius: {Radius}, Area: {Area:F2}");
        }
    }
}
