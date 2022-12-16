using Dll.Models;

#region Task 1

//Calculator adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur. Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq. 

Calculator calculator = new Calculator();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-----Welcome-----");

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Please enter first number:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter second number:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("What you want to do? Enter +, -, / or *");
string process = Console.ReadLine();

calculator.Calculation(number1, number2, process);

#endregion