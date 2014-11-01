using FluentPro.FluentPS.Common.Mapper;
using FluentPro.FluentPS.Common.Tests.Extensions;
using FluentPro.FluentPS.Common.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace FluentPro.FluentPS.Common.Tests.Mapper
{
    [TestClass]
    public class MapperTest
    {
        [TestMethod, Description("Ensure row values mapped to coresponding entity properties by name, default convention.")]
        public void Map_DataTableToEntity_ByPlainName_ShouldReturnEntity()
        {
            var guid = Guid.NewGuid();
            var dt = new DataTable()
                .Column("ProjectUID", typeof (Guid))
                .Column("CustomField", typeof (string))
                .Column("CustomField2", typeof (string));

            dt.Row(guid, "CF1", "CF2");

            var reader = dt.CreateDataReader();
            reader.Read();
            var project = DsMapper.Map<DataTableReader, Project>(reader);
            Assert.IsTrue(project.ProjectUID == guid);
        }
    }
}
