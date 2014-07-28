using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    
    
    /// <summary>
    ///这是 FindTest 的测试类，旨在
    ///包含所有 FindTest 单元测试
    ///</summary>
    [TestClass()]
    public class FindTest
    {

/// <summary>
        ///BinarySearch 的测试
        ///</summary>
        [TestMethod()]
        public void BinarySearchTest()
        {
            Find target = new Find(); 

            int[] a = new int[]{1,3,4,5,6,7,8,11,20,21};

            Assert.AreEqual(1, target.BinarySearch(a, a.Length, 3));
        }
    }
}
