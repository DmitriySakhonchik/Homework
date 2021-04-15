using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Exceptions
{
    public class CommandBuildException : Exception
    {
        public const string CommandBuildExceptionMessage = "Invalid command.";

        public override string Message
        {
            get
            {
                return CommandBuildExceptionMessage;
            }
        }
    }
}
