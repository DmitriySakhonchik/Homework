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
}
