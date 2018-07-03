using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			string f = "555";
			Console.WriteLine(f);
			Console.ReadLine();
		}
		public static string FizzBuzz(int num)
		{
			if (num % 15 == 0)
			{
				return "FizzBuzz";
			}
			else if (num % 3 == 0)
			{
				return "Fizz";
			}
			else if (num % 5 == 0)
			{
				return "Buzz";
			}
			else
			{
				return "False";
			}
		}
	}
}
