using System;

namespace NumberSequence
{
    class TransformSequence
    {
        private int[] numberSequence;

        public bool ParseString(string[] stringNumbers)
        {
            numberSequence = new int[stringNumbers.Length];
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

        public int[] ReturnSequence()
        {
            return numberSequence;
        }
    }
}
