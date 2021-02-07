 using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Process notepad = Process.Start("notepad");
            Process[] local = Process.GetProcessesByName("notepad");
            int i = local.Length;
            
            foreach(Process process in Process.GetProcesses())
            {
                Console.WriteLine($" ID : {process.Id} Name: {process.ProcessName}");

            }

            while(i > 0)
            {
                Console.WriteLine("Введите id процеса для его завершения :");
                string id = Console.ReadLine();
                if (string.IsNullOrEmpty(id))
                    break;

                try
                {
                    using (Process chosen = Process.GetProcessById(int.Parse(id)))
                    {
                        
                        if (chosen.Id ==  int.Parse(id))
                        {
                            chosen.Kill();
                            chosen.WaitForExit();
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверное значение");
                    continue;
                }
                
            }
        }
    }
}
