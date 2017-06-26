using System;

namespace NumberSequence
{
    class NumberSequenceCheckTool
    {
        public const string ENTER_NUMBER_SEQUENCE = "Enter a number sequence, dividing numbers by spaces:";
        public const string EXIT = "\nPress any key to exit...";

        static void Main()
        {
            TransformSequence transSeq;
            bool repeat = false;          
            do
            {
                Console.WriteLine(ENTER_NUMBER_SEQUENCE);
                string inputString = Console.ReadLine();
                string[] stringNumbers = inputString.Split();
                transSeq = new TransformSequence();
                repeat = transSeq.ParseString(stringNumbers);
            } while (repeat);

            NondecreasingNumberSequence numSeq = new NondecreasingNumberSequence();
            bool membershipCheck = numSeq.MembershipCheck(transSeq.ReturnSequence());
            numSeq.ShowResult(membershipCheck);

            Console.WriteLine(EXIT);
            Console.ReadKey();
        }
    }
}
