using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input size of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 101);
            }
            Console.Write("Elements in array:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }
            Console.WriteLine();
            Console.Write("Even numbers:");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(" " + a[i]);
                }
            }
            Console.WriteLine();
            Console.Write("Odd numbers:");
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] % 2 == 1)
                {
                    Console.Write(" " + a[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
