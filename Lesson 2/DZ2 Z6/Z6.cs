using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Z6
{
    [Flags] 
    public enum Days
    {
        Понедельник = 0b_0000001,
        Вторник = 0b_0000010,
        Среда = 0b_0000100,
        Четверг = 0b_0001000,
        Пятница = 0b_0010000,
        Суббота = 0b_0100000,
        Воскресенье = 0b_1000000,
    }
    class Z6
    {// Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до воскресенья.

        static void Main(string[] args)
        {
            Days workFirsOffice = Days.Вторник | Days.Среда | Days.Четверг | Days.Пятница;
            
           Console.WriteLine($"Первый офис работает {workFirsOffice}");
            
            Days workSecondOffice = Days.Понедельник | Days.Вторник | Days.Среда | Days.Четверг | Days.Пятница | Days.Суббота | Days.Воскресенье;
            Console.WriteLine($"Второй офис работает {workSecondOffice}");

            Console.ReadKey();
        }
    }
}
