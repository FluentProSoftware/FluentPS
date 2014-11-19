using FluentPro.FluentPS.Common.Mapper.Resolvers.PropertiesAccessors;
using FluentPro.FluentPS.Common.Tests.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FluentPro.FluentPS.Common.Tests.Mapper.Resolvers.PropertiesAccessors
{
    [TestClass]
    public class DataTableReaderPropertiesAccessorTests
    {
        [TestMethod]
        public void GetPropertyValue_ByName_ShouldReturnValidValue()
        {
            var sut = new DataTableReaderPropertiesAccessor();
            var reader = DefaultData.DataTable.CreateDataReader();
            reader.Read();

            var result = sut.GetPropertyValue(reader, "PropertyGuid");

            Assert.IsTrue((Guid)result == DefaultData.Guid);
        }
    }
}
