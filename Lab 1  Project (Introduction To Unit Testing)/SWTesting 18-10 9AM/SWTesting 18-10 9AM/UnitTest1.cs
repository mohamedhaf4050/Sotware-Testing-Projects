using NUnit.Framework;

namespace SWTesting_18_10_9AM
{
    public class Tests
    {

        [Test]
        public void testDivideMethodWithNumbersInMiddle()
        {
            double result = Calculator.divide(10, 5);
            Assert.AreEqual(2,result);
        }

        [Test]
        public void testDivideMethodWithZeros()
        {
            double result = Calculator.divide(0,0);
            Assert.AreEqual(double.NaN, result);
        }

        [Test]
        public void testDivideMethodWithNonZeroAndZero()
        {
            double result = Calculator.divide(2, 0);
            Assert.AreEqual(double.NaN, result);
        }



    }
}