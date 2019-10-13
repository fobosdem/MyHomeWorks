using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	class Program
	{
		public class Company
		{
			public string Country { get; set; }
			public string Name { get; set; }
			public int Number { get; set; }
		}
		static void Main(string[] args)
		{
			Company company1 = new Company { Country = "Ukrain", Name = "AAA", Number = 0 };
			Company company2 = new Company { Country = "Ukrain", Name = "BBB", Number = 1 };
			Company company3 = new Company { Country = "USA", Name = "CCC", Number = 2 };
			Company company4 = new Company { Country = "GB", Name = "DDD", Number = 3 };
			Company company5 = new Company { Country = "Sweden", Name = "EEE", Number = 4 };

			List<Company> companies = new List<Company>
			{
				company1,
				company2,
				company3,
				company4,
				company5
			};

			foreach (var comp in companies.Where(comp => comp.Country.Equals("Sweden")).Select(comp => new { comp.Name, comp.Number }).ToArray())
				Console.WriteLine($"{comp.Name} {comp.Number}");

			var groupCompany = companies.GroupBy(comp => comp.Country).Select(c => new { Country = c.Key, Comp = c.Select(comp => comp) });
			foreach (var comp in groupCompany)
			{
				Console.WriteLine($"Companies of country: {comp.Country}:");
				foreach (var company in comp.Comp)
				{
					Console.WriteLine(company.Name + " " + company.Number);
				}
			}

			Console.ReadLine();
		}
	}
}
