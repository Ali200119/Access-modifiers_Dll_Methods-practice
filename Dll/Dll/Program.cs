using Dll.Models;

#region Task 1

//Calculator adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur. Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq. 

//Calculator calculator = new Calculator();

//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("----- Welcome -----\n");

//Console.ForegroundColor = ConsoleColor.White;

//Console.WriteLine("Please enter first number:");
//double number1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Please enter second number:");
//double number2 = double.Parse(Console.ReadLine());

//Console.WriteLine("What you want to do? Enter +, -, / or *");
//string process = Console.ReadLine();

//calculator.Calculation(number1, number2, process);

#endregion

#region Task 2

//Employee employee1 = new Employee("Ali", "Talibov", 21, 2000);
//Employee employee2 = new Employee("Cavid", "Bashirov", 29, 4000);
//Employee employee3 = new Employee("Rustam", "Hacizade", 21, 2000);
//Employee employee4 = new Employee("Teymur", "Isayev", 22, 1500);
//Employee employee5 = new Employee("Josh", "Barker", 20, 800);
//Employee employee6 = new Employee("Penelope", "Meyer", 23, 1200);
//Employee employee7 = new Employee("Payton", "O'neill", 18, 600);

//Employee[] employees = { employee1, employee2, employee3, employee4, employee5, employee6, employee7 };

//Salary(employees);

//static void Salary(Employee[] employees)
//{
//	foreach (Employee employee in employees)
//	{
//		if (employee.Salary >= 1000 && employee.Salary <= 2000)
//		{
//			Console.WriteLine($"{employee.Name} {employee.Surname} {employee.Age} {employee.Salary}");
//		}
//	}
//}

#endregion

#region Task 3

Doctor doctor1 = new Doctor("Ali", "Talibov", "Baku", new DateTime(2001, 08, 19));
Doctor doctor2 = new Doctor("Cavid", "Bahirov", "Baku", new DateTime(1993, 05, 25));
Doctor doctor3 = new Doctor("Kael", "Molina", "New York", new DateTime(1967, 12, 05));
Doctor doctor4 = new Doctor("Freya", "Lowe", "London", new DateTime(1980, 03, 15));
Doctor doctor5 = new Doctor("Elin", "Jennings", "Berlin", new DateTime(1972, 09, 20));
Doctor doctor6 = new Doctor("Anthony", "Lowe", "Shanghai", new DateTime(1990, 06, 24));

Doctor[] doctors = { doctor1, doctor2, doctor3, doctor4, doctor5, doctor6 };

Get(doctors);

static void Get(Doctor[] doctors)
{
    foreach (Doctor doctor in doctors)
    {
        if (doctor.Birthday >= new DateTime(1993, 05, 25) && doctor.Birthday <= new DateTime(2002, 12, 15))
        {
            Console.WriteLine($"{doctor.Name} {doctor.Surname} {doctor.Address} {doctor.Birthday.ToString("dd/MM/yyyy")}");
        }
    }
}

#endregion