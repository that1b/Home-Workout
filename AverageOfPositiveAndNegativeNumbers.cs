/* Create a C# program to ask the user for 10 real numbers and
  display the average of the positive ones and the average of the negative ones. */

using System;
namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int positiveNumC = 0, negativeNumC = 0;
            decimal pNumSum = 0, nNumSum = 0, avgPositive = 0, avgNegative = 0;
            decimal[] arr = new decimal[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Insert a number: ");
                arr[i] = decimal.Parse(Console.ReadLine());
            }
            for (int i = 0; i <arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    positiveNumC++;
                    pNumSum += arr[i];
                }
                else
                {
                    negativeNumC++;
                    nNumSum += arr[i];
                }
            }
            try
            {
                avgPositive = pNumSum / positiveNumC;
                avgNegative = nNumSum / negativeNumC;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("negativeNumC or positiveNumC is zero.");
            }
            Console.WriteLine();
            if (avgNegative == 0)
                Console.WriteLine("There aren't any negative numbers in the array.");
            else
                Console.WriteLine("Average sum of negative integers: {0}", avgNegative);
            if (avgPositive == 0)
                Console.WriteLine("There aren't any positive numbers in the array");
            else
                Console.WriteLine("Average sum of positive integers: " + avgPositive);
            
            Console.ReadLine();
        }
    }
}
