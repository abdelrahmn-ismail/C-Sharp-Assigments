using Shap_Project.Interfaces;

namespace Shap_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Circle
            Circle circle = new Circle(5);
            circle.DisplayShapeInfo();

            // Create an instance of Rectangle
            Rectangle rectangle = new Rectangle(4, 6);
            rectangle.DisplayShapeInfo();
        }
    }
}
