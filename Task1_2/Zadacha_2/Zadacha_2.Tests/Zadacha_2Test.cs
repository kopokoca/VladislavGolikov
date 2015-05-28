using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zadacha_2.Tests
{
    [TestClass]
    public class Zadacha_2Test
    {
        [TestMethod]
        public void fibTest1()
        {
            string result = "1 1 2 3 ";
            Assert.AreEqual(result, Zadacha_2.Fib.fib(4));
        }

        [TestMethod]
        public void fibTest2()
        {
            string result = "1 1 2 3 5 8 ";
            Assert.AreEqual(result, Zadacha_2.Fib.fib(6));
        }

        [TestMethod]
         [ExpectedException(typeof(NegativeNumberException))]
         public void NegativeNumberTest()
         {
             Fib.fib(-2);
         }
    }
}
