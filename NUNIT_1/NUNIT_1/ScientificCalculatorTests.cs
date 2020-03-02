using NUnit.Framework;

namespace NUNIT_1
{
    [TestFixture]
    public class ScientificCalculatorTests
    {
        ScientificCalculator scientificCalculator = new ScientificCalculator();

        [Test]
        public void PowTest()
        {
            Assert.AreEqual(4, scientificCalculator.Pow(2, 2));
        }
        [Test]
        public void Percent()
        {
            Assert.AreEqual(150, scientificCalculator.Percent(100, 20));
        }
        [Test]
        public void ModTest()
        {
            Assert.AreEqual(100, scientificCalculator.Mod(10, 10));
        }
        [Test]
        public void SqrtTest()
        {
            Assert.AreEqual(1, scientificCalculator.Sqrt(10));
        }
    }
}
