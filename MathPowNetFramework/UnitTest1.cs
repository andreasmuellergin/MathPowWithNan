using NUnit.Framework;
using System;

namespace MathPowNetFrameworkTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsNaN(Math.Pow(1, double.NaN));
        }
    }
}