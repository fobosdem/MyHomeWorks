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
			List<string> wordList = new List<string>() { "can", "cat", "cet", "dog" };

			Console.WriteLine(wordList.Where(w => w.ToLower().StartsWith("c")).Aggregate((word1, word2) => word1 + " " + word2));
			Console.ReadKey();
			
		}
	}
}
