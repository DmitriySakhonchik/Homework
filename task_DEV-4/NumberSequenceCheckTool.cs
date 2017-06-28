using System;

namespace NumberSequence
{
    class NumberSequenceCheckTool
    {
        public const string ENTER_NUMBER_SEQUENCE = "Enter a number sequence, dividing numbers by spaces:";
        public const string EXIT = "\nPress any key to exit...";

        static void Main(string[] args)
        {
            bool repeat = false;
            NondecreasingNumberSequence numSeq;
            do
            {
                if (args.Length == 0 || repeat == true)
                {
                    Console.WriteLine(ENTER_NUMBER_SEQUENCE);
                    string inputString = Console.ReadLine();
                    string[] stringNumbers = inputString.Split();
                    numSeq = new NondecreasingNumberSequence();
                    repeat = numSeq.MembershipCheck(stringNumbers);
                }
                else
                {
                    numSeq = new NondecreasingNumberSequence();
                    repeat = numSeq.MembershipCheck(args);
                }
            } while (repeat);

            numSeq.ShowResult();
            
            Console.WriteLine(EXIT);
            Console.ReadKey();
        }
    }
}
