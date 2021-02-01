using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_Z3
{
    class Program
    {
        public enum season
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
            

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Введи порядковый номер месяца ");
            int month = int.Parse(Console.ReadLine());
          switch (month)
            {
                case (int)season.January:
                    Console.WriteLine("Это зимний месяц");
                    break;
                case  (int)season.February:
                    Console.WriteLine("Это зимний месяц");
                    break;
                case (int)season.March:
                    Console.WriteLine("Это весенний месяц");
                    break;
                case (int)season.April:
                    Console.WriteLine("Это весенний месяц");
                    break;
                case (int)season.May:
                    Console.WriteLine("Это весенний месяц");
                    break;
                case (int)season.June:
                    Console.WriteLine("Это летний месяц");
                    break;
                case (int)season.July:
                    Console.WriteLine("Это летний месяц");
                    break;
                case (int)season.August:
                    Console.WriteLine("Это летний месяц");
                    break;
                case (int)season.September:
                    Console.WriteLine("Это осенний месяц");
                    break;
                case (int)season.October:
                    Console.WriteLine("Это осенний месяц");
                    break;
                case (int)season.November:
                    Console.WriteLine("Это осенний месяц");
                    break;
                case (int)season.December:
                    Console.WriteLine("Это зимний месяц");
                    break;
                default:
                    Console.WriteLine(" Ошибка! Введите число от 1 до 12");
                    break; 
            }
        }


    }
}

    
