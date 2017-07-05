using System;

namespace NumberSequence
{
    class Input
    {
        public const string ENTER_NUMBER_SEQUENCE = "Enter a number sequence, dividing numbers by spaces:";

        public string[] NumberSequence(string[] args, bool indicator)
        {
            string[] stringNumbers;
            if (args.Length == 0 || indicator == true)
            {
                Console.WriteLine(ENTER_NUMBER_SEQUENCE);
                string inputString = Console.ReadLine();
                stringNumbers = inputString.Split();
            }
            else
            {
                stringNumbers = args;
            }
            return stringNumbers;
        }
    }
}
