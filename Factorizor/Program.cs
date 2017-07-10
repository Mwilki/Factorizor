using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();
            Calculator.PrintFactors(number);
            Calculator.IsPerfectNumber(number);
            Calculator.IsPrimeNumber(number);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }


        static int GetNumberFromUser()
        {
            string input;
            int output;

            while (true)
            {

                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {
                    return output;
                }
                else
                {
                    Console.WriteLine("Sorry");
                    continue;
                }
            }
        }
    }

    class Calculator
    {


        /// <summary>
        /// Given a number, print if it is perfect or not
        /// </summary>
        public static void IsPerfectNumber(int input)
        {
            int sum = 0;
            for (int factor = 1; factor < input; factor++)
            {
                if (input % factor == 0)
                {
                    sum = sum + factor;
                }
            }
            if (sum == input)
                Console.WriteLine("perfect");
            else
                Console.WriteLine("not perfect");

        }

        /// <summary>
        /// Given a number, print if it is prime or not
        /// </summary>
        public static void IsPrimeNumber(int number)
        {

            if (number == 0 || number == 1)
            {
                Console.WriteLine("not prime");
            }
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            // Prime numbers only have themselves and 1 as factor
            for (var i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Not prime");
                    break;
                } else
                {
                    Console.WriteLine("Prime");
                    return;
                }
            }
        }
    }
}
