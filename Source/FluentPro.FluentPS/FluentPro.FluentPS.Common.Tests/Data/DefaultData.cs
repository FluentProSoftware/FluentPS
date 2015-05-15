using System;
using System.Data;
using FluentPro.Common.Mapper.Tests.Data.Extensions;
using FluentPro.Common.Mapper.Tests.Model;

namespace FluentPro.Common.Mapper.Tests.Data
{
    public static class DefaultData
    {
        public static Guid Guid = new Guid("7E4DDBE5-4F1E-4952-96DF-485FCB854348");

        public static DataTable DataTable
        {
            get
            {
                var dt = new DataTable()
                    .Column("PropertyGuid", typeof(Guid))
                    .Column("PropertyInt", typeof(int))
                    .Column("PropertyString", typeof(string))
                    .Column("Property With Space", typeof(string))
                    .Column("PropertyWithDummyEnum", typeof(int))
                    .Column("PropertyWithDummyEnum1", typeof(int));

                dt.Row(Guid, 10, "PropertyString", "PropertyWithSpace", (int)DummyEnum.Hundred, (int)DummyEnum.Max);

                return dt;
            }
        }
    }
}
