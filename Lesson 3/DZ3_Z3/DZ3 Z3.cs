using System;
using static System.Console;

namespace DZ3_Z3
{
	class MainClass
	{
		public static void Main(string[] args)



		{

			string say = "Hello";

			for (int i = say.Length - 1; i >= 0; i--)
			{
				Console.Write(say[i]);
				Console.ReadKey();


			}
		}
	}
}


