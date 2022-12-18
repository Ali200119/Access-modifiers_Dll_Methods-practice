using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Models
{
    public class Calculator
    {
        public void Calculation(double number1, double number2, string process)
        {
            double result;

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
                    if (number2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't devide by zero");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine($"Your answer is: {result}");
                        break;
                    }

                case "*":
                    result = number1 * number2;
                    Console.WriteLine($"Your answer is: {result}");
                    break;

                default:
                    break;
            }
        }
    }
}
