using System;
using System.Collections.Generic;
using ProductManagement.Exceptions;
using ProductManagement.Validators;

namespace ProductManagement.ProductManagerCommands
{
    public class AveragePriceTypeCommand : Command
    {
        public AveragePriceTypeCommand(string userCommand) : base()
        {
            CommandValidator validator = new CommandValidator(AveragePriceTypeCommand);
            validator.Validate(userCommand);
            commandDetails = validator.GetCommandDetails();
            if (commandDetails == String.Empty)
            {
                throw new CommandException();
            }
        }

        public override string Message
        {
            get
            {
                string message;
                if (Equals(result, Double.NaN))
                {
                    message = (string.Format(AveragePriceTypeCommandErrorMessage, commandDetails));
                }
                else
                {
                    message = (string.Format(AveragePriceTypeCommandMessage + result, commandDetails));
                }
                return message;
            }
        }

        public override void Perform(List<Product> products)
        {
            double averageTypePrice = 0;
            double typeNumber = 0;
            foreach (Product product in products)
            {
                if (product.Type.ToLower() == commandDetails.ToLower())
                {
                    averageTypePrice = averageTypePrice + product.Price;
                    typeNumber++;
                }
            }
            averageTypePrice = averageTypePrice / typeNumber;
            result = averageTypePrice;
        }
    }
}
