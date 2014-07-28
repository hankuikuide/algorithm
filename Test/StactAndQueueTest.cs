using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    
    
    /// <summary>
    ///这是 StactAndQueueTest 的测试类，旨在
    ///包含所有 StactAndQueueTest 单元测试
    ///</summary>
    [TestClass()]
    public class StactAndQueueTest
    {

        [TestMethod()]
        public void Push_Push_Pop_Pop_Test()
        {
            StactAndQueue target = new StactAndQueue();
            target.Push(1);
            target.Push(2);

            Assert.AreEqual(1, target.Pop());
            Assert.AreEqual(2, target.Pop());
        }


        [TestMethod()]
        public void Push_Push_Pop_Push_Pop_Test()
        {
            StactAndQueue target = new StactAndQueue();
            target.Push(1);
            target.Push(2);
            Assert.AreEqual(1, target.Pop());
            target.Push(3);
            Assert.AreEqual(2, target.Pop());
        }
    }
}
