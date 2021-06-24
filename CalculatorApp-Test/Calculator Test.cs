using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorApp_Test
{
    [TestClass]
    public class CalculatorTest
    {
        //Addition Test 1
        [TestMethod]
        [DataTestMethod]
        [DataRow(2, 3)]
        [TestCategory("Addition")]
        public void AdditionExample(double left, double right)
        {
            
            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
           
            Assert.AreEqual(5d, result);

        }

        //Addition Test 2
        [TestMethod]
        [DataTestMethod]
        [DataRow(-2, -3)]
        [TestCategory("Addition")]
        public void AddingOfTwoNegativeNumbers(double left, double right)
        {
         
            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.IsTrue(result < 0);

        }

        //Addition Test 3
        [TestMethod]
        [DataTestMethod]
        [DataRow(-2, 3)]
        [TestCategory("Addition")]
        public void AddingPositiveAndNegativeNumbers(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.AreEqual(1d, result);

        }

        //Addition Test 4
        [TestMethod]
        [DataTestMethod]
        [DataRow(-2, 2)]
        [TestCategory("Addition")]
        public void AddingOnePositiveAndOneNegativeEqualNumbersresultsInZero(double left, double right)
        {
          
            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.AreEqual(0, result);

        }

        //Addition Test 5
        [TestMethod]
        [DataTestMethod]
        [DataRow(-2, 5)]
        [TestCategory("Addition")]
        public void AddingBiggerPositiveNumberWithSmallerNegativeNumberGivesPositiveResult(double left, double right)
        {
           
            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.IsTrue(result > 0);

        }

        //Addition Test 6
        [TestMethod]
        [DataTestMethod]
        [DataRow(2, -5)]
        [TestCategory("Addition")]
        public void AddingBiggerNegativeNumberWithSmallerPositiveNumberGivesNegativeResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.IsTrue(result < 0);

        }

        //Addition Test 7
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

        //Addition Test 8
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

        //Addition Test 9
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



        //Addition Test 10
        [TestMethod]
        [DataTestMethod]
        [DataRow(0, 5)]
        [TestCategory("Addition")]
        public void AddingZeroToAnyNumberWillAlwaysGiveResultSameAsThatNumber(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.add(left, right);
            Assert.AreEqual(result, right);
        }




        //Subtraction Test 1
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 1)]
        [TestCategory("Subtraction")]
        public void SubtractionExample(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.AreEqual(2d, result);

        }

        //Subtraction Test 2
        [TestMethod]
        [DataTestMethod]
        [DataRow(-3, -1)]
        [TestCategory("Subtraction")]
        public void SubtractingTwoNegativeNumbers(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.AreEqual(-2d,result);

        }

        //Subtraction Test 3
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, -5)]
        [TestCategory("Subtraction")]
        public void SubtractingWithNegativeNumberOnRightSideMakesResultPositiveValue(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.IsTrue(result > 0);

        }


        //Subtraction Test 4
        [TestMethod]
        [DataTestMethod]
        [DataRow(-3, 5)]
        [TestCategory("Subtraction")]
        public void SubtractingWithNegativeNumberOnLeftSideMakesResultNegativeValue(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.IsTrue(result < 0);

        }


        //Subtraction Test 5
        [TestMethod]
        [DataTestMethod]
        [DataRow(5, 0)]
        [TestCategory("Subtraction")]
        public void SubtractingZeroFromAnyNumberWillAlwaysGiveResultSameAsThatNumber(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.AreEqual(result, left);
        }


        //Subtraction Test 6
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

        //Subtraction Test 7
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

        //Subtraction Test 8
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

        //Subtraction Test 9
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 2)]
        [TestCategory("Subtraction")]
        public void SubtractingTwoDoubleTypeNumberWillGiveDoubleTypeResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.sub(left, right);
            Assert.IsInstanceOfType(result, typeof(double));
        }


        //Subtraction Test 10
        [TestMethod]
        [DataTestMethod]
        [DataRow(8, 2, 1)]
        [TestCategory("Subtraction")]
        public void SubtractingMoreThanTwoNumbers(double left, double right, double thirdNum)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.subThree(left, right, thirdNum);
            Assert.AreEqual(5d, result);

        }


        //Multiplication Test 1
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 5)]
        [TestCategory("Multiplication")]
        public void MultiplicationExample(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.multiply(left, right);
            Assert.AreEqual(15d, result);

        }

        //Multiplication Test 2
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 50)]
        [TestCategory("Multiplication")]
        public void MultiplyingWithNumberEndingWithZeroWillGiveResultWithLastDigitAsZero(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.multiply(left, right);
            double lastDigit = result % 10;
            Assert.AreEqual(0d, lastDigit);

        }

        //Multiplication Test 3
        [TestMethod]
        [DataTestMethod]
        [DataRow(5, 2, 5)]
        [TestCategory("Multiplication")]
        public void MultiplyingMoreThanTwoNumbers(double left, double right, double thirdNum)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.multipleThree(left, right, thirdNum);
            Assert.AreEqual(50d, result);

        }

        //Multiplication Test 4
        [TestMethod]
        [DataTestMethod]
        [DataRow(-3, -5)]
        [TestCategory("Multiplication")]
        public void MultiplyingTwoNegativeNumberWillGivePositiveResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.multiply(left, right);
            Assert.IsTrue(result > 0);

        }

        //Multiplication Test 5
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, -5)]
        [TestCategory("Multiplication")]
        public void MultiplyingOnePositiveAndOneNegativeNumberWillGiveNegativeResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.multiply(left, right);
            Assert.IsTrue(result < 0);

        }

        //Multiplication Test 6
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 0)]
        [TestCategory("Multiplication")]
        public void MultiplyingZeroWithNumberWillGiveZeroAsResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.multiply(left, right);
            Assert.IsTrue(result == 0);

        }

        //Multiplication Test 7
        [TestMethod]
        [DataTestMethod]
        [DataRow(5, 2)]
        [TestCategory("Multiplication")]
        public void MultiplyingTwoDoubleTypeNumberWillGiveDoubleTypeResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.multiply(left, right);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        //Multiplication Test 8
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 5)]
        [TestCategory("Multiplication")]
        public void MultiplicationFollowsAssociativeProperty(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.multiply(left, right);
            double resultReverse = CalculatorApp_CalculatorLibrary.Calculator.multiply(left, right);
            Assert.AreEqual(result, resultReverse);
        }

        //Multiplication Test 9
        [TestMethod]
        [DataTestMethod]
        [DataRow(-3, -5)]
        [TestCategory("Multiplication")]
        public void MultiplicationFollowsAssociativePropertyWithNegativeNumbersToo(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.multiply(left, right);
            double resultReverse = CalculatorApp_CalculatorLibrary.Calculator.multiply(left, right);
            Assert.AreEqual(result, resultReverse);
        }

        //Multiplication Test 10
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 5, 5)]
        [TestCategory("Multiplication")]
        public void MultiplicationWillFollowAssociativePropertyEvenWithMoreThanTwoNumbers(double left, double right, double thirdNum)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.multipleThree(left, right, thirdNum);
            double result2 = CalculatorApp_CalculatorLibrary.Calculator.multipleThree(left, thirdNum, right);
            double result3 = CalculatorApp_CalculatorLibrary.Calculator.multipleThree(thirdNum, left, right);
            Assert.AreEqual(result, result2);
            Assert.AreEqual(result, result3);
            Assert.AreEqual(result2, result3);
        }

        //Division Test 1
        [TestMethod]
        [DataTestMethod]
        [DataRow(15, 5)]
        [TestCategory("Division")]
        public void DivisionExample(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            Assert.AreEqual(3d, result);

        }

        //Division Test 2
        [TestMethod]
        [DataTestMethod]
        [DataRow(-15, -5)]
        [TestCategory("Division")]
        public void DividingTwoNegativeNumberWillGivePositiveResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            Assert.IsTrue(result > 0);

        }

        //Division Test 3
        [TestMethod]
        [DataTestMethod]
        [DataRow(-15, 5)]
        [TestCategory("Division")]
        public void DividingWithNegativeNumberOnLeftSideWillGiveNegativeResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            Assert.IsTrue(result < 0);

        }

        //Division Test 4
        [TestMethod]
        [DataTestMethod]
        [DataRow(15,-5)]
        [TestCategory("Division")]
        public void DividingWithNegativeNumberOnRightSideWillGiveNegativeResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            Assert.IsTrue(result < 0);

        }

        //Division Test 5
        [TestMethod]
        [DataTestMethod]
        [DataRow(5, 2)]
        [TestCategory("Division")]
        public void DividingTwoDoubleTypeNumberWillGiveDoubleTypeResult(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        //Division Test 6
        [TestMethod]
        [DataTestMethod]
        [DataRow(5, 0)]
        [TestCategory("Division")]
        public void DividingWithZeroOnRightSideWillThrowException(double left, double right)
        {
            Assert.ThrowsException<DivideByZeroException>(()=> CalculatorApp_CalculatorLibrary.Calculator.divide(left, right));
        }

        //Division Test 7
        [TestMethod]
        [DataTestMethod]
        [DataRow(0, 5)]
        [TestCategory("Division")]
        public void DividingWithZeroOnLeftSideWillZeroAsResult(double left, double right)
        {
            double result = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            Assert.IsTrue(result == 0);
        }

        //Division Test 8
        [TestMethod]
        [DataTestMethod]
        [DataRow(20, 2)]
        [TestCategory("Division")]
        public void DivisionDontFollowAssociativeProperty(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            double resultReverse = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            Assert.AreNotSame(result, resultReverse);
        }

        //Division Test 9
        [TestMethod]
        [DataTestMethod]
        [DataRow(20, -2)]
        [TestCategory("Division")]
        public void DivisionDontFollowAssociativePropertyWithNegativeNumbersToo(double left, double right)
        {

            double result = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            double resultReverse = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            Assert.AreNotSame(result, resultReverse);
        }

        //Division Test 10
        [TestMethod]
        [DataTestMethod]
        [DataRow(5, 10)]
        [TestCategory("Division")]
        public void DividingWithBiggerNumberOnRightSideWillHaveResultBetweenZeroAndOne(double left, double right)
        {
            double result = CalculatorApp_CalculatorLibrary.Calculator.divide(left, right);
            Assert.IsTrue(result > 0);
            Assert.IsTrue(result < 1);
        }
    }
}
