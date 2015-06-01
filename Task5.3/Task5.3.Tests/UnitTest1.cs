using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task5._3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private List<int> list1;
        private List<int> list2;

        [TestInitialize]
        public void Initialize()
        {
            list1 = new List<int> { 6, 1, 9 };
            list2 = new List<int> { 1, 3, 3, 7 };
        }

        [TestMethod]
        public void TestMethod1()
        {
            int fold = new FoldClass<int>().Fold(list1, 3, (x, y) => x * y);
            Assert.AreEqual(fold, 3 * list1[0] * list1[1] * list1[2]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int fold = new FoldClass<int>().Fold(list2, 7, (x, y) => x * y);
            Assert.IsTrue(fold == 7 * list2[0] * list2[1] * list2[2] * list2[3]);
        }
    }
}
