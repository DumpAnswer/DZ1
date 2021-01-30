using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_Z2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел");
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                int n = int.Parse(words[i]);
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
