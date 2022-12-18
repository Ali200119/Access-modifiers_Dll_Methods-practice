using Dll.Models;
using Service;

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

//bool check;
//string process;

//do
//{
//    Console.WriteLine("What you want to do? Enter +, -, / or *");
//    process = Console.ReadLine();

//    if (process != "+" && process != "-" && process != "/" && process != "*")
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please enter correct operator");
//        Console.ForegroundColor = ConsoleColor.White;
//        check = true;
//    }

//    else
//    {
//        check = false;
//    }
//} while (check);

//calculator.Calculation(number1, number2, process);

#endregion

#region Task 2

//Employee tipinden array olacaq. Employee clasinda name, surname, age, salary propertileri olmalidir. Maashi 1000 - 2000 arasinda olan employee-lerin melumatlarini ekranda gosteren method yazin. (1000 ve 2000 deyerleri methoda argument kimi gondermelidir).

//Employee employee1 = new Employee("Ali", "Talibov", 21, 2000);
//Employee employee2 = new Employee("Cavid", "Bashirov", 29, 4000);
//Employee employee3 = new Employee("Rustam", "Hacizade", 21, 2000);
//Employee employee4 = new Employee("Teymur", "Isayev", 22, 1500);
//Employee employee5 = new Employee("Josh", "Barker", 20, 800);
//Employee employee6 = new Employee("Penelope", "Meyer", 23, 1200);
//Employee employee7 = new Employee("Payton", "O'neill", 18, 600);

//Employee[] employees = { employee1, employee2, employee3, employee4, employee5, employee6, employee7 };

//Get(employees, 1000, 2000);

//static void Get(Employee[] employees, double salary1, double salary2)
//{
//    foreach (Employee employee in employees)
//    {
//        if (employee.Salary >= salary1 && employee.Salary <= salary2)
//        {
//            Console.WriteLine($"{employee.Name} {employee.Surname} {employee.Age} {employee.Salary}");
//        }
//    }
//}

#endregion

#region Task 3

//Doctor adinda class olacaq, Doctor clasinin name, surname, address, birthday propertileri olacaq. Dogum tarixi 25.05.1993 - 15.12.2002 arasinda olan doctor-larin siyahisini ekranda gosteren method yazin. (25.05.1993  ve 15.12.2002 deyerleri methoda argument kimi gonderilecek).

//Doctor doctor1 = new Doctor("Ali", "Talibov", "Baku", new DateTime(2001, 08, 19));
//Doctor doctor2 = new Doctor("Cavid", "Bahirov", "Baku", new DateTime(1993, 05, 25));
//Doctor doctor3 = new Doctor("Kael", "Molina", "New York", new DateTime(1967, 12, 05));
//Doctor doctor4 = new Doctor("Freya", "Lowe", "London", new DateTime(1980, 03, 15));
//Doctor doctor5 = new Doctor("Elin", "Jennings", "Berlin", new DateTime(1972, 09, 20));
//Doctor doctor6 = new Doctor("Anthony", "Lowe", "Shanghai", new DateTime(1990, 06, 24));

//Doctor[] doctors = { doctor1, doctor2, doctor3, doctor4, doctor5, doctor6 };

//Get(doctors, new DateTime(1993, 05, 25), new DateTime(2002, 12, 15));

//static void Get(Doctor[] doctors, DateTime date1, DateTime date2)
//{
//    foreach (Doctor doctor in doctors)
//    {
//        if (doctor.Birthday >= date1 && doctor.Birthday <= date2)
//        {
//            Console.WriteLine($"{doctor.Name} {doctor.Surname} {doctor.Address} {doctor.Birthday.ToString("dd/MM/yyyy")}");
//        }
//    }
//}

#endregion

#region Task 4

//Service adinda layer yaradirsiz. Onun icerisinde CustomMath classi yaradirsiz. Hemin clasin icinde ashagidaki methodlar olacaq. Methodlari esas projectde (program.cs -de cagirib istifade edin).
//     Faktorialin hesablanmasi.
//     Arrayin icindeki tek ededlerin sayinin tapilmasi.

//CustomMath customMath = new CustomMath();

//Console.WriteLine(customMath.Factorial(5));

//int[] array = { 1, 2, 3, 4, 7, 17, 20, 30, 78, 65 };

//Console.WriteLine(customMath.Count(array));

#endregion