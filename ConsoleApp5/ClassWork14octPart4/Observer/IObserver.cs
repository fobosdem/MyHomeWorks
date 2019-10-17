using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork14octPart4.Observer
{
	public interface IObserver
	{
		void StopWatch();
		void SendEmail(string status);
	}
}
