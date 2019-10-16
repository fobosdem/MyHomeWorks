using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassWork14octobPart2
{
	class Program
	{
		static void Main(string[] args)
		{
			XElement xmlDoc = XElement.Load("PurchaseOrder.xml");
			int price = 100;

			foreach (var item in xmlDoc.Descendants("Item").Select(i => new { PartNumber = i.Attribute("PartNumber") }))
			{
				Console.WriteLine(item.PartNumber.Value);
			}

			Console.WriteLine($"PartNumbers with price greater then {price}");
			foreach (var item in xmlDoc.Descendants("Item")
				.Select(i => new { PartNumber = i.Attribute("PartNumber"), Price = i.Element("USPrice") })
				.Where(i => (double)i.Price > price)
				.OrderBy(i => i.PartNumber.Value))
			{
				Console.WriteLine(item.PartNumber.Value);
			}

			Console.ReadKey();

		}
	}
}
