using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zadacha_3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = "1 6 9 11 ";
            int[] array = {11, 6, 1, 9};
            Assert.AreEqual(result, Zadacha_3.Sort.BubbleSort(array, 4));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string result = "-6 -5 -5 0 1 7 ";
            int[] array = { -5, 0, 7, -6, -5, 1};
            Assert.AreEqual(result, Zadacha_3.Sort.BubbleSort(array, 6));
        }
    }
}
