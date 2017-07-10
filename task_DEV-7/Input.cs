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
            string[] triangleSides = null;
            bool repeat = false;
            do
            {
                try
                {
                    if (args.Length == 0 || repeat == true)
                    {

                        triangleSides = EnterTriangleSidesConsole();
                    }
                    else
                    {
                        triangleSides = EnterTriangleSidesCommandLine(args);
                    }
                    TriangleSidesValidator validator = new TriangleSidesValidator(triangleSides);
                    validator.CheckValidity();
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
