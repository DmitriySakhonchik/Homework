using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProductManagement.Exceptions;
using ProductManagement.ProductManagerCommandBuilders;

namespace ProductManagementTests.ProductManagerCommandBuilders
{
    [TestClass()]
    public class CountTypesCommandBuilderTests
    {
        [TestMethod()]
        [ExpectedException(typeof(CommandBuildException))]
        public void CountTypesCommandBuilder_Build()
        {
            CountTypesCommandBuilder builder = new CountTypesCommandBuilder();

            builder.Build("count all");
        }
    }
}