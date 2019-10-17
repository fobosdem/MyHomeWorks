using ClassWork14octPart4.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork14octPart4
{
	public class SystemWorker : IObservable
	{
		private List<Vacancy> _vacancies;
		private List<IObserver> _observers;

		public SystemWorker()
		{
			_vacancies = new List<Vacancy>();
			_observers = new List<IObserver>();
		}

		public void AddVacancy(Vacancy vacancy)
		{
			_vacancies.Add(vacancy);
		}


		public void AddObserver(IObserver o, string vacancy)
		{
			if (_vacancies.Any(v => v.Name == vacancy))
			{
				User user = (User)o;
				user.AddInterestingVacancy(vacancy);
				_observers.Add(user);
			}
			else
			{
				Console.WriteLine("There is no such vacancy");
			}
		}

		public void RemoveObserver(IObserver o)
		{
			User user = (User)o;
			if (_observers.Contains(user))
			{
				_observers.Remove(user);
			}
			else
			{
				Console.WriteLine("There is no such observer");
			}
		}

		public void NotifyObservers(string vacancyName)
		{
			if (_vacancies.Any(v => v.Name == vacancyName))
			{
				_vacancies.Where(v => v.Name == vacancyName).First().ChangeStatus();
				foreach (User user in _observers)
				{
					if (user.InterestingVac.ToLower() == vacancyName.ToLower() && user.InterestingVac != "")
					{
						user.SendEmail(_vacancies.Where(v => v.Name == vacancyName).First().Status ? "opened" : "closed");
					}
				}
			}
		}
	}
}
