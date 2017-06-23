using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            string numberString = Console.ReadLine();
            int number = 0;
            try
            {
                number = Int32.Parse(numberString);
            }
            catch (FormatException e)
            {
                Console.Write("\nFormatException: ");
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            catch (OverflowException e)
            {
                Console.Write("\nOverflowException: ");
                Console.WriteLine("Number is too large.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (number < 0)
            {
                Console.WriteLine("\nInput number is negative.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            int fibonacciN1 = 0;
            int fibonacciN2 = 1;
            int fibonacciN;
            do
            {
                fibonacciN = fibonacciN1 + fibonacciN2;
                fibonacciN1 = fibonacciN2;
                fibonacciN2 = fibonacciN;
            } while (fibonacciN < number);
            if ((number == fibonacciN) || (number == 0))
            {
                Console.WriteLine("\nThis number is a Fibonacci number.");
            }
            else
            {
                Console.WriteLine("\nThis number is not a Fibonacci number.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
