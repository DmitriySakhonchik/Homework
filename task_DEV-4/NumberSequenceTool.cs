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
                try
                {
                    for (int i = 0; i < stringNumbers.Length; i++)
                    {
                        numberSequence[i] = Int32.Parse(stringNumbers[i]);
                    }
                    repeat = false;
                }                
                catch (FormatException e)
                {
                    ExceptionMessage exMessage = new ExceptionMessage();
                    repeat = exMessage.ShowMessage("\nFormatException: ", e.Message);
                }
                catch (OverflowException e)
                {
                    ExceptionMessage exMessage = new ExceptionMessage();
                    repeat = exMessage.ShowMessage("\nOverflowException: ", "Number sequence is too large.");
                }               
            } while (repeat == true);

            NondecreasingNumberSequence numSeq = new NondecreasingNumberSequence();
            bool membershipCheck = numSeq.MembershipCheck(numberSequence);
            numSeq.ShowResult(membershipCheck);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
