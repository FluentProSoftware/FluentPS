using FluentPro.FluentPS.Common.Mapper.Converters.PropertyNameConverters;
using FluentPro.FluentPS.Common.Mapper.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Common.Tests.Mapper.Converters.PropertyNameConverters
{
    [TestClass]
    public class CamelCaseToUpperUnderscorePropertyNameConverterTests : PropertyNameConverterTests
    {
        [TestMethod]
        public void GetName_Proj_ShouldReturn_PROJ()
        {
            Validate("Proj", "PROJ");
        }

        [TestMethod]
        public void GetName_ProjUid_ShouldReturn_PROJ_UID()
        {
            Validate("ProjUid", "PROJ_UID");
        }


        [TestMethod]
        public void GetName_ProjUidAndMoreData_ShouldReturn_PROJ_UID_AND_MORE_DATA()
        {
            Validate("ProjUidAndMoreData", "PROJ_UID_AND_MORE_DATA");
        }

        public override IPropertyNameConverter GetSut()
        {
            return new CamelCaseToUpperUnderscorePropertyNameConverter();
        }
    }
}
