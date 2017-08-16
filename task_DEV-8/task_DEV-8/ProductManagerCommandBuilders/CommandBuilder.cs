using ProductManagement.ProductManagerCommands;

namespace ProductManagement.ProductManagerCommandBuilders
{
    public abstract class CommandBuilder
    {
        public const string NotDeterminedMessage = "Command is not determined.";

        protected CommandBuilder successor;

        public abstract Command Build(string commandText);

        public void Add(CommandBuilder successor)
        {
            if (this.successor == null)
            {
                this.successor = successor;
            }
            else
            {
                this.successor.Add(successor);
            }
        }
    }
}
