using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    internal class CalculatorTest
    {
        [Test]
        public void Add_ShouldReturn5_WhenInput5()
        {
            Calculator cal = new Calculator();
            cal.Add(5);
            Assert.AreEqual(5, cal.Current);
        }
    }
}