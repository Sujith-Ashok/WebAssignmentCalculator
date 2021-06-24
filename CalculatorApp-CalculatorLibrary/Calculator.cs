using System;
namespace CalculatorApp_CalculatorLibrary
{
    public static class Calculator
    {
        //This method gets in two number to add and returns the addition value of those numbers.
        static public double add(double leftNumber, double rightNumber)
        {
            return leftNumber + rightNumber;
        }

        //This Method calculates difference between two number and returns the subtraction result.
        static public double sub(double leftNumber, double rightNumber)
        {
            return leftNumber - rightNumber;
        }

        //This method multiplies two numbers and returns the result.
        static public double multiply(double leftNumber, double rightNumber)
        {
            return leftNumber * rightNumber;
        }

        //Divide Method gets in two numbers and then checks if the rightNumber value is 0 or not.
        //If it is zero this method returns exception or returns the division result.
        static public double divide(double leftNumber, double rightNumber)
        {
            if (rightNumber != 0)
                return leftNumber / rightNumber;

            throw new DivideByZeroException("Cannot divide a number by zero");
        }


        //Similar to add method but this method gets in three number to perform addition.
        static public double addThree(double leftNumber, double rightNumber, double thirdNumber)
        {
            return leftNumber + rightNumber + thirdNumber;
        }

        //This method gets in three numbers to calculate difference between those values and returns the difference value
        static public double subThree(double leftNumber, double rightNumber, double thirdNumber)
        {
            return leftNumber - rightNumber - thirdNumber;
        }

        //Similar to multiply method, but 3 numbers can be passed in to perform multiplication.
        static public double multipleThree(double leftNumber, double rightNumber, double thirdNumber)
        {
            return leftNumber * rightNumber * thirdNumber;
        }
    }
}
