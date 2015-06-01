using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zadacha_6.Tests
{
    [TestClass]
    public class Zadacha_6Test
    {
        [TestMethod]
        public void SpiralTest1()
        {
            string result = "1 2 3 4 5 6 7 8 9";
            int[,] arrayTest = new int [3, 3];
            arrayTest[0, 0] = 7;
            arrayTest[0, 1] = 6;
            arrayTest[0, 2] = 5;
            arrayTest[1, 0] = 8;
            arrayTest[1, 1] = 1;
            arrayTest[1, 2] = 4;
            arrayTest[2, 0] = 9;
            arrayTest[2, 1] = 2;
            arrayTest[2, 2] = 3;
            Assert.AreEqual(result, Zadacha_6.Program.SpiralMethod(arrayTest, 3));
        }

        [TestMethod]
        public void SpiralTest2()
        {
            string result = "4 ";
            int[,] arrayTest = new int[1, 1];
            arrayTest[0, 0] = 4;
            Assert.AreEqual(result, Zadacha_6.Program.SpiralMethod(arrayTest, 1));
        }
    }
}
