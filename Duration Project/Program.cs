namespace Duration_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define D1 by seconds
            Duration D1 = new Duration(50);  
            Console.WriteLine(D1.ToString());

            // Define D2 by hours, min, sec
            Duration D2 = new Duration(1,40, 15); 
            Console.WriteLine(D2.ToString());

            // Define D3
            Duration D3;
            #region Operator Overloading

            //// Additions Overloading Operator
            //D3 = D1 + D2;
            //Console.WriteLine(D3);

            //D3 = D1 + 30;
            //Console.WriteLine(D3);

            //D3 = 30 + D1;
            //Console.WriteLine(D3);

            //// ++ Increase
            //D3 = ++D1;
            //Console.WriteLine(D3);

            // ++ decrease
            //D3 = --D1;
            //Console.WriteLine(D3);

            //if (D1 > D2)
            //    Console.WriteLine("D1 is greater than D2");

            //if (D1 <= D2)
            //    Console.WriteLine("D1 is less than or equal to D2");

            //if (D1)
            //    Console.WriteLine("D1 has a positive duration");

            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj); // Converts Duration to DateTime

            #endregion
        }
    }
}
