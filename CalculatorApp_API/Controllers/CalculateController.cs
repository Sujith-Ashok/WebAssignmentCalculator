using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorApp_CalculatorLibrary;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorApp_API.Controllers
{

    [ApiController]
    [Route("[Controller]/[action]")]
    public class CalculateController : ControllerBase
    {
        //All these four method uses calculator class in library project to perform mathematical tasks.

        //This method creates add action feature in the API screen,
        //two user entered numbers will be passed to perform addition and returns the result of it.
        [HttpGet]
        public double add(double leftNumber, double rightNumber)
        {
            return Calculator.add(leftNumber, rightNumber);
        }

        //This method creates subtract action feature in the API screen.
        //gets in two double variables to perform subtraction and returns the result value of it
        [HttpGet]
        public double subtract(double leftNumber, double rightNumber)
        {
            return Calculator.sub(leftNumber, rightNumber);
        }

        //This method creates multiply action feature in the API screen.
        //gets in two number to perform multiplication and returns the result value of it
        [HttpGet]
        public double multiply(double leftNumber, double rightNumber)
        {
            return Calculator.multiply(leftNumber, rightNumber);
        }

        //This method creates multiply action feature in the API screen.
        //this method calculates division of two numbers and returns its value.
        //But if the second number or rightNumber is 0, then it returns exception with 400 - bad entry status code response. 
        [HttpGet]
        public double divide(double leftNumber, double rightNumber)
        {
            double result = 0;
            try
            {
                result = Calculator.divide(leftNumber, rightNumber);
            }
            catch (DivideByZeroException)
            {
                Response.StatusCode = 400;
            }

            return result;
        }
    }
}
