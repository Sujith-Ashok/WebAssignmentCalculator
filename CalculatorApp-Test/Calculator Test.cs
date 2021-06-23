using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorApp_Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 3)]
        [TestCategory("Addition")]
        public void AdditionExample(double left, double right)
        {
            
            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.AreEqual(5d, result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-2, -3)]
        [TestCategory("Addition")]
        public void AddingOfTwoNegativeNumbers(double left, double right)
        {
         
            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.IsTrue(result < 0);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-2, 3)]
        [TestCategory("Addition")]
        public void AddingPositiveAndNegativeNumbers(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.AreEqual(1d, result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-2, 2)]
        [TestCategory("Addition")]
        public void AddingOnePositiveAndOneNegativeEqualNumbersresultsInZero(double left, double right)
        {
          
            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-2, 5)]
        [TestCategory("Addition")]
        public void AddingBiggerPositiveNumberWithSmallerNegativeNumberGivesPositiveResult(double left, double right)
        {
           
            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.IsTrue(result > 0);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(2, -5)]
        [TestCategory("Addition")]
        public void AddingBiggerNegativeNumberWithSmallerPositiveNumberGivesNegativeResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.IsTrue(result < 0);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 5)]
        [TestCategory("Addition")]
        public void AdditionFollowsAssociativeProperty(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            double resultReverse = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.AreEqual(result, resultReverse);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-2, -5)]
        [TestCategory("Addition")]
        public void AdditionFollowsAssociativePropertyWithNegativeNumbersToo(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            double resultReverse = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.AreEqual(result, resultReverse);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 5, 3)]
        [TestCategory("Addition")]
        public void AdditionWillFollowAssociativePropertyEvenWithMoreThanTwoNumbers(double left, double right, double thirdNum)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.addThree(left, right, thirdNum);
            double result2 = CalculatorApp_CalculatorLibrary.Calculator.addThree(left, thirdNum, right);
            double result3 = CalculatorApp_CalculatorLibrary.Calculator.addThree(thirdNum, left, right);
            Assert.AreEqual(result, result2);
            Assert.AreEqual(result, result3);
            Assert.AreEqual(result2, result3);
        }

        

        [TestMethod]
        [DataTestMethod]
        [DataRow(0, 5)]
        [TestCategory("Addition")]
        public void AddingZeroToAnyNumberWillAlwaysGiveResultSameAsThatNumber(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.AreEqual(result, right);
        }




        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 1)]
        [TestCategory("Subtraction")]
        public void SubtractionExample(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.AreEqual(2d, result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-3, -1)]
        [TestCategory("Subtraction")]
        public void SubtractingTwoNegativeNumbersWillGiveNegativeResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.IsTrue(result < 0);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(3, -5)]
        [TestCategory("Subtraction")]
        public void SubtractingWithNegativeNumberOnRightSideMakesResultPositiveValue(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.AreEqual(8d,result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-3, 5)]
        [TestCategory("Subtraction")]
        public void SubtractingWithNegativeNumberOnLeftSideMakesResultNegativeValue(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.AreEqual(-8d, result);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(5, 0)]
        [TestCategory("Subtraction")]
        public void SubtractingZeroFromAnyNumberWillAlwaysGiveResultSameAsThatNumber(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.AreEqual(result, left);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(5, 2)]
        [TestCategory("Subtraction")]
        public void SubtractionDontFollowAssociativeProperty(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            double resultReverse = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.AreNotSame(result, resultReverse);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-5, -2)]
        [TestCategory("Subtraction")]
        public void SubtractionDontFollowAssociativePropertyWithNegativeNumbersToo(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            double resultReverse = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.AreNotSame(result, resultReverse);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 5, 3)]
        [TestCategory("Subtraction")]
        public void SubtractionWillNotFollowAssociativePropertyWithMoreThanTwoNumbers(double left, double right, double thirdNum)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.subThree(left, right, thirdNum);
            double result2 = CalculatorApp_CalculatorLibrary.Calculator.subThree(left, thirdNum, right);
            double result3 = CalculatorApp_CalculatorLibrary.Calculator.subThree(thirdNum, left, right);
            Assert.AreNotSame(result, result2);
            Assert.AreNotSame(result, result3);
            Assert.AreNotSame(result2, result3);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-5, -2)]
        [TestCategory("Subtraction")]
        public void SubtractingTwoDoubleTypeNumberWillGiveDoubleTypeResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.IsInstanceOfType(result, typeof(double));
        }


        [TestMethod]
        [DataTestMethod]
        [DataRow(8, 2, 1)]
        [TestCategory("Subtraction")]
        public void SubtractingMoreThanTwoNumbers(double left, double right, double thirdNum)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.subThree(left, right, thirdNum);
            Assert.AreEqual(5d, result);

        }
    }
}
