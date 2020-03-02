using NUnit.Framework;
using System;

namespace NUNIT_1
{
    [TestFixture, Description("Tests for extended version of calculator")]
    public class ScientificCalculatorTests
    {
        ScientificCalculator scientificCalculator = new ScientificCalculator();

        [SetUp]
        public void Init()
        {
            //Assert.That(4, Is.EqualTo(5));
        }

        [TestCase(5, 2, 2)]
        [TestCase(10, 5, 2)]
        [TestCase(4, 2, 2)]
        public void PowTest(int expected, int a, int b)
        {
            Assert.That(expected, Is.GreaterThan(4));
            Assert.AreEqual(expected, scientificCalculator.Pow(a, b));
        }

        [Retry(2)]
        [TestCase(1050, 100, 500)]
        public void Percent(double expected, double a, double b)
        {
            Assert.AreEqual(expected, scientificCalculator.Percent(a, b));
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

        [TestCase("Sin", "os")]
        [TestCase("Sin", "at")]
        public void SinOrCos(string expected1, string expected2)
        {
            StringAssert.Contains("Sin", expected1);
            StringAssert.EndsWith("os", expected2);
        }
    }
}
