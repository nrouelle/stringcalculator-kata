using NUnit.Framework;

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

        [Test]
        public void ShouldHandleAnUnknowAmountOfNumbers()
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Add("3,5,8"), 16);
            Assert.AreEqual(calculator.Add("3,5,2,3,4,5,5"), 27);
            Assert.AreEqual(calculator.Add("3,5,2,3,4,5,5,3,5,2,3,4,5,5"), 54);
        }

        [Test]
        public void ShouldHandleNewlineBetweenNumbers()
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Add("1\n2,3"), 6);
            Assert.AreEqual(calculator.Add("1,\n"), 1);
        }
    }
}
