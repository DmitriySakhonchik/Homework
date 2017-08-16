using System;
using ProductManagement.IO;
using ProductManagement.ProductManagerCommandBuilders;

namespace ProductManagement
{
    public class ProductManagementTool
    {
        public const string ExitCommand = "exit";

        static void Main(string[] args)
        {
            Output output = new Output();
            Input input = new Input();

            ProductManager productManager = new ProductManager();
            productManager.AddCommand(new CountTypesCommandBuilder());
            productManager.AddCommand(new CountAllCommandBuilder());
            productManager.AddCommand(new AveragePriceCommandBuilder());
            productManager.AddCommand(new AveragePriceTypeCommandBuilder());

            bool repeat = false;
            do
            {
                try
                {
                    productManager.AddProduct(new Product(input.EnterProductInfo()));
                    repeat = input.AskYesNo();
                }
                catch (Exception exception)
                {
                    output.ShowExceptionMessage(exception);
                    repeat = true;
                }
            } while (repeat == true);

            bool repeatCommand = false;
            string command = null;
            do
            {
                try
                {
                    command = input.EnterCommand();
                    productManager.PerformCommand(command);
                    repeatCommand = true;
                }
                catch (Exception exception)
                {
                    if (command == ExitCommand)
                    {
                        repeatCommand = false;
                    }
                    else
                    {
                        output.ShowExceptionMessage(exception);
                        repeatCommand = true;
                    }
                }
            } while (repeatCommand == true);
            
            output.Exit();
        }
    }
}
