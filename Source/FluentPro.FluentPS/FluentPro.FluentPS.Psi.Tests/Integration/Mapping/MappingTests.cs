using System;
using System.Collections.Generic;
using FluentPro.Common.Mapper;
using FluentPro.Common.Mapper.Configurations.PropsMatchers;
using FluentPro.Common.Mapper.Interfaces;
using FluentPro.FluentPS.Mapper;
using FluentPro.FluentPS.Psi.Model.DataSets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentPro.FluentPS.Psi.Tests.Integration.Mapping
{
    [TestClass]
    public class MappingTests
    {
        private static IFluentMapper _mapper;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _mapper = new FluentMapper(new PsMappingConfiguration());
        }

        [TestMethod]
        public void MapDictionaryToTaskRow_ShouldMapDictionaryToNativeTaskFields()
        {
            var projectDs = new ProjectDataSet();
            var row = projectDs.Task.NewTaskRow();

            var fields = new Dictionary<string, object>
            {
                { projectDs.Task.TASK_IDColumn.ColumnName, 100 },
                { projectDs.Task.TASK_NAMEColumn.ColumnName, "NewTask" }
            };

            _mapper.Map(fields, row, new NopPropsMatcher());

            Assert.IsTrue(row["TASK_NAME"].Equals("NewTask"));
            Assert.IsTrue(row["TASK_ID"].Equals(DBNull.Value));
        }
    }
}
