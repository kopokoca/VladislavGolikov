using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task5._2.Tests
{
    [TestClass]
    public class FilterTest
    {
        private List<int> list;
        private List<int> filter1;
        private List<int> filter2;

        [TestInitialize]
        public void Initialize()
        {
            list = new List<int> { 1, 6, 8, 7 };
        }

        [TestMethod]
        public void TestMethod1()
        {
            filter1 = new FilterClass<int>().Filter(list, x => x % 2 == 0);
            Assert.IsTrue(filter1[0] == 6 && filter1[1] == 8 && filter1.Count == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            filter2 = new FilterClass<int>().Filter(list, x => x % 3 == 1);
            Assert.IsTrue(filter2[0] == 1 && filter2[1] == 7 && filter2.Count == 2);
        }
    }
}
