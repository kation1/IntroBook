using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwithcaseNumber
{
	class Program
	{
		static void Translate()
		{
			Console.WriteLine("Choose a Langauge English or Spanish");
			String language = Console.ReadLine();


			if (language == "English")
			{
				Console.WriteLine("Type a number 0 - 9:");
				int number = Convert.ToInt32(Console.ReadLine());

				switch (number)
				{
					case 1: Console.WriteLine("One"); break;
					case 2: Console.WriteLine("Two"); break;
					case 3: Console.WriteLine("Three"); break;
					case 4: Console.WriteLine("Four"); break;
					case 5: Console.WriteLine("Five"); break;
					case 6: Console.WriteLine("Six"); break;
					case 7: Console.WriteLine("Seven"); break;
					case 8: Console.WriteLine("Eight"); break;
					case 9: Console.WriteLine("Nine"); break;
					case 0: Console.WriteLine("zero"); break;
					default: Console.WriteLine("I didn't plan this far"); break;

				}
				Translate();
			}
			else if (language == "Spanish")
			{
				Console.WriteLine("Type a number 0 - 9:");
				int number = Convert.ToInt32(Console.ReadLine());

				switch (number)
				{
					case 1: Console.WriteLine("Uno"); break;
					case 2: Console.WriteLine("Dos"); break;
					case 3: Console.WriteLine("Tres"); break;
					case 4: Console.WriteLine("cuatro"); break;
					case 5: Console.WriteLine("cinco"); break;
					case 6: Console.WriteLine("seis"); break;
					case 7: Console.WriteLine("siete"); break;
					case 8: Console.WriteLine("ocho"); break;
					case 9: Console.WriteLine("Nueve"); break;
					case 0: Console.WriteLine("cero"); break;
					default: Console.WriteLine("I didn't plan this far"); break;
				}
				Translate();

			}
			else

			Console.WriteLine("Your entry was bad, try again.");
			Translate();

		}
		static void Main(string[] args)
		{
			Translate();

		}
		
	}
}


