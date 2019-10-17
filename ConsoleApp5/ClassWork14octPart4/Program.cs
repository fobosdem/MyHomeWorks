using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork14octPart4
{
	class Program
	{
		static void Main(string[] args)
		{
			SystemWorker system = new SystemWorker();

			User user1 = new User("11111@gmail.com", 11111);
			User user2 = new User("11111@gmail.com", 22222);
			User user3 = new User("11111@gmail.com", 33333);
			User user4 = new User("11111@gmail.com", 44444);

			system.AddVacancy(new Vacancy("C# Developer"));
			system.AddVacancy(new Vacancy("JS Developer"));
			system.AddVacancy(new Vacancy("Python Developer"));
			system.AddVacancy(new Vacancy("Recruiter"));

			system.AddObserver(user1, "JS Developer");

			Vacancy jsvac = new Vacancy("JS Developer");

			system.NotifyObservers("JS Developer");


			system.NotifyObservers("JS Developer");

			Console.ReadKey();
		}
	}
}
