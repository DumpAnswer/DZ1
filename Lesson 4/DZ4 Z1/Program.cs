using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4_Z1
{
    class Program
    {

        static void GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine($"{firstName} {lastName} {patronymic}");



        }
        static void Main(string[] args)
        {
            GetFullName("Алекс", "ДеАрман", "Аластаравич");
            GetFullName("Рионар", "Риндур", "Рикардович");
            GetFullName("Салем", "Темирен", "Тибальдович");
            GetFullName("Ирина", "Родина", "Михайловна");
            Console.ReadKey();

        }

    }
}   


