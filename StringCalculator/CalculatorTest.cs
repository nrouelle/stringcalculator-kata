﻿using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void EmptyStringShouldReturnZeroWhenAdd()
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Add(""), 0);
        }

        [Test]
        public void OneNumberStringShouldReturnNumberWhenAdd()
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Add("1"), 1);
            Assert.AreEqual(calculator.Add("3"), 3);
        }

        [Test]
        public void ShouldReturnSumWhenAddWithTwoNumbers()
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Add("1,2"), 3);
            Assert.AreEqual(calculator.Add("3,5"), 8);
        }
    }
}
