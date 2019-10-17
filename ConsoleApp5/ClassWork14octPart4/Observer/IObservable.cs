using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork14octPart4.Observer
{
	public interface IObservable
	{
		void AddObserver(IObserver o, string vacancy);
		void RemoveObserver(IObserver o);
		void NotifyObservers(string vacancyName);
	}
}
