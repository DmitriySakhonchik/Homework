using System;
using System.Collections.Generic;
using ProductManagement.Exceptions;
using ProductManagement.Validators;

namespace ProductManagement.ProductManagerCommands
{
    public class CountAllCommand : Command
    {
        public CountAllCommand(string userCommand) : base()
        {
            CommandValidator validator = new CommandValidator(CountAllCommand);
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
                return (CountAllCommandMessage + result);
            }
        }

        public override void Perform(List<Product> products)
        {
            int totalQuantity = 0;
            foreach (Product product in products)
            {
                totalQuantity = totalQuantity + product.Quantity;
            }
            result = totalQuantity;
        }
    }
}
