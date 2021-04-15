using System.Collections.Generic;

using ProductManagement.ProductManagerCommands;
using ProductManagement.ProductManagerCommandBuilders;
using ProductManagement.IO;

namespace ProductManagement
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();
        private CommandBuilder commander;

        public int ProductsAmount
        {
            get
            {
                return products.Count;
            }
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void AddCommand(CommandBuilder command)
        {
            if (commander == null)
            {
                commander = command;
            }
            else
            {
                commander.Add(command);
            }
        }

        public void PerformCommand(string userCommand)
        {
            Command command = commander.Build(userCommand);
            command.Perform(products);
            (new Output()).ShowString(command.Message);
        }
    }
}
