using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxOfThree
{
    //generic class that extends IComparable interface
    public class MaxOfThree<T> where T: IComparable
    {
        public  static T  FindMax(T firstVal, T secondVal,T thirdVal)
        {
            if(firstVal.CompareTo(secondVal)>0 && firstVal.CompareTo(thirdVal)>0)
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
    }
}
