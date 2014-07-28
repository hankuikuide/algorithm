using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Find
    {
        public int BinarySearch(int[] a, int length, int value)
        {
            int start = 0;
            int end = length - 1;
            int index = -1;

            while (start<=end)
            {
                index = (start + end) / 2;
                if (a[index]==value)
                {
                    return index;
                }
                else if(a[index]>value)
                {
                    end = index;
                }
                else
                {
                    start = index;
                }
            }
            return -1;
        }
    }
}
