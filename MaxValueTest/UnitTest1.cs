using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxOfThree;

namespace MaxValueTest
{
    [TestClass]
    public class UnitTest1
    {
        MaxOfThree maxOfThree;

        public UnitTest1()
        {
            maxOfThree = new MaxOfThree();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int first = 80;
            int second = 56;
            int third = 21;
            int actual = maxOfThree.FindMax(first, second, third);
            int expected = first;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int first = 70;
            int second = 90;
            int third = 21;
            int actual = maxOfThree.FindMax(first, second, third);
            int expected = second;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int first = 80;
            int second = 56;
            int third = 100;
            int actual = maxOfThree.FindMax(first, second, third);
            int expected = third;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodFloat1()
        {
            double first = 11.3;
            double second = 5.6;
            double third = 2.1;
            double actual = maxOfThree.FindMax(first, second, third);
            double expected = first;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodFloat2()
        {
            double first = 8.0;
            double second = 53.6;
            double third = 2.1;
            double actual = maxOfThree.FindMax(first, second, third);
            double expected = first;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodFloat3()
        {
            double first = 8.0;
            double second = 5.6;
            double third = 12.1;
            double actual = maxOfThree.FindMax(first, second, third);
            double expected = first;
            expected.CompareTo(actual);
        }

        [TestMethod]
        public void TestMethodString1()
        {
            string first = "Apple";
            string second = "Peach";
            string third = "Banana";
            string actual = maxOfThree.FindMax(first, second, third);
            string expected = first;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodString2()
        {
            string first = "Peach";
            string second = "Apple";
            string third = "Banana";
            string actual = maxOfThree.FindMax(first, second, third);
            string expected = first;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodString3()
        {
            string first = "Banana";
            string second = "Peach";
            string third = "Apple";
            string actual = maxOfThree.FindMax(first, second, third);
            string expected = first;
            expected.CompareTo(actual);
        }

    }
}
