using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace SomTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            
            Stopwatch timer = new Stopwatch();
            timer.Start();
            
            var res = fib(int.Parse(value));
            
            timer.Stop();
            
            //Console.WriteLine(res);
            Console.WriteLine(timer.Elapsed);
        }

        static BigInteger fib(int n)
        {
            BigInteger[,] F = new BigInteger[,]
            {
                {1, 1},
                {1, 0}
            };
            if (n == 0)
                return 0;
            power(F, n - 1);
            
            return F[0, 0];
        }
        static void multiply(BigInteger[,] F, BigInteger[,] M)
        {
            BigInteger x = F[0, 0] * M[0, 0] + F[0, 1] * M[1, 0];
            BigInteger y = F[0, 0] * M[0, 1] + F[0, 1] * M[1, 1];
            BigInteger z = F[1, 0] * M[0, 0] + F[1, 1] * M[1, 0];
            BigInteger w = F[1, 0] * M[0, 1] + F[1, 1] * M[1, 1];

            F[0, 0] = x;
            F[0, 1] = y;
            F[1, 0] = z;
            F[1, 1] = w;
        }
        static void power(BigInteger[,] F, int n)
        {
            int i;
            BigInteger[,] M = new BigInteger[,]
            {
                {1, 1},
                {1, 0}
            };
            
            for (i = 2; i <= n; i++)
                multiply(F, M);
        }
    }
}