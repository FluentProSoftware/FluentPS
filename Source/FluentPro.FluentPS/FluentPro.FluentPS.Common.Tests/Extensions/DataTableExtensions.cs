using System;
using System.Data;

namespace FluentPro.FluentPS.Common.Tests.Extensions
{
    public static class DataTableExtensions
    {
        public static DataTable Column(this DataTable dt, string name, Type type)
        {
            dt.Columns.Add(name, type);
            return dt;
        }

        public static DataTable Row(this DataTable dt, params object[] values)
        {
            var row = dt.NewRow();
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                var col = dt.Columns[i];
                var val = values[i];
                row[col.ColumnName] = val;
            }

            dt.Rows.Add(row);
            return dt;
        }
    }
}
