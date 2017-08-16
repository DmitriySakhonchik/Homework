using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProductManagement.Exceptions;
using ProductManagement.ProductManagerCommandBuilders;

namespace ProductManagementTests.ProductManagerCommandBuilders
{
    [TestClass()]
    public class AveragePriceTypeCommandBuilderTests
    {
        [TestMethod()]
        [ExpectedException(typeof(CommandBuildException))]
        public void AveragePriceTypeCommandBuilder_Build()
        {
            AveragePriceTypeCommandBuilder builder = new AveragePriceTypeCommandBuilder();

            builder.Build("count all");
        }
    }
}