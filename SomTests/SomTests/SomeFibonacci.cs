using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace SomTests
{
    public class SomeFibonacci
    {
        #region Fibonnacci

        public static BigInteger Fibonacci(BigInteger n)
        {
            
            
            BigInteger[,] start = new BigInteger[2, 2] {{1, 1}, {1, 0}};
            BigInteger[,] res = new BigInteger[2, 2] {{1, 1}, {1, 0}};
            BigInteger a, b, c, d;

            if (n == 0)
                return 0;
            for (int i = 1; i < n; i++)
            {
                a = res[0, 0] * start[0, 0] + res[0, 1] * start[1, 0];
                b = res[1, 0] * start[0, 0] + res[1, 1] * start[1, 0];
                c = res[0, 0] * start[0, 1] + res[0, 1] * start[1, 1];
                d = res[1, 0] * start[0, 1] + res[1, 1] * start[1, 1];
                
                res[0, 0] = a;
                res[1, 0] = b;
                res[0, 1] = c;
                res[1, 1] = d;
            }

            var find = res[0, 1];
            
            
            return find;
        }

        #endregion

        public static int FindMax(int range)
        {
            int res = 0;
            while (Fibonacci(res) < range)
                res += 1;
            return res;
        }

        public static List<string> SuiteFibo(int range)
        {
            List<string> nums = new List<string>();

            for (int i = 0; i < range - 1; i++)
                nums.Add(Fibonacci(i) + "");

            nums.Add(Fibonacci(range - 1) + "");

            return nums;
        }

        public static void PrintFibo(int range)
        {
            List<string> nums = SuiteFibo(range);

            Console.Write("[ ");
            for (int i = 0; i < nums.Count - 1; i++)
                Console.Write(nums[i] + " | ");
            Console.WriteLine(nums[^1] + " ]");
        }
    }
}