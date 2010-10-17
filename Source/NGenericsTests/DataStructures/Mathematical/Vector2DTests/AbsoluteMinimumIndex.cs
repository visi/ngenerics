﻿using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.Vector2DTests
{
    [TestFixture]
    public class AbsoluteMinimumIndex
    {

        [Test]
        public void Simple()
        {
            var vector1 = new Vector2D(1, -4);

            Assert.AreEqual(0, vector1.AbsoluteMinimumIndex());

            Assert.AreEqual(1, vector1.X);
            Assert.AreEqual(-4, vector1.Y);


            var vector2 = new Vector2D(-4, 1);

            Assert.AreEqual(1, vector2.AbsoluteMinimumIndex());

            Assert.AreEqual(-4, vector2.X);
            Assert.AreEqual(1, vector2.Y);
        }

    }
}