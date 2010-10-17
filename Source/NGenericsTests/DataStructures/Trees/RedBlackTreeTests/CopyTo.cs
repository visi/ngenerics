﻿using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.RedBlackTreeTests
{
    [TestFixture]
    public class CopyTo : RedBlackTreeTest
    {

        [Test]
        public void Simple()
        {
            var redBlackTree = GetTestTree(10);

            var array = new KeyValuePair<int, string>[10];
            redBlackTree.CopyTo(array, 0);

            var list = new List<KeyValuePair<int, string>>(array);

            for (var i = 0; i < 10; i++)
            {
                Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(i, i.ToString())));
            }

            Assert.AreEqual(list.Count, 10);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionNullArray()
        {
            var redBlackTree = GetTestTree(10);
            redBlackTree.CopyTo(null, 1);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionNotEnoughSpaceInTargetArray1()
        {
            var redBlackTree = GetTestTree(10);
            var array = new KeyValuePair<int, string>[9];
            redBlackTree.CopyTo(array, 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionNotEnoughSpaceInTargetArray2()
        {
            var redBlackTree = GetTestTree(10);
            var array = new KeyValuePair<int, string>[10];
            redBlackTree.CopyTo(array, 1);
        }

    }
}