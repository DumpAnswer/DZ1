using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ5_z2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename, time;
            filename = "startup.txt";
            time = Convert.ToString(DateTime.Now);
            File.WriteAllText(filename, time);
        }
    }
}
