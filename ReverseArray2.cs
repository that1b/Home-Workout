using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];  // Spawns a single dimensional array from type integer with size 10
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 10); // Fills the array with random numbers
            }
            Console.Write("Original Array:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]); /* Loop to show the original version of the array
                                                after filling it with random numbers */
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length/2; i++)
            {
                int temp;       /*The method that changes the original 
                                order of the array reversing its order.
                                Using "temporary" variable(temp) to save one
                                of the values to make sure not lose it while
                                replacing the position of each value*/



                temp = a[i];                    
                a[i] = a[a.Length - 1 - i];                            
                a[a.Length - 1 - i] = temp;     
                                                
            }
            Console.Write("Reversed Version:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);  /* Loop to show the array after it
                                            was reversed by the previous loop */
            }
            Console.ReadLine();
        }
    }
}
