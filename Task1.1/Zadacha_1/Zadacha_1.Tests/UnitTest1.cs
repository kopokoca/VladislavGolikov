using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zadacha_1.Tests
{
    [TestClass]
    public class Zadacha_1Test
    {
        [TestMethod]
        public void factorialTest1()
        {
            int result = 120;
            Assert.AreEqual(result, Zadacha_1.MySpace.Factorial(5));
        }

        [TestMethod]
        public void factorialTest2()
        {
            int result = 5040;
            Assert.AreEqual(result, Zadacha_1.MySpace.Factorial(7));
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void NegativeNumberTest()
        {
            MySpace.Factorial(-2);
        }
    }
}
