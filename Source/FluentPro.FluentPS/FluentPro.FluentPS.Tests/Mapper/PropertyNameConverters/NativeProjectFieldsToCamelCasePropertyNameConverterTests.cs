using FluentPro.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Mapper.PropertyNameConverters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Tests.Mapper.PropertyNameConverters
{
    [TestClass]
    public class NativeProjectFieldsToCamelCasePropertyNameConverterTests : PropertyNameConverterTests
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

        //[TestMethod]
        //public void GetName_T_Field_ShouldReturn_Tfield()
        //{
        //    Validate("T Field", "TField");
        //}

        //[TestMethod]
        //public void GetName_TField_ShouldReturn_Tfield()
        //{
        //    Validate("TField", "Tfield");
        //}

        //[TestMethod]
        //public void GetName_PM_TFS_Test_ShouldReturn_PmTfsTest()
        //{
        //    Validate("PM TFS Test", "PmTfsTest");
        //}

        public override IPropertyNameConverter GetSut()
        {
            return new PsToCamelCasePropertyNameConverter();
        }
    }
}
