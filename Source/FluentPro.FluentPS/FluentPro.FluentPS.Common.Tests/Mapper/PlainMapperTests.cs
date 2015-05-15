using System;
using System.Collections.Generic;
using System.Data;
using FluentPro.Common.Mapper.Configurations;
using FluentPro.Common.Mapper.Configurations.PropertyNameConverters;
using FluentPro.Common.Mapper.Tests.Data;
using FluentPro.Common.Mapper.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.Common.Mapper.Tests.Mapper
{
    [TestClass]
    public class PlainMapperTests
    {
        [TestMethod, Description("Ensure row values mapped to coresponding entity properties by name.")]
        public void Map_DataTableReaderToEntity_ShouldReturnEntity()
        {
            var sut = new FluentMapper(new DefaultMappingConfiguration());
            
            var reader = DefaultData.DataTable.CreateDataReader();
            reader.Read();

            var entity = sut.Map<DataTableReader, EntityWithPlainNames>(reader);

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
            var sut = new FluentMapper(new DefaultMappingConfiguration());

            var reader = DefaultData.DataTable.CreateDataReader();
            reader.Read();

            var bag = sut.Map<DataTableReader, Dictionary<string, object>>(reader);

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
            var sut = new FluentMapper(new DefaultMappingConfiguration());

            var entity = new EntityWithPlainNames
            {
                PropertyGuid = DefaultData.Guid,
                PropertyInt = 10,
                PropertyString = "PropertyString",
                PropertyWithSpace = "PropertyWithSpace",
                PropertyWithDummyEnum = DummyEnum.Hundred,
                PropertyWithDummyEnum1 = DummyEnum.Max
            };

            var result = sut.Map<EntityWithPlainNames, EntityWithPlainNames>(entity);

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
            var sut = new FluentMapper(new DefaultMappingConfiguration());

            var reader = DefaultData.DataTable.CreateDataReader();

            var entities = sut.Map<DataTableReader, List<EntityWithPlainNames>>(reader);

            Assert.IsTrue(entities.Count > 0);

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
