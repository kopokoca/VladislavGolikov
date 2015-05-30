using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackCalculator.Tests
{
    [TestClass]
    public class StackCalcTests
    {
        private ArrayStack<int> arrayStack = new ArrayStack<int>(1);
        private ListStack<int> listStack = new ListStack<int>();
        private StackCalculator calculator = new StackCalculator();

        [TestMethod]
        public void ListStackTest()
        {
            Assert.AreEqual(calculator.StackCalc(listStack, "1 2 +"), 3);
            Assert.AreEqual(calculator.StackCalc(listStack, "2 1 -"), 1);
            Assert.AreEqual(calculator.StackCalc(listStack, "2 1 /"), 2);
            Assert.AreEqual(calculator.StackCalc(listStack, "3 1 *"), 3);
            Assert.AreEqual(calculator.StackCalc(listStack, "4 2 / 2 3 + +"), 7);
        }

        [TestMethod]
        public void ArrayStackTest()
        {
            Assert.AreEqual(calculator.StackCalc(arrayStack, "1 2 +"), 3);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "2 1 -"), 1);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "2 1 /"), 2);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "3 1 *"), 3);
            Assert.AreEqual(calculator.StackCalc(arrayStack, "4 2 / 2 3 + +"), 7);
        }
    }
}
