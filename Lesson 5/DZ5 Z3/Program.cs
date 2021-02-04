using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ5_Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел от 0 до 255");
            StreamWriter numbers = new StreamWriter("Числа255.txt");
            byte b = Convert.ToByte(Console.ReadLine());
            Random rnd = new Random();
            byte[] A = new byte[b];
            for(byte i = 0; i < b; i++)
            {
                A[i] = (byte)rnd.Next(0,255);
                Console.WriteLine("\b{0}", A[i]);
                    numbers.Write(A[i] + " ");
            }
            numbers.Close();

            Console.ReadKey();
        }
    }
}