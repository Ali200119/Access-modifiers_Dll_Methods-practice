using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Models
{
    public class Calculator
    {
        public void Calculation(int number1, int number2, string process)
        {
            int result;

            switch (process)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine($"Your answer is: {result}");
                    break;

                case "-":
                    result = number1 - number2;
                    Console.WriteLine($"Your answer is: {result}");
                    break;

                case "/":
                    result = number1 / number2;
                    Console.WriteLine($"Your answer is: {result}");
                    break;

                case "*":
                    result = number1 * number2;
                    Console.WriteLine($"Your answer is: {result}");
                    break;

                default:
                    Console.WriteLine("Please enter correct operator");
                    break;
            }
        }
    }
}
