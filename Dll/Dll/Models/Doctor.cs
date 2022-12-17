using System;
namespace Dll.Models
{
	public class Doctor
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
		public DateTime Birthday { get; set; }

		public Doctor(string name, string surname, string address, DateTime birthday)
		{
			Name = name;
			Surname = surname;
			Address = address;
			Birthday = birthday;
		}
	}
}

