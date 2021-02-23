using System;

namespace Dz3
{
    class Program
    {   

        public class TestCase
        {
            public int numberF { get; set; }

            public int Expected { get; set; }
        }

        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return a;
        }
        static int FibonachiRec(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                ;
                return 1 ;
            }
            else
            {
                return FibonachiRec(n - 1) + FibonachiRec(n - 2);
            }
        }

        static void Main(string[] args)
        {

            var testData = new TestCase[2];
            
            testData[0] = new TestCase()
            {
                numberF = 5,
                Expected = 3,

            };
            testData[1] = new TestCase()
            {
                numberF = 8,
                Expected = 21,
            };
            Console.WriteLine("Цикл");
            foreach (var testCase in testData)
                
            {
                var result = Fibonacci(testCase.numberF);
                Console.WriteLine($"Число фибоначи = {testCase.numberF} Ответ {result} Правельный ответ {testCase.Expected} ");

            }
            Console.WriteLine("Рекурсия");
            foreach (var testCase in testData)
            {
                var result = FibonachiRec(testCase.numberF);
                Console.WriteLine($"Число фибоначи = {testCase.numberF} Ответ {result} Правельный ответ {testCase.Expected} ");

            }

        }
    }
}
