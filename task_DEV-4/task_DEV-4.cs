using System;

namespace NumberSequence
{
    class ExceptionMessage
    {
        public bool ShowMessage(string exceptionType, string message)
        {
            Console.Write(exceptionType);
            Console.WriteLine(message);
            Console.WriteLine("Please, repeat number sequence entry.\n");
            return true;
        }
    }

    class NondecreasingNumberSequence
    {
        public bool MembershipCheck(int[] numberSequence)
        {
            bool check = true;
            for (int i = 1; i < numberSequence.Length; i++)
            {
                if (numberSequence[i] - numberSequence[i - 1] < 0)
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }                    
            }
            return check;
        }
        public void ShowResult(bool membershipCheck)
        {
            if (membershipCheck == true)
            {
                Console.WriteLine("\nThis number sequence is a nondecreasing number sequence.");
            }
            else
            {
                Console.WriteLine("\nThis number sequence is not a nondecreasing number sequence.");
            }
        }
    }

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
                    ExceptionMessage ExMessage = new ExceptionMessage();
                    repeat = ExMessage.ShowMessage("\nFormatException: ", e.Message);
                }
                catch (OverflowException e)
                {
                    ExceptionMessage ExMessage = new ExceptionMessage();
                    repeat = ExMessage.ShowMessage("\nOverflowException: ", "Number sequence is too large.");
                }               
            } while (repeat == true);

            NondecreasingNumberSequence NumSeq = new NondecreasingNumberSequence();
            bool membershipCheck = NumSeq.MembershipCheck(numberSequence);
            NumSeq.ShowResult(membershipCheck);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
