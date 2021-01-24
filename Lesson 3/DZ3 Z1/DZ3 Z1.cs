using System;

namespace Массивы
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[,] matrix = new int[5, 5];
			matrix[0, 0] = 1;
			matrix[1, 1] = 2;
			matrix[2, 2] = 3;
			matrix[3, 3] = 4;
			matrix[4, 4] = 5;

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					System.Console.Write($"{matrix[i, j]} ");
				}
				System.Console.WriteLine();

				Console.ReadKey();

			}
		}
	}
}


