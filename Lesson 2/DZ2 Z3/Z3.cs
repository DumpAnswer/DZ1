using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Z3
{
    class Z3
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите любое число:");
            a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine("Четное число");
                } 
                else                
                {
                    Console.WriteLine("Нечетное число");
                }
            Console.ReadKey();
        }
    }
}
