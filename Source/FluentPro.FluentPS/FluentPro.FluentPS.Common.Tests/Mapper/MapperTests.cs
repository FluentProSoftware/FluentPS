using FluentPro.FluentPS.Common.Mapper;
using FluentPro.FluentPS.Common.Tests.Data;
using FluentPro.FluentPS.Common.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;

namespace FluentPro.FluentPS.Common.Tests.Mapper
{
    [TestClass]
    public class MapperTests
    {
        [TestMethod, Description("Ensure row values mapped to coresponding entity properties by name, default convention.")]
        public void Map_DataTableReaderToEntity_ShouldReturnEntity()
        {
            var reader = DefaultData.DataTable.CreateDataReader();
            reader.Read();

            var entity = FluentMapper.Default.Map<DataTableReader, EntityWithPlainNames>(reader);

            Assert.IsTrue(entity.PropertyGuid == DefaultData.Guid);
            Assert.IsTrue(entity.PropertyInt == 10);
            Assert.IsTrue(entity.PropertyString == "PropertyString");
            Assert.IsTrue(entity.PropertyWithSpace == "PropertyWithSpace");
        }

        [TestMethod, Description("Ensure row values mapped to corresponding property bag properties by name, default convention.")]
        public void Map_DataTableToDictionary_ShouldReturnEntity()
        {
            var reader = DefaultData.DataTable.CreateDataReader();
            reader.Read();

            var bag = FluentMapper.Default.Map<DataTableReader, Dictionary<string, object>>(reader);

            Assert.IsTrue((Guid)bag["PropertyGuid"] == DefaultData.Guid);
            Assert.IsTrue((int)bag["PropertyInt"] == 10);
            Assert.IsTrue((string)bag["PropertyString"] == "PropertyString");
            Assert.IsTrue((string)bag["PropertyWithSpace"] == "PropertyWithSpace");
        }

        [TestMethod, Description("Ensure entity values mapped to corresponding entity properties by name, default convention.")]
        public void Map_EntityWithPlainNamesToEntityWithPlainNames_ShouldReturnEntityWithPlainNames()
        {
            var entity = new EntityWithPlainNames
            {
                PropertyGuid = DefaultData.Guid,
                PropertyInt = 10,
                PropertyString = "PropertyString",
                PropertyWithSpace = "PropertyWithSpace"
            };

            var result = FluentMapper.Default.Map<EntityWithPlainNames, EntityWithPlainNames>(entity);

            Assert.IsTrue(result.PropertyGuid == DefaultData.Guid);
            Assert.IsTrue(result.PropertyInt == 10);
            Assert.IsTrue(result.PropertyString == "PropertyString");
            Assert.IsTrue(result.PropertyWithSpace == "PropertyWithSpace");
        }
    }
}
