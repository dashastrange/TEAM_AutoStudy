using NUnit.Framework;

namespace NUNIT_1
{
    [TestFixture]
    public class CalculatorTests
    {
        readonly Calculator calculator = new Calculator();

        [Order(2)]
        [Test, Description("Adds two numbers")]
        public void Add()
        {
            int expected_calc_test1 = 20;
            int a1 = 10;
            int b1 = 11;
            int result_calc_test1 = a1 + b1;

            int expected_calc_test2 = 10;
            int a2 = 5;
            int b2 = 5;
            int result_calc_test2 = a2 + b2;

            Assert.AreEqual(expected_calc_test1, calculator.Add(a1, b1), "Expected equal to: " + expected_calc_test1
                + " but was: " + result_calc_test1 + " after additions of: " + a1 + " and " + b1);

            Assert.AreEqual(expected_calc_test2, calculator.Add(a2, b2), "Expected equal to: " + expected_calc_test2
                + " but was: " + result_calc_test2 + " after additions of: " + a2 + " and " + b2);
        }

        [Test, Description("Subtracts one number from another")]
        public void Subtract()
        {
            Assert.AreEqual(0, calculator.Sub(10, 10));
        }

        [Test, Description("Multiplicate two numbers")]
        public void Multiplicate()
        {
            Assert.AreEqual(100, calculator.Mul(10, 10));
        }

        [Order(5)]
        [Test, Description("Divide one number on another")]
        public void Divide()
        {
            Assert.AreEqual(1, calculator.Div(10, 10));
        }
    }
}