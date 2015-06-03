using System.Collections.Generic;
using FluentPro.Common.Mapper.Model;

namespace FluentPro.Common.Mapper.Interfaces
{
    public interface IPropNamesMatcher
    {
        Dictionary<string, string> GetPropertiesMap(IEnumerable<MappingObjectPropInfo> src, IEnumerable<MappingObjectPropInfo> dest);
    }
}
