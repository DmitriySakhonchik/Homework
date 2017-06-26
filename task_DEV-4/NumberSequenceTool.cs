using System;

namespace NumberSequence
{
    class NumberSequenceTool
    {
        static void Main()
        {
            const string ENTER_NUMBER_SEQUENCE = "Enter a number sequence, dividing numbers by spaces:";
            const string EXIT = "\nPress any key to exit...";
            bool repeat = false;
            int[] numberSequence;
            do
            {
                Console.WriteLine(ENTER_NUMBER_SEQUENCE);
                string inputString = Console.ReadLine();
                string[] stringNumbers = inputString.Split();
                numberSequence = new int[stringNumbers.Length];
                TransformString transformer = new TransformString();
                repeat = transformer.ParseString(stringNumbers, numberSequence);            
            } while (repeat);

            NondecreasingNumberSequence numSeq = new NondecreasingNumberSequence();
            bool membershipCheck = numSeq.MembershipCheck(numberSequence);
            numSeq.ShowResult(membershipCheck);

            Console.WriteLine(EXIT);
            Console.ReadKey();
        }
    }
}
