using System;
using System.Collections.Generic;
using System.Data;
using FluentPro.FluentPS.Common.Mapper;
using FluentPro.FluentPS.Common.Tests.Extensions;
using FluentPro.FluentPS.Common.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Common.Tests.Mapper
{
    [TestClass]
    public class MapperTest
    {
        [TestMethod, Description("Ensure row values mapped to coresponding entity properties by name, default convention.")]
        public void Map_DataTableToEntity_ShouldReturnEntity()
        {
            var guid = Guid.NewGuid();
            var dt = new DataTable()
                .Column("PropertyGuid", typeof(Guid))
                .Column("PROP_GUID", typeof(Guid))
                .Column("PropertyInt", typeof(int))
                .Column("PropertyString", typeof(string))
                .Column("Property With Space", typeof(string));

            dt.Row(guid, guid, 10, "PropertyString", "PropertyWithSpace");

            var reader = dt.CreateDataReader();
            reader.Read();
            var entity = DsMapper.Map<DataTableReader, EntityWithPlainNames>(reader);
            Assert.IsTrue(entity.PropertyGuid == guid);
            Assert.IsTrue(entity.PropGuid == guid);
            Assert.IsTrue(entity.PropertyInt == 10);
            Assert.IsTrue(entity.PropertyString == "PropertyString");
            Assert.IsTrue(entity.PropertyWithSpace == "PropertyWithSpace");
        }

        [TestMethod, Description("Ensure row values mapped to corresponding property bag properties by name, default convention.")]
        public void Map_DataTableToPropertyBag_ShouldReturnEntity()
        {
            var guid = Guid.NewGuid();
            var dt = new DataTable()
                .Column("PropertyGuid", typeof(Guid))
                .Column("PROP_GUID", typeof(Guid))
                .Column("PropertyInt", typeof(int))
                .Column("PropertyString", typeof(string))
                .Column("Property With Space", typeof(string));

            dt.Row(guid, guid, 10, "PropertyString", "PropertyWithSpace");

            var reader = dt.CreateDataReader();
            reader.Read();
            var bag = DsMapper.Map<DataTableReader, Dictionary<string, object>>(reader);
            Assert.IsTrue((Guid)bag["PropertyGuid"] == guid);
            Assert.IsTrue((Guid)bag["PropGuid"] == guid);
            Assert.IsTrue((int)bag["PropertyInt"] == 10);
            Assert.IsTrue((string)bag["PropertyString"] == "PropertyString");
            Assert.IsTrue((string)bag["PropertyWithSpace"] == "PropertyWithSpace");
        }
    }
}
