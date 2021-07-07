using System;

namespace PrintGenericArray
{
    class Program
    {
        /// <summary>
        /// UC1- Printing different array without generic type
        /// UC2- Printing array using generic type method
        /// UC3- Printig Array using generic class
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Printing array of different data type");
            int[] intArray = { 10, 5, 100, 85, 96, 2, 1 };
            double[] doubleArray = { 1.1, 1.3, 5.6, 5.36, 6.2, 80.5, 1 };
            char[] charArray = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            new PrintArray<int>(intArray).ToPrintArray();
            new PrintArray<double>(doubleArray).ToPrintArray();
            new PrintArray<char>(charArray).ToPrintArray();
            Console.Read();
        }
    }
}
