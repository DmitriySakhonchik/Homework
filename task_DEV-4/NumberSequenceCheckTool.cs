using System;

namespace NumberSequence
{
    class NumberSequenceCheckTool
    {
        public const string EXIT = "\nPress any key to exit...";

        static void Main(string[] args)
        {
            bool repeat = false;
            NondecreasingNumberSequence numSeq;          
            do
            {
                Input input = new Input();
                numSeq = new NondecreasingNumberSequence();
                repeat = numSeq.MembershipCheck(input.NumberSequence(args, repeat));
            } while (repeat);

            numSeq.ShowResult();
            
            Console.WriteLine(EXIT);
            Console.ReadKey();
        }
    }
}
