using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task4_1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ParseTreeTest1()
        {
            var tree = ReadingFile.ReadFromFile("Solution1.txt");
            Assert.AreEqual(tree.PrintParseTree(), " + * 3 2 1");
            Assert.AreEqual(tree.CalculateTree(), 7);
        }

        [TestMethod]
        public void ParseTreeTest2()
        {
           var tree = ReadingFile.ReadFromFile("Solution2.txt");
            Assert.AreEqual(tree.PrintParseTree(), " - / 6 2 9");
            Assert.AreEqual(tree.CalculateTree(), -6);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFound))]
        public void FileNotFoundTest()
        {
           var tree = ReadingFile.ReadFromFile("Solution3.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZero))]
        public void DivideByZeroTest()
        {
           var tree = ReadingFile.ReadFromFile("Solution4.txt");
            tree.CalculateTree();
        }
    }
}
