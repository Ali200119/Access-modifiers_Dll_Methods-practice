using System;
namespace Dll.Models
{
	public class Employee
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public double Salary { get; set; }

		public Employee(string name, string surname, int age, double salary)
		{
			Name = name;
			Surname = surname;
			Age = age;
			Salary = salary;
		}
	}
}

