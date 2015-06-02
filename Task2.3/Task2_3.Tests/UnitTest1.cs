using System;
using Task2_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashTest
{
    [TestClass]
    public class HashTests
    {
        private HashTable hash = new HashTable(31);

        [TestMethod]
        public void AddElementTest()
        {
            hash.AddToHashTable("qwerty");
            Assert.IsTrue(hash.IsContains("qwerty"));
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            hash.AddToHashTable("word");
            Assert.IsTrue(hash.IsContains("word"));
            hash.DeleteFromHashTable("word");
            Assert.IsFalse(hash.IsContains("word"));
        }

        [TestMethod]
        public void IsContainsTest()
        {
            hash.AddToHashTable("rapap");
            Assert.IsTrue(hash.IsContains("rapap"));
            Assert.IsFalse(hash.IsContains("rapapa"));
        }
    }
}
