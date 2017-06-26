using System;

namespace NumberSequence
{
    class ExceptionMessage
    {
        public const string REPEAT_ENTRY = "Please, repeat number entry.\n\n";
        
        public bool ShowMessage(string exceptionType, string message)
        {
            Console.Write(exceptionType);
            Console.WriteLine(message);
            Console.WriteLine(REPEAT_ENTRY);
            return true;
        }
    }
}
