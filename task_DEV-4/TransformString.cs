using System;

namespace NumberSequence
{
    class TransformString
    {
        public bool ParseString(string[] stringNumbers, int[] numberSequence)
        {
            try
            {
                for (int i = 0; i < stringNumbers.Length; i++)
                {
                    numberSequence[i] = Int32.Parse(stringNumbers[i]);
                }
                return false;
            }
            catch (FormatException e)
            {
                ExceptionMessage exMessage = new ExceptionMessage();
                return exMessage.ShowMessage("\nFormatException: ", e.Message);
            }
            catch (OverflowException e)
            {
                ExceptionMessage exMessage = new ExceptionMessage();
                return exMessage.ShowMessage("\nOverflowException: ", "Number sequence is too large.");
            }
        }
    }
}
