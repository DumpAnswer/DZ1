using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какая самая высокая темепратура была сегодня ?");
            string MaxTemp = Console.ReadLine();
            int a = Convert.ToInt32(MaxTemp);
            Console.WriteLine("А какая самая низкая за сегодня? ");
            string MinTemp = Console.ReadLine();
            int b =  Convert.ToInt32(MinTemp);
            int MedTemp = (a + b) / 2;
            Console.WriteLine($"Тогда средняя температура за сегодня {MedTemp} градусов !");
            Console.ReadKey();
        }
    }
}
