using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWithNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			List<int> listNumber = new List<int>();

			for (int i = 0; i < 10; i++)
			{
				listNumber.Add(rnd.Next(-10, 10));
			}

			var sortedList = listNumber.OrderBy(i => i);

			foreach (int numb in listNumber.OrderBy(i => i))
			{
				Console.WriteLine(numb);
			}

			Console.WriteLine("First + member: ");
			Console.WriteLine(listNumber.FirstOrDefault(n => n > 0));

			Console.WriteLine("First - member: ");
			Console.WriteLine(listNumber.FirstOrDefault(n => n < 0));

			Console.WriteLine("All %2 numbers: ");
			foreach (int number in listNumber.Where(n => n % 2 == 0).Distinct().OrderBy(n=>n))
			{
				Console.WriteLine(number);
			}

			Console.ReadKey();
		}
	}
}
