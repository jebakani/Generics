using System;

namespace PrintGenericArray
{
    class Program
    {
        /// <summary>
        /// UC1- Printing different array without generic type
        /// UC2- Printing array using generic type method
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Printing array of different data type");
            PrintArray.ReadInput();
            Console.Read();
        }
    }
}
