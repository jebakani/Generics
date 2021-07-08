using System;

namespace FindMaxOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.1, 1.3, 5.6, 5.36, 6.2, 80.5, 1 };
            double actual = new MaxOfThree<double>(array).MaxMethod();
            char[] first = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            char maxChar = new MaxOfThree<char>(first).MaxMethod();
            int[] arrayint = { 10, 5, 100, 85, 96, 2, 1 };
            int maxInt = new MaxOfThree<int>(arrayint).MaxMethod();
        }
    }
}
