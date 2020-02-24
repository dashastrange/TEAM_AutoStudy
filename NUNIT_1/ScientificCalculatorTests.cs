using NUnit.Framework;

namespace NUNIT_1
{
    [TestFixture]
    public class ScientificCalculatorTests
    {
        ScientificCalculator objc = new ScientificCalculator();

        [Test]
        public void PowTest()
        {
            Assert.AreEqual(4, objc.Pow(2, 2));
        }
        [Test]
        public void Percent()
        {
            Assert.AreEqual(150, objc.Percent(100, 20));
        }
        [Test]
        public void ModTest()
        {
            Assert.AreEqual(100, objc.Mod(10, 10));
        }
        [Test]
        public void SqrtTest()
        {
            Assert.AreEqual(1, objc.Sqrt(10));
        }
    }
}
