using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxOfThree
{
    public class MaxOfThree
    {
        public  int FindMax(int firstVal, int secondVal,int thirdVal)
        {
            if(firstVal.CompareTo(secondVal)>0&&firstVal.CompareTo(thirdVal)>0)
            {
                return firstVal;
            }
            else if(secondVal.CompareTo(firstVal)>0&& secondVal.CompareTo(thirdVal)>0)
            {
                return secondVal;
            }
            else
            {
                return thirdVal;
            }
        }
        public double FindMax(double firstVal, double secondVal, double thirdVal)
        {
            if (firstVal.CompareTo(secondVal) > 0 && firstVal.CompareTo(thirdVal) > 0)
            {
                return firstVal;
            }
            else if (secondVal.CompareTo(firstVal) > 0 && secondVal.CompareTo(thirdVal) > 0)
            {
                return secondVal;
            }
            else
            {
                return thirdVal;
            }
        }
        public string FindMax(string firstVal, string secondVal, string thirdVal)
        {
            if (firstVal.CompareTo(secondVal) > 0 && firstVal.CompareTo(thirdVal) > 0)
            {
                return firstVal;
            }
            else if (secondVal.CompareTo(firstVal) > 0 && secondVal.CompareTo(thirdVal) > 0)
            {
                return secondVal;
            }
            else
            {
                return thirdVal;
            }
        }
    }
}
