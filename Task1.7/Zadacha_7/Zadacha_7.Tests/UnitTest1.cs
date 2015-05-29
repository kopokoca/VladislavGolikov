using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zadacha_7.Tests
{
    [TestClass]
    public class SelectionSortTest
    {
        [TestMethod]
        public void selectionSortTest1()
        {
            int[,] array = new int[1, 2];
            array[0, 0] = 2;
            array[0, 1] = -1;
            string result = "-1 2 ";
            Assert.AreEqual(result, Zadacha_7.Program.selectionSort(array, 1, 2));
        }

        [TestMethod]
        public void selectionSortTest2()
        {
            int[,] array = new int[2, 3];
            array[0, 0] = 2;
            array[0, 1] = -5;
            array[0, 2] = 0;
            array[1, 0] = 4;
            array[1, 1] = -5;
            array[1, 2] = 6;
            string result = "-5 0 2 -5 6 4 ";
            Assert.AreEqual(result, Zadacha_7.Program.selectionSort(array, 2, 3));
        }
    }
}
