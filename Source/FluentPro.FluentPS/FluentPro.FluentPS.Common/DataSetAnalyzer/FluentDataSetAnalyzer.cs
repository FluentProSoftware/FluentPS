using FluentPro.FluentPS.Common.DataSetAnalyzer.Model;
using System;
using System.Data;

namespace FluentPro.FluentPS.Common.DataSetAnalyzer
{
    public static class FluentDataSetAnalyzer
    {
        public static DataSetInfo GetDataSetInfo(DataSet ds)
        {
            var result = new DataSetInfo();
            result.DataSetName = ds.DataSetName;
            foreach (DataTable table in ds.Tables)
            {
                result.Tables.Add(GetTableInfo(table));
            }

            return result;
        }

        private static TableInfo GetTableInfo(DataTable dt)
        {
            var result = new TableInfo();
            result.Name = dt.TableName;
            result.RowsCount = dt.Rows.Count;

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    if (row[col] == DBNull.Value || row[col] == null)
                    {
                        continue;
                    }

                    result.FilledColumns.Add(col.ColumnName);
                }
            }

            return result;
        }
    }
}
