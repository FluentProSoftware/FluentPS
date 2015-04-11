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
    public class PlainMapperTests
    {
        [TestMethod, Description("Ensure row values mapped to coresponding entity properties by name.")]
        public void Map_DataTableReaderToEntity_ShouldReturnEntity()
        {
            var reader = DefaultData.DataTable.CreateDataReader();
            reader.Read();

            var entity = FluentMapper.PlainMapper.Map<DataTableReader, EntityWithPlainNames>(reader);

            Assert.IsTrue(entity.PropertyGuid == DefaultData.Guid);
            Assert.IsTrue(entity.PropertyInt == 10);
            Assert.IsTrue(entity.PropertyString == "PropertyString");
            Assert.IsTrue(entity.PropertyWithSpace == "PropertyWithSpace");
            Assert.IsTrue(entity.PropertyWithDummyEnum == DummyEnum.Hundred);
            Assert.IsTrue(entity.PropertyWithDummyEnum1 == DummyEnum.Max);
        }

        [TestMethod, Description("Ensure row values mapped to corresponding property bag properties by name.")]
        public void Map_DataTableReaderToDictionary_ShouldReturnEntity()
        {
            var reader = DefaultData.DataTable.CreateDataReader();
            reader.Read();

            var bag = FluentMapper.PlainMapper.Map<DataTableReader, Dictionary<string, object>>(reader);

            Assert.IsTrue((Guid)bag["PropertyGuid"] == DefaultData.Guid);
            Assert.IsTrue((int)bag["PropertyInt"] == 10);
            Assert.IsTrue((string)bag["PropertyString"] == "PropertyString");
            Assert.IsTrue((string)bag["Property With Space"] == "PropertyWithSpace");
            Assert.IsTrue((DummyEnum)bag["PropertyWithDummyEnum"] == DummyEnum.Hundred);
            Assert.IsTrue((DummyEnum)bag["PropertyWithDummyEnum1"] == DummyEnum.Max);
        }

        [TestMethod, Description("Ensure entity values mapped to corresponding entity properties by name.")]
        public void Map_EntityWithPlainNamesToEntityWithPlainNames_ShouldReturnEntityWithPlainNames()
        {
            var entity = new EntityWithPlainNames
            {
                PropertyGuid = DefaultData.Guid,
                PropertyInt = 10,
                PropertyString = "PropertyString",
                PropertyWithSpace = "PropertyWithSpace",
                PropertyWithDummyEnum = DummyEnum.Hundred,
                PropertyWithDummyEnum1 = DummyEnum.Max
            };

            var result = FluentMapper.PlainMapper.Map<EntityWithPlainNames, EntityWithPlainNames>(entity);

            Assert.IsTrue(result.PropertyGuid == DefaultData.Guid);
            Assert.IsTrue(result.PropertyInt == 10);
            Assert.IsTrue(result.PropertyString == "PropertyString");
            Assert.IsTrue(result.PropertyWithSpace == "PropertyWithSpace");
            Assert.IsTrue(entity.PropertyWithDummyEnum == DummyEnum.Hundred);
            Assert.IsTrue(entity.PropertyWithDummyEnum1 == DummyEnum.Max);
        }

        [TestMethod, Description("Ensure row values mapped to coresponding entity properties by name.")]
        public void Map_DataTableReaderToEntitiesList_ShouldReturnEntitiesList()
        {
            var reader = DefaultData.DataTable.CreateDataReader();

            var entities = FluentMapper.PlainMapper.Map<DataTableReader, List<EntityWithPlainNames>>(reader);

            foreach (var entity in entities)
            {
                Assert.IsTrue(entity.PropertyGuid == DefaultData.Guid);
                Assert.IsTrue(entity.PropertyInt == 10);
                Assert.IsTrue(entity.PropertyString == "PropertyString");
                Assert.IsTrue(entity.PropertyWithSpace == "PropertyWithSpace");
                Assert.IsTrue(entity.PropertyWithDummyEnum == DummyEnum.Hundred);
                Assert.IsTrue(entity.PropertyWithDummyEnum1 == DummyEnum.Max);
            }
        }
    }
}
