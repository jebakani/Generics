using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintGenericArray
{
    class PrintArray
    {
        public static void ToPrintArray(int[] inputArray)
        {
            Console.WriteLine("======Printing Integer Array======");
            foreach(int i in inputArray)
            {
                Console.WriteLine(i);
            }
        }

        public static void ToPrintArray(double[] inputArray)
        {
            Console.WriteLine("======Printing double Array======");
            foreach (double i in inputArray)
            {
                Console.WriteLine(i);
            }
        }
        public static void ToPrintArray(char[] inputArray)
        {
            Console.WriteLine("======Printing character Array======");
            foreach (char i in inputArray)
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
