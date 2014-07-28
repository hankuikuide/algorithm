using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Sort
    {
        //合并排序，将两个已经排序的数组合并成一个数组，其中一个数组能容下两个数组的所有元素
        //主要的思想是数据从后往前比较，如果从前向后，会很麻烦。
        public void MergeArray(int[] a, int lenA, int[] b, int lenB)
        {
            int len = lenB + lenA - 1;
            lenA--;
            lenB--;

            while (lenB >= 0 && lenA >= 0)
            {
                if (a[lenA] < b[lenB])
                {
                    b[len--] = b[lenB--];
                }
                else
                {
                    b[len--] = a[lenA--];
                }
            }
            while (lenA >= 0)
            {
                b[len--] = a[lenA--];
            }
        }

        public void Quick(int[] a, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int first = low;
            int last = high;
            int Key = a[first];
            while (first < last)
            {
                while (first < last && a[last] > Key) last--;
                a[first] = a[last];
                while (first < last && a[first] < Key) first++;
                a[last] = a[first];
            }
            a[first] = Key;
            Quick(a, low, Key - 1);
            Quick(a, Key + 1, high);
        }
    }
}
