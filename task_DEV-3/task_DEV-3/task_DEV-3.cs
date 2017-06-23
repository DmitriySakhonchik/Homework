using System;

namespace FibonacciNumbers
{
    public static class ExceptionMessage
    {
        public static bool ShowMessage (string exceptionType, string message)
        {
            Console.Write(exceptionType);
            Console.WriteLine(message);
            Console.WriteLine("\nPlease, repeat number entry.\n");
            return true;
        }
    }
    
    public static class FibonacciNumbers
    {
        public static bool MembershipCheck (int number)
        {
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
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
            bool repeat = false;
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
                    repeat = ExceptionMessage.ShowMessage("\nFormatException: ", e.Message);
                }
                catch (OverflowException e)
                {
                    repeat = ExceptionMessage.ShowMessage("\nOverflowException: ", "Number is too large.");
                }
                if ((number < 0) && (repeat == false))
                {
                    repeat = ExceptionMessage.ShowMessage("\nException: ", "Input number is negative.");
                }
            } while (repeat == true);
            if (FibonacciNumbers.MembershipCheck(number) == true)
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
