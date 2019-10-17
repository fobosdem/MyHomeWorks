using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork14octPart4
{
	public class Vacancy
	{
		public string Name { get; set; }
		public bool Status { get; private set; }

		public Vacancy(string name, bool status = false)
		{
			Name = name;
			Status = status;
		}

		public void ChangeStatus()
		{
			Status = !Status;
		}
	}
}
