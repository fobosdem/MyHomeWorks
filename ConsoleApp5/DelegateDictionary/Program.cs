using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDictionary
{
	class Program
	{
		delegate double MathOperations(double a, double b);
		static void Main(string[] args)
		{
			Dictionary<string, MathOperations> delegateDictionary = new Dictionary<string, MathOperations>()
			{
				{ "triangle", TrianglSqr },
				{ "circle", CircleLength },
				{ "sqare", SqreSqre },
				{ "rectangle", SqreSqre }
			};

			string figure = "Triangle";
			Console.WriteLine(figure);
			Console.WriteLine(delegateDictionary[figure.ToLower()](5, 10));

			figure = "Circle";
			Console.WriteLine(figure);
			Console.WriteLine(delegateDictionary[figure.ToLower()](5, 3.14));


			figure = "Sqare";
			Console.WriteLine(figure);
			Console.WriteLine(delegateDictionary[figure.ToLower()](2, 2));


			Console.ReadKey();
		}

		public static double TrianglSqr(double a, double b)
		{
			return 0.5 * a * b;
		}

		public static double CircleLength(double a, double b = 3.14)
		{
			return 2 * b * a;
		}
		public static double SqreSqre(double a, double b)
		{
			return a * b;
		}
	}
}
