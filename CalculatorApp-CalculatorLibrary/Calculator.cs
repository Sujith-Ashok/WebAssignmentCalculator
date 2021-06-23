using System;
namespace CalculatorApp_CalculatorLibrary
{
    public class Calculator
    {
       static public double add(double leftNumber, double rightNumber)
        {
            return leftNumber + rightNumber;
        }

        static public double sub(double leftNumber, double rightNumber)
        {
            return leftNumber - rightNumber;
        }

        static public double multiple(double leftNumber, double rightNumber)
        {
            return leftNumber * rightNumber;
        }

        static public double divide(double leftNumber, double rightNumber)
        {
            if (rightNumber > 0)
                return leftNumber / rightNumber;

            throw new DivideByZeroException("Cannot divide a number by zero");
        }

        static public double addThree(double leftNumber, double rightNumber, double thirdNumber)
        {
            return leftNumber + rightNumber + thirdNumber;
        }

        
    }
}
