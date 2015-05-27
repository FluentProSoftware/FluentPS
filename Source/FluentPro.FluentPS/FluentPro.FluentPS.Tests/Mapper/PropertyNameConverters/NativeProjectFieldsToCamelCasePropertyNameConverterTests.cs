using FluentPro.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Mapper.PropertyNameConverters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Tests.Mapper.PropertyNameConverters
{
    [TestClass]
    public class NativeProjectFieldsToCamelCasePropertyNameConverterTests : PropertyNameConverterTests
    {
        [TestMethod]
        public void GetName_PROJ_UID_ShouldReturn_ProjUid()
        {
            Validate("PROJ_UID", "ProjUid");
        }

        [TestMethod]
        public void GetName_PROJ_NAME_ShouldReturn_ProjName()
        {
            Validate("PROJ_NAME", "ProjName");
        }

        public override IPropertyNameConverter GetSut()
        {
            return new PsToCamelCasePropertyNameConverter();
        }
    }
}
