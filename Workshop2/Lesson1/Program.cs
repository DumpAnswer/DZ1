using System;

namespace Algorithm
{
    class Program
    {
        public class TestCase
        {
            public int InputaA { get; set; }
            public string Expected { get; set; }
        }


        static void Main(string[] args)
        {


            var testData = new TestCase[2];
            testData[0] = new TestCase()
            {
                InputaA = 10,
                Expected = "Не простое"

            };
            testData[1] = new TestCase()
            {
                InputaA = 5,
                Expected = "Простое"
            };

            foreach (var testCase in testData)
            {
                var result = Algorith(testCase.InputaA);
                var correct = result == testCase.Expected;
                Console.WriteLine($"n = {testCase.InputaA} Ответ {result} Правельный ответ {testCase.Expected} ");

            }



        }


        static string Algorith(int n)
        {

            var d = 0;
            var i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                i++;
            }

            if (d == 0)
            {
                return "Простое";

            }
            return "Не простое";




        }

    }
}
