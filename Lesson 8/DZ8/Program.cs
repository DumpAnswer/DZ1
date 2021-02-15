using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {

                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.WriteLine("Введите ваш возраст:");
                Properties.Settings.Default.Age = Console.ReadLine();
                Console.WriteLine("Введите свой род деятельности: ");
                Properties.Settings.Default.TypeActive = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.UserName;
            string age = Properties.Settings.Default.Age;
            string active = Properties.Settings.Default.TypeActive;
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{greeting}{userName} \n Возраст: {age} \n Род деятельности : {active} ");
        }
    }
}
