using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, как тебя зовут ? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет,{name}!Сегодня {DateTime.Today}");
            Console.ReadKey();
        }
    }
}
 