using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWithWords
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> wordList = new List<string>() { "can", "rat", "pet", "dog" };

			Console.WriteLine(String.Join(" ", wordList.Where(w => w.ToLower()[0] == 'c')));
			Console.ReadKey();
			
		}
	}
}
