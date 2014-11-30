using System.Collections.Generic;
using System.Diagnostics;

namespace FluentPro.FluentPS.Common.DataSetAnalyzer.Model
{
    [DebuggerDisplay("{DataSetName}")]
    public class DataSetInfo
    {
        public string DataSetName { get; set; }

        public HashSet<TableInfo> Tables { get; set; }

        public DataSetInfo()
        {
            Tables = new HashSet<TableInfo>();
        }
    }
}
