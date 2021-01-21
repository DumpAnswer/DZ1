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
            Console.WriteLine("Какая самая высокая темепратура была сегодня ?"); // Добавил еще решение  5 задачи сюда!
            string MaxTemp = Console.ReadLine();
            int a = Convert.ToInt32(MaxTemp);
            
            Console.WriteLine("А какая самая низкая за сегодня? ");
            string MinTemp = Console.ReadLine();
            int b = Convert.ToInt32(MinTemp);
            int MedTemp = (a + b) / 2;

            Console.WriteLine("Введите порядковый номер текушего месяца:");
            string Month = Console.ReadLine();
            int m = Convert.ToInt32(Month);
            string NameMonth = "";
            
            switch (m)
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
              if (MedTemp < 0)
              {

                Console.WriteLine("На улице то холодно");
              }
              else                
              {
                Console.WriteLine("Теплая погода");
              }
              
            Console.WriteLine(NameMonth);
            Console.ReadKey();
        }
    }
}
