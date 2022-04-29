using System;

namespace SomTests
{
    public class SomeHeaps
    {
        public static void print_arr(int[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    Console.Write(arr[i]);
                else
                {
                    Console.Write(arr[i] + " | ");
                }
            }

            Console.WriteLine(" ]");
        }

        public static int[] dec_r(int[] arr)
        {
            int[] res = new int[arr.Length];
            res[0] = 0;

            for (int i = 0; i < arr.Length - 1; i++)
                res[i + 1] = arr[i];


            return res;
        }

        public static int[] dec_l(int[] arr)
        {
            int[] res = new int[arr.Length];
            res[^1] = 0;

            for (int i = 0; i < arr.Length - 1; i++)
                res[i] = arr[i + 1];

            return res;
        }

        public static int[] Pop(int[] arr)
        {
            int l = arr.Length;
            int min = arr[1];
            int index = 1;

            for (int i = 0; i < l; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }

            int[] res = new int[l-1];

            for (int j = 0; j < l-1; j++)
            {
                if (j < index)
                    res[j] = arr[j];
                if (j > index)
                    res[j] = arr[j + 1];
            }

            res[index] = arr[index + 1];
            return res;
        }
    }
}