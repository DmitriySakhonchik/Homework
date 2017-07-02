using System;

namespace NumberSequence
{
    class ExceptionMessage
    {
        public const string REPEAT_ENTRY = "Please, repeat number entry.\n";
        
        public void ShowMessage(string exceptionType, string message)
        {
            Console.Write(exceptionType);
            Console.WriteLine(message);
            Console.WriteLine(REPEAT_ENTRY);
        }
    }
}
