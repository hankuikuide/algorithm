using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{


    /// <summary>
    ///这是 SortTest 的测试类，旨在
    ///包含所有 SortTest 单元测试
    ///</summary>
    [TestClass()]
    public class SortTest
    {
        /// <summary>
        ///MergeArray 的测试
        ///</summary>
        [TestMethod()]
        public void MergeArrayTest()
        {
            Sort target = new Sort();
            int[] a = { 1, 2, 3, 4, 5, 7, 8 };
            int[] b = new int[9];
            b[0] = 6;
            b[1] = 7;

            target.MergeArray(a, 7, b, 2);

            Assert.AreEqual(b[0], 1);
            Assert.AreEqual(b[1], 2);
            Assert.AreEqual(b[2], 3);
            Assert.AreEqual(b[3], 4);
            Assert.AreEqual(b[4], 5);
            Assert.AreEqual(b[5], 6);
            Assert.AreEqual(b[6], 7);
            Assert.AreEqual(b[7], 7);
            Assert.AreEqual(b[8], 8);


        }

        /// <summary>
        ///Quick 的测试
        ///</summary>
        [TestMethod()]
        public void QuickTest()
        {
            Sort target = new Sort(); 
            int[] a = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 }; 
            int low = 0; 
            int high = a.Length-1;
            target.Quick(a, low, high);

            Assert.AreEqual(a[0], 0);
            Assert.AreEqual(a[1], 1);
            Assert.AreEqual(a[2], 2);
            Assert.AreEqual(a[3], 3);
            Assert.AreEqual(a[4], 4);
            Assert.AreEqual(a[5], 5);
            Assert.AreEqual(a[6], 6);
            Assert.AreEqual(a[7], 7);
            Assert.AreEqual(a[8], 8);
            Assert.AreEqual(a[9], 9);

        }
    }
}
