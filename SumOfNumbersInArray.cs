/*Create a program which asks the user for several numbers
 (until he enters "end" and displays their sum).
 When the execution is going to end, it must display all the numbers entered,
 and the sum again, as follows: */

using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] array = new float[1000];
            string prompt;
            int counter = 0;
            float sum = 0;
            do
            {
                Console.Write("Enter a number: ");
                prompt = Console.ReadLine();
                try
                {
                    if (prompt != "end")
                    {
                        float number = Convert.ToSingle(prompt);
                        array[counter] = number;
                        counter++;
                        sum += number;
                        Console.WriteLine("Sum = {0}", sum);
                    }
                }
                catch(FormatException f)
                {
                    Console.WriteLine(f.Message);
                    Console.WriteLine("Input a number or type /end/ if you want to continue.");
                }
            } while (prompt != "end");
            Console.WriteLine();
            Console.Write("Inserted numbers:");
            for (int i = 0; i < counter; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("The total sum is: " + sum);
            Console.ReadLine();
        }
    }
}
