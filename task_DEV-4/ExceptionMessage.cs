using System;
using System.Text;

namespace NumberSequence
{
    class ExceptionMessage
    {
        private string exceptionType;
        private string exceptionMessage;

        public const string REPEAT_ENTRY = "Please, repeat number entry.\n";

        public ExceptionMessage(string exceptionMessage)
        {
            exceptionType = "Exception";
            this.exceptionMessage = exceptionMessage;
        }

        public ExceptionMessage(string exceptionType, string message)
        {
            this.exceptionType = exceptionType;
            this.exceptionMessage = message;
        }
        
        public void ShowMessage()
        {
            StringBuilder messageSB = new StringBuilder("\n");
            messageSB.Append(exceptionType);
            messageSB.Append(": ");
            messageSB.Append(exceptionMessage);
            messageSB.Append("\n");
            messageSB.Append(REPEAT_ENTRY);
            Console.WriteLine(messageSB);
        }
    }
}
