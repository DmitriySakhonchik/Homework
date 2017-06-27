using System;

namespace NumberSequence
{
    class NumberSequenceCheckTool
    {
        public const string ENTER_NUMBER_SEQUENCE = "Enter a number sequence, dividing numbers by spaces:";
        public const string EXIT = "\nPress any key to exit...";

        static void Main()
        {
            bool repeat = false;
            NondecreasingNumberSequence numSeq;
            do
            {
                Console.WriteLine(ENTER_NUMBER_SEQUENCE);
                string inputString = Console.ReadLine();
                string[] stringNumbers = inputString.Split();
                numSeq = new NondecreasingNumberSequence();
                repeat = numSeq.MembershipCheck(stringNumbers);
            } while (repeat);

            numSeq.ShowResult();
            
            Console.WriteLine(EXIT);
            Console.ReadKey();
        }
    }
}
