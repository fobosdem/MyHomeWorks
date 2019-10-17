using ClassWork14octPart4.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork14octPart4
{
	public class User : IObserver
	{
		public string Email { get; set; }
		public int Number { get; set; }
		public string InterestingVac = "";
		public User(string email, int number)
		{
			Email = email;
			Number = number;
		}
		public void AddInterestingVacancy(string vacancy)
		{
			InterestingVac = vacancy;
		}
		public void StopWatch()
		{
			InterestingVac = "";
		}

		public void SendEmail(string statusVac)
		{
			Console.WriteLine($"({Email} - {Number}) vacancy {InterestingVac} was {statusVac}");
		}
	}
}
