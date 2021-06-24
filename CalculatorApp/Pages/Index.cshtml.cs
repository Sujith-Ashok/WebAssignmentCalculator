using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CalculatorApp_CalculatorLibrary;

namespace CalculatorApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public double result
        {
            get; set;
        }

        public bool ResultSet
        {
            get; protected set;

        } = false;

        public void OnGet()
        {

        }

        public void OnPost(double leftNumber, double rightNumber, string operation)
        {

            switch (operation)
            {
                case "add":
                    result = Calculator.add(leftNumber, rightNumber);
                    ResultSet = true;
                    break;
                case "sub":
                    result = Calculator.sub(leftNumber, rightNumber);
                    ResultSet = true;
                    break;
                case "mul":
                    result = Calculator.multiple(leftNumber, rightNumber)r;
                    ResultSet = true;
                    break;
                case "div":
                    result = Calculator.divide(leftNumber, rightNumber);
                    ResultSet = true;
                    break;
                default:
                    break;
            }
        }
    }
}
