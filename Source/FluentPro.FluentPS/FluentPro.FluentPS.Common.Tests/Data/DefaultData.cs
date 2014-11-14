using System;
using System.Data;
using FluentPro.FluentPS.Common.Tests.Extensions;

namespace FluentPro.FluentPS.Common.Tests.Data
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
                    .Column("PROP_GUID", typeof(Guid))
                    .Column("PropertyInt", typeof(int))
                    .Column("PropertyString", typeof(string))
                    .Column("Property With Space", typeof(string));

                dt.Row(Guid, Guid, 10, "PropertyString", "PropertyWithSpace");

                return dt;
            }
        }
    }
}
