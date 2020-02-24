using NUnit.Framework;

namespace NUNIT_1
{
    [TestFixture]
    public class testClass
    {
        Calculator objc = new Calculator();
        [Test]
        public void Addtest()
        {
            Assert.AreEqual(20, objc.Add(10, 10));
            Assert.AreNotEqual(10, objc.Add(5, 5));
        }
        [Test]
        public void Subtest()
        {
            Assert.AreEqual(0, objc.Sub(10, 10));
        }
        [Test]
        public void Multest()
        {
            Assert.AreEqual(100, objc.Mul(10, 10));
        }
        [Test]
        public void Divtest()
        {
            Assert.AreEqual(1, objc.Div(10, 10));
        }
    }
}