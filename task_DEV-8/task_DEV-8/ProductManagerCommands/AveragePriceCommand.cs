using System;
using System.Collections.Generic;
using ProductManagement.Exceptions;
using ProductManagement.Validators;

namespace ProductManagement.ProductManagerCommands
{
    public class AveragePriceCommand : Command
    {
        public AveragePriceCommand(string userCommand) : base()
        {
            CommandValidator validator = new CommandValidator(AveragePriceCommand);
            validator.Validate(userCommand);
            commandDetails = validator.GetCommandDetails();
            if (commandDetails != String.Empty)
            {
                throw new CommandException();
            }
        }

        public override string Message
        {
            get
            {
                return (AveragePriceCommandMessage + result);
            }
        }

        public override void Perform(List<Product> products)
        {
            double averagePrice = 0;
            foreach (Product product in products)
            {
                averagePrice = averagePrice + product.Price;
            }
            averagePrice = averagePrice / products.Count;
            result = averagePrice;
        }
    }
}
