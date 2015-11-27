using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    internal class CalculatorTest
    {
        private Calculator cal;

        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnPositive_WhenInputPositive()
        {
            cal.Add(5);
            Assert.AreEqual(5, cal.Current);
        }

        [Test]
        public void Add_ShouldReturnMinus_WhenInputMinus()
        {
            cal.Add(-5);
            Assert.AreEqual(-5, cal.Current);
        }

        [Test]
        public void Add_ShouldReturnDecimal_WhenInputDecimal()
        {
            cal.Add((decimal)123.4567);
            Assert.AreEqual(123.4567, cal.Current);
        }

        [Test]
        public void Add_ShouldBeAccumulated_WhenCurrentHasValue()
        {
            cal.Current = 10;
            cal.Add(5);
            Assert.AreEqual(15, cal.Current);
        }

        [Test]
        public void Add_ShouldWork_WhenInputLargeNumber()
        {
            cal.Current = 10;
            cal.Add((decimal)987654321.12);
            Assert.AreEqual(987654331.12, cal.Current);
        }
    }
}