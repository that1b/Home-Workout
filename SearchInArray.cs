using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            

            for(int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("Insert a number: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int cmd;
            bool contains = false;
            do
            {
                Console.Write("Search for a number in your array: ");

                cmd = int.Parse(Console.ReadLine());
               
                for (int i = 0; i < arr.Length; i++)
                {
                    if (cmd == arr[i])
                    {
                        contains = true;
                    }
                    else
                    {
                        contains = false;
                    }
                }
                if (contains == true)
                {
                    Console.WriteLine("The number {0} contains in your array", cmd);
                }
                else
                {
                    Console.WriteLine("The number {0} does not contain in your array", cmd);
                }
                Console.WriteLine();
                Console.Write("If you want to continue press Enter or type /end/ to shut the program: ");
                
            } while (Console.ReadLine() != "end");
            Console.WriteLine("Good bye!");
            Console.ReadLine();
        }
    }
}
