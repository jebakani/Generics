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
    }
}
