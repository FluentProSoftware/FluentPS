using System.Collections.Generic;
using FluentPro.Common.Mapper.Model;

namespace FluentPro.Common.Mapper.Interfaces
{
    public interface IPropsMatcher
    {
        Dictionary<string, string> GetPropertisMap(IEnumerable<MappingObjectPropInfo> src, IEnumerable<MappingObjectPropInfo> dest);
    }
}
