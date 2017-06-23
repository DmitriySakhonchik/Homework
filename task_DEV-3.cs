using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            bool repeat = false;
            const string reinput = "\nPlease, repeat number entry.\n";
            int number = 0;
            do
            {
                Console.WriteLine("Enter a number:");
                string numberString = Console.ReadLine();                
                try
                {
                    number = Int32.Parse(numberString);
                    repeat = false;
                }
                catch (FormatException e)
                {
                    Console.Write("\nFormatException: ");
                    Console.WriteLine(e.Message);
                    Console.WriteLine(reinput);
                    repeat = true;
                }
                catch (OverflowException e)
                {
                    Console.Write("\nOverflowException: ");
                    Console.WriteLine("Number is too large.");
                    Console.WriteLine(reinput);
                    repeat = true;
                }
                if (number < 0)
                {
                    Console.WriteLine("\nInput number is negative.");
                    Console.WriteLine(reinput);
                    repeat = true;
                }
            } while (repeat == true);
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
