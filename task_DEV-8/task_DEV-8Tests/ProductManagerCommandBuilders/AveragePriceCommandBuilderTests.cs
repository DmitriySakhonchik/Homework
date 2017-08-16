using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProductManagement.Exceptions;
using ProductManagement.ProductManagerCommandBuilders;

namespace ProductManagementTests.ProductManagerCommandBuilders
{
    [TestClass()]
    public class AveragePriceCommandBuilderTests
    {
        [TestMethod()]
        [ExpectedException(typeof(CommandBuildException))]
        public void AveragePriceCommandBuilder_Build_ThrowsCommandBuildException()
        {
            AveragePriceCommandBuilder builder = new AveragePriceCommandBuilder();

            builder.Build("count all");
        }
    }
}