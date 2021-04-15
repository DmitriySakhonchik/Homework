using ProductManagement.ProductManagerCommands;
using ProductManagement.Exceptions;

namespace ProductManagement.ProductManagerCommandBuilders
{
    public class AveragePriceTypeCommandBuilder : CommandBuilder
    {
        public override Command Build(string commandText)
        {
            Command command;
            try
            {
                command = new AveragePriceTypeCommand(commandText);
            }
            catch (CommandException exception)
            {
                if (successor != null)
                {
                    command = successor.Build(commandText);
                }
                else
                {
                    throw new CommandBuildException();
                }
            }
            return command;
        }
    }
}
