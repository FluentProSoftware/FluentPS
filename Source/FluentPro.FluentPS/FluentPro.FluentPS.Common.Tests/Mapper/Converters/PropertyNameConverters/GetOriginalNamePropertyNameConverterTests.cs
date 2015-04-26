using FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Common.Tests.Mapper.Converters.PropertyNameConverters
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
            return new OriginalNamePropertyNameConverter();
        }
    }
}
