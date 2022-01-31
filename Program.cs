using System;
using System.Linq;

namespace TaskC
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 0;

            while (exit == 0)
            {
                var numberList = Enumerable.Range(0, 101).ToList();

                foreach (var number in numberList)
                {
                    Console.WriteLine(Checker(number));
                }

                Console.WriteLine("");
                Console.Write("Try again? (Press n to exit.) ");
                if (Console.ReadKey().Key == ConsoleKey.N)
                    exit = 1;
                else
                    Console.WriteLine("");
            }
        }

        static string Checker(int number)
        {
            if (number % 3 == 0)
            {
                if (number % 5 == 0)
                    return "FizzBuzz";
                else return "Fizz";
            }
            else if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
