using System;
using static System.Console;

namespace DZ3_Z3
{
	class MainClass
	{
		public static void Main(string[] args)



		{

			Console.WriteLine ("Напишите любое слово");
			
			string say = Console.ReadLine();
		
			

			for (int i = say.Length - 1; i >= 0; i--)
			{
				Console.Write(say[i]);
                Console.ReadKey();



			}
		}
	}
}


