using System;

namespace NumberSequence
{
    class ExceptionMessage
    {
        public bool ShowMessage(string exceptionType, string message)
        {
            const string REPEAT_ENTRY = "Please, repeat number entry.\n\n";
            Console.Write(exceptionType);
            Console.WriteLine(message);
            Console.WriteLine(REPEAT_ENTRY);
            return true;
        }
    }
}
