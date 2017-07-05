using System;

namespace TriangleAnalysis
{
    class Input
    {
        public const string ENTER_TRIANGLE_SIDES = "Enter lengths of triangle sides (LTS), dividing numbers by spaces:";
        public const string CL_ARGUMENTS_LENGTH = "The number of command-line arguments is not equal to 3.";
        public const string SIDES_LENGTHS_NUMBER = "The number of LTS is not equal to 3.";

        public string[] EnterTriangleSides(string[] args, bool indicator)
        {
            string[] triangleSides;
            if (args.Length == 0 || indicator == true)
            {

                triangleSides = EnterTriangleSidesConsole();
            }
            else
            {
                triangleSides = EnterTriangleSidesCommandLine(args);
            }
            return triangleSides;
        }

        public string[] EnterTriangleSidesConsole()
        {
            string[] triangleSides;
            Console.WriteLine(ENTER_TRIANGLE_SIDES);
            string inputString = Console.ReadLine();
            triangleSides = inputString.Split();
            if (triangleSides.Length != 3)
            {
                throw new Exception(SIDES_LENGTHS_NUMBER);
            }
            return triangleSides;
        }

        public string[] EnterTriangleSidesCommandLine(string[] args)
        {
            string[] triangleSides;
            if (args.Length != 3)
            {
                throw new Exception(CL_ARGUMENTS_LENGTH);
            }
            else
            {
                triangleSides = args;
            }
            return triangleSides;
        }
    }
}
