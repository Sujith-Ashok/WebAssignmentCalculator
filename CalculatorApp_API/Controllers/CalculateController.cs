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
        [HttpGet]
        public double add(double leftNumber, double rightNumber)
        {
            return Calculator.add(leftNumber, rightNumber);
        }

        [HttpGet]
        public double subtract(double leftNumber, double rightNumber)
        {
            return Calculator.sub(leftNumber, rightNumber);
        }

        [HttpGet]
        public double multiply(double leftNumber, double rightNumber)
        {
            return Calculator.multiply(leftNumber, rightNumber);
        }

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
