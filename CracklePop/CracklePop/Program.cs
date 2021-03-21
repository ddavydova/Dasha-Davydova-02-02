using System;

namespace CracklePop
{
    class Program
    {
        //Write a program that prints out the numbers 1 to 100 (inclusive). If the number is divisible by 3,
        //print Crackle instead of the number. If it's divisible by 5, print Pop. If it's divisible by both 
        //3 and 5, print CracklePop. You can use any language.
        static void Main(string[] args)
        {
        Start:


            Console.WriteLine("Please, enter a number between 1 and 100:");
            string answer = Console.ReadLine();
            int number;


            if (int.TryParse(answer, out number) && number < 1 && number > 100 || number < 1 || number > 100)
            {
                Console.WriteLine("The number is out of the listed range or the input is invalid, try again!");
                goto Start;
            }
            else
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("CracklePop!");
                    Environment.Exit(-1);
                }
                else if (number % 3 == 0 && number % 5 != 0)
                {
                    Console.WriteLine("Crackle");
                    Environment.Exit(-1);
                }
                else if (number % 3 != 0 && number % 5 == 0)
                {
                    Console.WriteLine("Pop");
                    Environment.Exit(-1);
                }
                else
                {
                    Console.WriteLine("Your number is weird, try again later :)");
                    Environment.Exit(-1);
                }
            }

        }
    }
}