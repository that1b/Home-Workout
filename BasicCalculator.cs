using System;
namespace _23_10_2017_BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("x= ");
                string str = Console.ReadLine();
                if (str == "exit")
                    break;
                int x = Convert.ToInt32(str);
                Console.Write("y= ");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum = x + y;
                Console.WriteLine("Result:{0}", sum);
            }
            while (true);
        }
    }
}
