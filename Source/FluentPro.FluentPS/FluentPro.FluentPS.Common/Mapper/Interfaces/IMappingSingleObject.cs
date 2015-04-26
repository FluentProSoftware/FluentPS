using FluentPro.FluentPS.Common.Mapper.Model;
using System.Collections.Generic;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingSingleObject : IMappingObject
    {
        object this[string propName] { get; set; }
        IEnumerable<MappingObjectPropInfo> Properties { get; }
        bool CanDiscoverProperties { get; }
    }
}
