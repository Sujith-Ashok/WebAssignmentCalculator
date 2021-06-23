using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorApp_Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            double left = 1;
            double right = 2;
            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.AreEqual(3d, result);

        }

        [TestMethod]
        public void TestMethod2()
        {
        }
    }
}
