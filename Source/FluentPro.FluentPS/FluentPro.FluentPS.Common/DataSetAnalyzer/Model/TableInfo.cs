using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FluentPro.FluentPS.Common.DataSetAnalyzer.Model
{
    [DebuggerDisplay("{Name}, Rows = {RowsCount}, Fields = {FilledColumnsString}")]
    public class TableInfo
    {
        public TableInfo()
        {
            FilledColumns = new HashSet<string>();
        }

        public string Name { get; set; }

        public int RowsCount { get; set; }

        public HashSet<string> FilledColumns { get; set; }

        private string FilledColumnsString
        {
            get
            {
                var arr = FilledColumns.ToArray();
                var sb = new StringBuilder();
                for (var i = 0; i < FilledColumns.Count - 1; i++)
                {
                    sb.AppendFormat("{0}, ", arr[i]);
                }

                if (FilledColumns.Count > 0)
                {
                    sb.AppendFormat("{0}", arr[FilledColumns.Count - 1]);
                }

                return sb.ToString();
            }
        }
    }
}
