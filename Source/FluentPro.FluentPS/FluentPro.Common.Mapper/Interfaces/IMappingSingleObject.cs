using System.Collections.Generic;
using FluentPro.Common.Mapper.Model;

namespace FluentPro.Common.Mapper.Interfaces
{
    public interface IMappingSingleObject : IMappingObject
    {
        object this[string propName] { get; set; }
        IEnumerable<MappingObjectPropInfo> Properties { get; }
    }
}
