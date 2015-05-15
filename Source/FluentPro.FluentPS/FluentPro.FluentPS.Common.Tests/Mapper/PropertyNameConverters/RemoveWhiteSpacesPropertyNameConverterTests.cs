using FluentPro.Common.Mapper.Configurations.PropertyNameConverters;
using FluentPro.Common.Mapper.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.Common.Mapper.Tests.Mapper.PropertyNameConverters
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
