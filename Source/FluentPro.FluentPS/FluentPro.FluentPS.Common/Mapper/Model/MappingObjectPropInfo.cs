using System;
using System.Diagnostics;

namespace FluentPro.FluentPS.Common.Mapper.Model
{
    [DebuggerDisplay("{Name}")]
    public class MappingObjectPropInfo
    {
        public string Name { get; set; }

        public Type Type { get; set; }
    }
}
