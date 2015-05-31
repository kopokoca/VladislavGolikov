using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3_2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        HashTable hash = new HashTable();

        [TestMethod]
        public void AddAndDeleteElementTest()
        {
            hash.AddElementHashTable("a");
            Assert.IsTrue(hash.IsContains("a"));
            hash.RemoveElement("a");
            Assert.IsFalse(hash.IsContains("a"));
        }

        [TestMethod]
        public void DeleteElementTest2()
        {
            hash.AddElementHashTable("6");
            hash.AddElementHashTable("7");
            hash.AddElementHashTable("8");
            hash.RemoveElement("7");
            Assert.IsFalse(hash.IsContains("7"));
        }

        [TestMethod]
        public void AddUsingDelegateTest()
        {
            HashTable.Hashing hashDelegate = new HashTable.Hashing(HashFuncOfUser);
            hash = new HashTable(hashDelegate);
            AddAndDeleteElementTest();
        }

        [TestMethod]
        public void RemoveUsingDelegateTest()
        {
            HashTable.Hashing hashDelegate = new HashTable.Hashing(HashFuncOfUser);
            hash = new HashTable(hashDelegate);
            AddAndDeleteElementTest();
        }

        private int HashFuncOfUser(string value)
        {
            int result = 0;

            for (int i = 0; i < value.Length; i++)
            {
                result = (result + (i + 3) * value[i]) % hash.Length();
            }

            return result;
        }
    }
}
