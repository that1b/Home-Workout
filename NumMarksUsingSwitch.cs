/*Create a C# program to display the "text mark" corresponding
 to a certain "numerical mark", using the following equivalence:
 6 = Отличен
 5 = Много добър
 4 = Добър
 3 = Среден
 2 = Слаб
 Your program must ask the user for a numerical mark and display
 the corresponding text mark. You must do it using "switch".*/

using System;
namespace SwitchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 2:
                    Console.WriteLine("Оценка: Слаб {0}", num);
                    break;
                case 3:
                    Console.WriteLine("Оценка: Среден {0}", num);
                    break;
                case 4:
                    Console.WriteLine("Оценка: Добър {0}", num);
                    break;
                case 5:
                    Console.WriteLine("Оценка: Много добър {0}", num);
                    break;
                case 6:
                    Console.WriteLine("Оценка: Отличен {0}", num);
                    break;
                default:
                    Console.WriteLine("Грешка! Въвели сте число по-малко от 2 или по-голямо от 6.Опитайте пак.");
                    do
                    {
                        Console.Write("Въведете число: ");
                        num = int.Parse(Console.ReadLine());
                    }
                    while (num <= 2 && num >= 6);
                    if (num == 2)
                        goto case 2;
                    else if (num == 3)
                        goto case 3;
                    else if (num == 4)
                        goto case 4;
                    else if (num == 5)
                        goto case 5;
                    else if (num == 6)
                        goto case 6;
                    else
                        goto default;
                    break;
            }
            Console.ReadLine();
        }
    }
}
