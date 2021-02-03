using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ5_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "Dz1.txt";
            Console.WriteLine("Введите любой текст !");
            string afile = Console.ReadLine();
            File.WriteAllText(filename, afile);

        }
    }
}
