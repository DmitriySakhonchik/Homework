using System;

namespace NumberSequence
{
    class NondecreasingNumberSequence
    {
        private bool membershipCheckResult;

        public const string YES = "\nThis number sequence is a nondecreasing number sequence.";
        public const string NO = "\nThis number sequence is not a nondecreasing number sequence.";

        public bool MembershipCheck(string[] stringNumbers)
        {
            bool repeat = true;
            if (stringNumbers.Length > 1)
            {
                try
                {
                    for (int i = 1; i < stringNumbers.Length; i++)
                    {
                        if (Int32.Parse(stringNumbers[i]) - Int32.Parse(stringNumbers[i - 1]) < 0)
                        {
                            membershipCheckResult = false;
                            break;
                        }
                        else
                        {
                            membershipCheckResult = true;
                        }
                    }
                    repeat = false;
                }
                catch (FormatException e)
                {
                    ExceptionMessage exMessage = new ExceptionMessage();
                    exMessage.ShowMessage("\nFormatException: ", e.Message);
                    repeat = true;
                }
                catch (OverflowException e)
                {
                    ExceptionMessage exMessage = new ExceptionMessage();
                    exMessage.ShowMessage("\nOverflowException: ", "Number sequence is too large.");
                    repeat = true;
                }
            }
            else
            {
                ExceptionMessage exMessage = new ExceptionMessage();
                repeat = exMessage.ShowMessage("\nException: ", "Number sequence is too small.");
                repeat = true;
            }
            return repeat;
        }

        public void ShowResult()
        {
            if (membershipCheckResult == true)
            {
                Console.WriteLine(YES);
            }
            else
            {
                Console.WriteLine(NO);
            }
        }
    }
}
