using FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Common.Tests.Mapper.Converters.PropertyNameConverters
{
    [TestClass]
    public class UpperUnderscoreToCamelCasePropertyNameConverterTests : PropertyNameConverterTests
    {
        [TestMethod]
        public void GetName_PROJ_ShouldReturn_Proj()
        {
            Validate("PROJ", "Proj");
        }

        [TestMethod]
        public void GetName_PROJ_UID_ShouldReturn_ProjUid()
        {
            Validate("PROJ_UID", "ProjUid");
        }

        [TestMethod]
        public void GetName_PROJ_UID_MORE_DATA_ShouldReturn_ProjUidMoreData()
        {
            Validate("PROJ_UID_MORE_DATA", "ProjUidMoreData");
        }

        [TestMethod]
        public void GetName_ProjUid_ShouldReturn_ProjUid()
        {
            Validate("ProjUid", "ProjUid");
        }

        public override IPropertyNameConverter GetSut()
        {
            return new UpperUnderscoreToCamelCasePropertyNameConverter();
        }
    }
}
