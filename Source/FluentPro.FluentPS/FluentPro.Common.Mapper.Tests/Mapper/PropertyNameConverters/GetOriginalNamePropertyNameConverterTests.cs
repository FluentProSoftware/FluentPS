using FluentPro.Common.Mapper.Configurations.PropertyNameConverters;
using FluentPro.Common.Mapper.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.Common.Mapper.Tests.Mapper.PropertyNameConverters
{
    [TestClass]
    public class GetOriginalNamePropertyNameConverterTests : PropertyNameConverterTests
    {
        [TestMethod]
        public void GetName_Name_Returns_Name()
        {
            Validate("Name", "Name");
        }

        public override IPropertyNameConverter GetSut()
        {
            return new NopPropertyNameConverter();
        }
    }
}
