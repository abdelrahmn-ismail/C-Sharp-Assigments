using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic Range<T> class
            //var intRange = new Range<int>(5, 15);
            //Console.WriteLine(intRange.IsInRange(10));  // Output: True
            //Console.WriteLine(intRange.IsInRange(20));  // Output: False
            //Console.WriteLine("Length of range: " + intRange.Length());  // Output: 10
            //Console.WriteLine(intRange);  // Output: Range: [5, 15]

            //var doubleRange = new Range<double>(1.5, 3.8);
            //Console.WriteLine(doubleRange.IsInRange(2.5));  // Output: True
            //Console.WriteLine("Length of range: " + doubleRange.Length());  // Output: 2.3
            #endregion

            #region ArrayList containing a sequence of elements
            ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            ReversArrayElements(arrayList);
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            #endregion
        }
        public static void ReversArrayElements(ArrayList list)
        {
            object[] tempArray = new object[list.Count];

            // Copy elements in reverse order into tempArray
            for (int i = 0; i < list.Count; i++)
            {
                tempArray[i] = list[list.Count - 1 - i];
            }

            // Copy elements back to the original ArrayList
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = tempArray[i];
            }
        }
    }
}
