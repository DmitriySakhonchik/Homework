using System;

namespace TriangleAnalysis
{
    class TriangleAnalysisTool
    {
        public const string EXIT = "\nPress any key to exit...";
        public const string REPEAT_ENTRY = "Please, repeat entry.\n";

        static void Main(string[] args)
        {
            Triangle triangle;
            bool repeat = false;
            do
            {
                triangle = new Triangle();
                try
                {
                    Input input = new Input(args);
                    triangle.Sides = input.EnterTriangleSides(repeat);
                    triangle.DetermineType();
                    repeat = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nFormatException: " + e.Message);
                    Console.WriteLine(REPEAT_ENTRY);
                    repeat = true;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("\nOverflowException: " + e.Message);
                    Console.WriteLine(REPEAT_ENTRY);
                    repeat = true;
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("\nNullReferenceException: " + e.Message);
                    Console.WriteLine(REPEAT_ENTRY);
                    repeat = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nException: " + e.Message);
                    Console.WriteLine(REPEAT_ENTRY);
                    repeat = true;
                }               
            } while (repeat);

            triangle.ShowType();

            Console.WriteLine(EXIT);
            Console.ReadKey();
        }
    }
}
