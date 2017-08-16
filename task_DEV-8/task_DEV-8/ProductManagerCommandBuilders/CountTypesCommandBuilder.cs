using ProductManagement.ProductManagerCommands;
using ProductManagement.Exceptions;

namespace ProductManagement.ProductManagerCommandBuilders
{
    public class CountTypesCommandBuilder : CommandBuilder
    {
        public override Command Build(string commandText)
        {
            Command command;
            try
            {
                command = new CountTypesCommand(commandText);
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
