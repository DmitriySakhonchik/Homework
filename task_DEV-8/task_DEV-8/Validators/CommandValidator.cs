using System.Text;
using ProductManagement.Exceptions;

namespace ProductManagement.Validators
{
    public class CommandValidator
    {
        string[] command;
        string[] userCommand;

        public CommandValidator(string[] command)
        {
            this.command = command;
        }

        public void Validate(string userCommandText)
        {
            userCommand = userCommandText.Split();

            if (userCommand.Length < command.Length)
            {
                throw new CommandException();
            }

            for (int i = 0; i < command.Length; i++)
            {
                if (userCommand[i] != command[i])
                {
                    throw new CommandException();
                }
            }
        }

        public string GetCommandDetails()
        {
            StringBuilder commandDetails = new StringBuilder();
            if (userCommand.Length > command.Length)
            {
                for (int i = command.Length; i < userCommand.Length; i++)
                {
                    commandDetails.Append(userCommand[i]);
                    if (i != userCommand.Length - 1)
                    {
                        commandDetails.Append(" ");
                    }
                }
            }
            return commandDetails.ToString();
        }
    }
}
