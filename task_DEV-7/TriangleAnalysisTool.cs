using System;

namespace TriangleAnalysis
{
    class TriangleAnalysisTool
    {
        public const string EXIT = "\nPress any key to exit...";
        public const string REPEAT_ENTRY = "Please, repeat entry.\n";

        static void Main(string[] args)
        {
            Input input = new Input(args);
            Triangle triangle = new Triangle();
            triangle.Sides = input.EnterTriangleSides();
            triangle.DetermineType();
            triangle.ShowType();

            Console.WriteLine(EXIT);
            Console.ReadKey();
        }
    }
}
