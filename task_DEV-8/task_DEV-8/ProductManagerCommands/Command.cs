using System.Collections.Generic;

namespace ProductManagement.ProductManagerCommands
{
    public abstract class Command
    {
        public readonly string[] CountTypesCommand = { "count", "types" };
        public readonly string[] CountAllCommand = { "count", "all" };
        public readonly string[] AveragePriceCommand = { "average", "price" };
        public readonly string[] AveragePriceTypeCommand = { "average", "price" };

        public const string CountTypesCommandMessage = "Total types quantity: ";
        public const string CountAllCommandMessage = "Total quantity: ";
        public const string AveragePriceCommandMessage = "Average price: ";
        public const string AveragePriceTypeCommandMessage = "<{0}> average price: ";
        public const string AveragePriceTypeCommandErrorMessage = "There are no products of type <{0}>.";

        protected string commandDetails;
        protected object result;

        public Command()
        {
        }

        public abstract string Message
        {
            get;
        }

        public object Result
        {
            get
            {
                return result;
            }
        }

        public abstract void Perform(List<Product> products);

        
    }
}
