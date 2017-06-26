using System;

namespace NumberSequence
{
    class NumberSequenceTool
    {
        static void Main()
        {            
            bool repeat = false;
            int[] numberSequence;
            do
            {
                Console.WriteLine("Enter a number sequence, dividing numbers by spaces:");
                string inputString = Console.ReadLine();
                string[] stringNumbers = inputString.Split();
                numberSequence = new int[stringNumbers.Length];
                TransformString transformer = new TransformString();
                repeat = transformer.ParseString(stringNumbers, numberSequence);            
            } while (repeat == true);

            NondecreasingNumberSequence numSeq = new NondecreasingNumberSequence();
            bool membershipCheck = numSeq.MembershipCheck(numberSequence);
            numSeq.ShowResult(membershipCheck);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
