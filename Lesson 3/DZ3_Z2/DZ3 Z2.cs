using System;
using static System.Console;

namespace DZ3_Z2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string[,] PhoneDir = { { "Иван Иванов", "+79999043234" }, { "Сергей Сергеев", "+79865734354" }, { "Петр Петров", "+79684344455" }, { "Гена Генадьев", "+79865765436" } };

			for (int i = 0; i < PhoneDir.GetLength(0); i++)
			{
				for (int j = 0; j < PhoneDir.GetLength(1); j++)
				{
					Console.Write($"{PhoneDir[i, j]} ");
				}
				Console.WriteLine();
				Console.ReadKey();
			}


		}
	}
}


