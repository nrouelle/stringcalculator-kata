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
    }
}
