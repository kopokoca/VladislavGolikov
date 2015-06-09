﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task4_2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private UniqueList list;

        [TestInitialize]
        public void Initialize()
        {
            list = new UniqueList();
        }

        [TestMethod]
        public void AddElementsTest()
        {
            list.AddListElement(5);
            Assert.IsTrue(list.IsContains(5));
            list.AddListElement(7);
            Assert.AreEqual(2, list.Count());
            Assert.IsTrue(list.IsContains(7));
        }

        [TestMethod]
        public void RemoveElementsTest()
        {
            list.AddListElement(4);
            list.AddListElement(3);
            list.AddListElement(5);
            Assert.AreEqual(3, list.Count());
            Assert.IsTrue(list.RemoveListElement(3));
            Assert.IsFalse(list.IsContains(3));
            Assert.IsTrue(list.IsContains(4));
            Assert.IsTrue(list.IsContains(5));
            Assert.IsTrue(list.RemoveListElement(5));
            Assert.AreEqual(1, list.Count());
            Assert.IsFalse(list.IsContains(5));
            Assert.IsTrue(list.IsContains(4));
            Assert.IsTrue(list.RemoveListElement(4));
            Assert.IsFalse(list.IsContains(4));
            Assert.AreEqual(0, list.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(RemoveNonexistentElementException))]
        public void RemoveElements()
        {
            list.AddListElement(4);
            list.RemoveListElement(5);
        }

        [TestMethod]
        [ExpectedException(typeof(AddExistentElementException))]
        public void AddElements()
        {
            list.AddListElement(4);
            list.AddListElement(4);
        }
    }
}
