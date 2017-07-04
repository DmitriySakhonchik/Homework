using System;

namespace NumberSequence
{
    class NumberSequenceCheckTool
    {
        public const string EXIT = "\nPress any key to exit...";

        static void Main(string[] args)
        {
            bool repeat = false;
            NondecreasingNumberSequence numberSequence;          
            do
            {
                numberSequence = new NondecreasingNumberSequence();
                try
                {
                    Input input = new Input();
                    repeat = numberSequence.CheckMembership(input.NumberSequence(args, repeat));
                }
                catch (FormatException e)
                {
                    ExceptionMessage exMessage = new ExceptionMessage("FormatException", e.Message);
                    exMessage.ShowMessage();
                    repeat = true;
                }
                catch (OverflowException e)
                {
                    ExceptionMessage exMessage = new ExceptionMessage("OverflowException: ", "Number sequence is too large.");
                    exMessage.ShowMessage();
                    repeat = true;
                }
            } while (repeat);

            numberSequence.ShowResult();
            
            Console.WriteLine(EXIT);
            Console.ReadKey();
        }
    }
}
