using System;

namespace Dz1z2
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; ///O(1)
            for (int i = 0; i < inputArray.Length; i++) /// O(n)
            {
                for (int j = 0; j < inputArray.Length; j++) ///O(n)
                {
                    for (int k = 0; k < inputArray.Length; k++)///O(n)
                    {
                        int y = 0;///O(n)

                        if (j != 0)///O(n)
                        {
                            y = k / j; ///O(n)
                        }

                        sum += inputArray[i] + i + k + j + y; ///O(n)
                    }
                }
            }

            return sum;///O(1)
        }
    }
}
