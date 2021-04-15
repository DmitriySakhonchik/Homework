using System;

namespace ProductManagement.IO
{
    public class Input
    {
        public const string YesNoMessage = "Do you want to enter another product? (y/n)";
        public const string YesNoExceptionMessage = "Invalid yes/no (y/n) answer.";
        public const string CommandMessage = "Enter a command: ";

        public const string EnterInfoMessage = "Enter product info:\n[Format: <Type>, <Name> (not greater than 3 words)]\n";
        public const string TypeMessage = "Type: ";
        public const string NameMessage = "Name: ";
        public const string QuantityMessage = "Quantity: ";
        public const string PriceMessage = "Price: ";

        public bool AskYesNo()
        {
            Output output = new Output();
            bool yesNo = false;
            bool repeat = false;
            do
            {
                try
                {
                    Console.WriteLine(YesNoMessage);
                    string answer = Console.ReadLine();
                    Console.WriteLine();
                    if (answer == "y")
                    {
                        yesNo = true;
                    }
                    else if (answer == "n")
                    {
                        yesNo = false;
                    }
                    else
                    {
                        throw new ArgumentException(YesNoExceptionMessage);
                    }
                    repeat = false;
                }
                catch (Exception exception)
                {
                    output.ShowExceptionMessage(exception);
                    repeat = true;
                }
            } while (repeat == true);
            return yesNo;
        }

        public string EnterCommand()
        {
            Console.Write(CommandMessage);
            string command = Console.ReadLine();
            Console.WriteLine();
            return command;
        }

        public string[] EnterProductInfo()
        {
            Output output = new Output();
            Console.WriteLine(EnterInfoMessage);
            string[] messages = new string[] { TypeMessage, NameMessage, QuantityMessage, PriceMessage };
            string[] productInfo = new string[4];
            for (int i = 0; i < productInfo.Length; i++)
            {
                Console.Write(messages[i]);
                productInfo[i] = Console.ReadLine();
            }
            Console.WriteLine();
            return productInfo;
        }
    }
}
