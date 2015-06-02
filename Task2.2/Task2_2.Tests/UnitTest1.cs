using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2_2;

namespace Task2_2
{
    [TestClass]
    public class ListTest
    {
        private List<int> list;

        [TestInitialize]
        public void Initialize()
        {
            list = new List<int>();
        }

        [TestMethod]
        public void InsertTest()
        {
            list.InsertAsHead(1);
            Assert.IsTrue(list.IsContains(1));
        }

        [TestMethod]
        public void DeleteTest()
        {
            list.InsertAsHead(1);
            list.DeleteByValue(1);
            Assert.IsFalse(list.IsContains(1));
        }

        [TestMethod]
        public void ContainmentTest()
        {
            list.InsertAsHead(1);
            Assert.IsTrue(list.IsContains(1));
            Assert.IsFalse(list.IsContains(10));
        }

        [TestMethod]
        public void SizeTest()
        {
            for (int i = 0; i < 5; i++)
                list.InsertAsHead(1);
            Assert.AreEqual(list.ListSize(), 5);
        }
    }
}
