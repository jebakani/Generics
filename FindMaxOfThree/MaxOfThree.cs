﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxOfThree
{
    //generic class that extends IComparable interface
    public class MaxOfThree<T> where T: IComparable
    {
        public T[] array;

        public MaxOfThree(T[] array)
        {
            this.array = array;
        }

        public T[] SortArray(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T FindMaxElement( T[] value)
        {
            T[] sortedValues = SortArray(value);
            return sortedValues[sortedValues.Length - 1];
        }

        public T MaxMethod()
        {
            T max = FindMaxElement(this.array);
            return max;
        }
    }
}
