using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Z2
{
    class Z2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текушего месяца:");
            string Month = Console.ReadLine();
            int a = Convert.ToInt32(Month);
            string NameMonth = "";
            switch (a)
            {
                case 1:
                    NameMonth = "Январь";
                    break;
                case 2:
                    NameMonth = "Февраль";
                    break;
                case 3:
                    NameMonth = "Март";
                    break;
                case 4:
                    NameMonth = "Апрель";
                    break;
                case 5:
                    NameMonth = "Май";
                    break;
                case 6:
                    NameMonth = "Июнь";
                    break;
                case 7:
                    NameMonth = "Июль";
                    break;
                case 8:
                    NameMonth = "Август";
                    break;
                case 9:
                    NameMonth = "Сентябрь";
                    break;
                case 10:
                    NameMonth = "Ноябрь";
                    break;
                case 11:
                    NameMonth = "Декабрь";
                    break;
                case 12:
                    NameMonth = "Воскресенье";
                    break;
            }

            Console.WriteLine(NameMonth);
            Console.ReadKey();
        }
    }
}
