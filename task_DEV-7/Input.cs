using System;

namespace TriangleAnalysis
{
    class Input
    {
        private string[] args;

        public const string REPEAT_ENTRY = "Please, repeat entry.\n";
        public const string ENTER_TRIANGLE_SIDES = "Enter lengths of triangle sides (LTS), dividing numbers by spaces:";
        public const string CL_ARGUMENTS_LENGTH = "The number of command-line arguments is not equal to 3.";
        public const string SIDES_LENGTHS_NUMBER = "The number of LTS is not equal to 3.";

        public Input(string[] args)
        {
            this.args = args;
        }

        public string[] EnterTriangleSides()
        {
            bool repeat = false;
            do
            {
                try
                {
                    if ((args.Length == 0) || (repeat == true))
                    {
                        EnterTriangleSidesConsole();
                    }
                    else
                    {
                        EnterTriangleSidesCommandLine();
                    }
                    TriangleSidesValidator validator = new TriangleSidesValidator(args);
                    validator.CheckValidity();
                    repeat = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nException: " + e.Message);
                    Console.WriteLine(REPEAT_ENTRY);
                    repeat = true;
                }
            } while (repeat);
            
            return args;
        }

        public void EnterTriangleSidesConsole()
        {
            Console.WriteLine(ENTER_TRIANGLE_SIDES);
            string inputString = Console.ReadLine();
            args = inputString.Split();
            if (args.Length != 3)
            {
                throw new Exception(SIDES_LENGTHS_NUMBER);
            }
        }

        public void EnterTriangleSidesCommandLine()
        {
            if (args.Length != 3)
            {
                throw new Exception(CL_ARGUMENTS_LENGTH);
            }
        }
    }
}
