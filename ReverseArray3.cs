using System;
namespace Exercise_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Declare a size for the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Input a number: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.Write(" " + array[i]);
            }
            Console.ReadLine();
        }
    }
}
