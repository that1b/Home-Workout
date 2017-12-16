using System;
namespace Exercises
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int num;
			do
			{
				Console.Write("\nInput a number: ");
				num = int.Parse(Console.ReadLine());
				int counter = 1;
				Console.WriteLine("Times Table of number {0}", num);
				while (counter <= 10)
				{
					Console.WriteLine("{0} * {1} = {2}", counter, num, counter * num);
					counter++;
				}

			} while (num != 0);
			Console.ReadLine();
		}
	}
}
