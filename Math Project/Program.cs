namespace Math_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Call Methods at Main Method

            // Create an instance of the Maths class
            //Math math = new Math();
            //Console.WriteLine(math.Add(2, 3));
            //Console.WriteLine(math.Subtract(2, 3));
            //Console.WriteLine(math.Multiply(2, 3));
            //Console.WriteLine(math.Divide(2, 3));

            #endregion

            #region Modify the program so that you do not have to create an instance of class to call the four methods.
            Console.WriteLine(Math.Add(2, 3));
            Console.WriteLine(Math.Subtract(2, 3));
            Console.WriteLine(Math.Multiply(2, 3));
            Console.WriteLine(Math.Divide(2, 0));
            #endregion
        }
    }
}
