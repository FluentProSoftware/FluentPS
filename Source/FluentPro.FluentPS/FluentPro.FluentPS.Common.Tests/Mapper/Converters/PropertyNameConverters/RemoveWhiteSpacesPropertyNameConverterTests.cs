using FluentPro.FluentPS.Common.Mapper.Configurations.PropertyNameConverters;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Common.Tests.Mapper.Converters.PropertyNameConverters
{
    [TestClass]
    public class RemoveWhiteSpacesPropertyNameConverterTests : PropertyNameConverterTests
    {
        [TestMethod]
        public void GetName_NoSpacesName_ShouldReturnSimpleName()
        {
            Validate("Name", "Name");
        }

        [TestMethod]
        public void GetName_NameWithSpaces_ShouldReturnNameWithoutSpaces()
        {
            Validate("Name With Spaces", "NameWithSpaces");
        }

        public override IPropertyNameConverter GetSut()
        {
            return new RemoveWhiteSpacesPropertyNameConverter();
        }
    }
}
