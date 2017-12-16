using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlExercise2._18
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to ask the user for two numbers
               and show their division and the remainder of the division.
               It will warn if 0 is entered as second number,
               and end if 0 is entered as first number: */

            /*В отговора на задачата беше използвано условието
             if(ако делителят бъде равен на 0 да изпише "Cannot divide by zero").
             При мен с въпросния if не се получи,затова използвах try...catch :).*/

            decimal number1, number2, division,remainder;

            
                do
                {
               
                    Console.Write("First number: ");
                    number1 = int.Parse(Console.ReadLine());
                if (number1 != 0)
                {
                    Console.Write("Second number: ");
                    number2 = int.Parse(Console.ReadLine());
                    try
                    {
                        division = number1 / number2;
                        Console.WriteLine("Division:{0}", division);
                        remainder = number1 % number2;
                        Console.WriteLine("Remainder:{0}", remainder);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                }
                else
                    break;
            }
                while (number1 != 0);
                Console.WriteLine("Bye!");
                Console.ReadLine();
            
        }
    }
}
