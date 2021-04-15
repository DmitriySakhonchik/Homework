using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProductManagement.Exceptions;
using ProductManagement.ProductManagerCommandBuilders;

namespace ProductManagementTests.ProductManagerCommandBuilders
{
    [TestClass()]
    public class CountAllCommandBuilderTests
    {
        [TestMethod()]
        [ExpectedException(typeof(CommandBuildException))]
        public void CountAllCommandBuilder_Build()
        {
            CountAllCommandBuilder builder = new CountAllCommandBuilder();

            builder.Build("count types");
        }
    }
}