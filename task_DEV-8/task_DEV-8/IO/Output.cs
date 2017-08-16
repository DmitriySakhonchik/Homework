using System;

namespace ProductManagement.IO
{
    public class Output
    {
        public const string ExitMessage = "Press any key to exit...";
        public const string RepeatEntryMessage = "Please, repeat entry.";

        public void Exit()
        {
            Console.WriteLine();
            Console.WriteLine(ExitMessage);
            Console.ReadKey();
        }

        public void ShowExceptionMessage(Exception e)
        {
            Console.WriteLine(e.GetType().Name + ": " + e.Message);
            Console.WriteLine(RepeatEntryMessage);
            Console.WriteLine();
        }

        public void ShowProductInfo(Product product)
        {
            Console.WriteLine(product.ToString());
            Console.WriteLine();
        }

        public void ShowString(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
