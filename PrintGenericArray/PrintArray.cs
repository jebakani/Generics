using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintGenericArray
{
    class PrintArray
    {
        //Printing the array using generic type T
        public static void ToPrintArray<T>(T[] inputArray)
        {
            Console.WriteLine("======Printing Array======");
            foreach(var i in inputArray)
            {
                Console.WriteLine(i);
            }
        }

      
        public static void ReadInput()
        {
            int[] intArray = { 10, 5, 100, 85, 96, 2, 1 };
            double[] doubleArray = { 1.1, 1.3, 5.6, 5.36, 6.2, 80.5, 1 };
            char[] charArray = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            ToPrintArray(intArray);
            ToPrintArray(doubleArray);
            ToPrintArray(charArray);
        }
    }
}
