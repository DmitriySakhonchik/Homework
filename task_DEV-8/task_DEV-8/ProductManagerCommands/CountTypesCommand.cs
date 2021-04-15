using System;
using System.Collections.Generic;
using ProductManagement.Exceptions;
using ProductManagement.Validators;

namespace ProductManagement.ProductManagerCommands
{
    public class CountTypesCommand : Command
    {
        public CountTypesCommand(string userCommand) : base()
        {
            CommandValidator validator = new CommandValidator(CountTypesCommand);
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
                return (CountTypesCommandMessage + result);
            }
        }

        public override void Perform(List<Product> products)
        {
            List<string> types = new List<string>();
            foreach (Product product in products)
            {
                if (!types.Contains(product.Type))
                {
                    types.Add(product.Type);
                }
            }
            result = types.Count;
        }
    }
}
