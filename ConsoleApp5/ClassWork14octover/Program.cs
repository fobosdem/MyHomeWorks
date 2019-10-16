using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ClassWork14octover
{
	class Program
	{
		static void Main(string[] args)
		{
			var workersFile = File.ReadAllLines("Workers.txt");
			var salaryFile = File.ReadAllLines("Salary.txt");

			List<Worker> workers = new List<Worker>();
			List<Salary> salaries = new List<Salary>();

			foreach (string worker in workersFile)
			{
				if (worker.Split(';').Any())
				{
					var info = worker.Split(';');
					int id = int.Parse(info[0]);
					string name = info[1];
					string education = info[2];
					string position = info[3];
					int year = int.Parse(info[4]);

					workers.Add(new Worker { ID = id, Name = name, Education = education, Postition = position, BirthYear = year });
				}
			}

			foreach (string salary in salaryFile)
			{
				if (salary.Split(';').Any())
				{
					var info = salary.Split(';');

					int id = int.Parse(info[0]);
					int firstHalf = int.Parse(info[1]);
					int secondHalf = int.Parse(info[2]);
					salaries.Add(new Salary { ID = id, FirstHalfSalary = firstHalf, SecondHalfSalary = secondHalf });
				}
			}



			Console.WriteLine("Workers who are older then 35");

			//Console.WriteLine(workers.Where(w => (2019 - w.BirthYear) > 35).Append((w1, w2) => w1.Name + "/n" + w2.Name));
			foreach (var worker in workers.Where(w => (2019 - w.BirthYear) > 35).ToList())
			{
				Console.WriteLine(worker.Name);
			}




			Console.WriteLine("The most saalry till second half of the year");
			//using orderBy
			Console.WriteLine(salaries.OrderBy(w => w.SecondHalfSalary).Select(w => w.ID).Last());
			//using Max() and Where()
			Console.WriteLine(salaries.Where(s => s.SecondHalfSalary == salaries.Max(sal => sal.SecondHalfSalary)).First().ID);




			Console.WriteLine("Workers whos salary is lower then midle");
			int salaryYear = salaries.Sum(w => w.FirstHalfSalary + w.SecondHalfSalary) / salaries.Count();

			foreach (var salary in salaries)
			{
				if (salaryYear > salary.FirstHalfSalary + salary.SecondHalfSalary)
				{
					Console.WriteLine(workers.Where(w => w.ID == salary.ID).Select(w => w.Name + " " + w.Education).Aggregate((w1, w2) => w1 + "\n" + w2));
				}
			}

			XmlDocument xmlDocument = new XmlDocument();
			foreach (var work in workers)
			{
				XmlElement worker = xmlDocument.CreateElement("Worker");
				worker.SetAttribute("Id", work.ID.ToString());
				XmlElement name = xmlDocument.CreateElement("Name");
				name.InnerText = work.Name;
				XmlElement education = xmlDocument.CreateElement("Education");
				name.InnerText = work.Education;
			}

			Console.ReadKey();
		}
	}
}
